#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AsyncHelper.cs" company="MorseCode Software">
// Copyright (c) 2015 MorseCode Software
// </copyright>
// <summary>
// The MIT License (MIT)
// 
// Copyright (c) 2015 MorseCode Software
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace MorseCode.FrameworkExtensions
{
    using System;
    using System.Collections.Concurrent;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// A Helper class to run Asynchronous functions from synchronous ones
    /// </summary>
    [ContractVerification(false)]
    internal static class AsyncHelper
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a new AsyncBridge. This should always be used in
        /// conjunction with the using statement, to ensure it is disposed
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1615:ElementReturnValueMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
        public static AsyncBridge CreateBridge()
        {
            Contract.Ensures(Contract.Result<AsyncBridge>() != null);

            return new AsyncBridge();
        }

        /// <summary>
        /// Runs a task with the "Fire and Forget" pattern using Task.Run,
        /// and unwraps and handles exceptions
        /// </summary>
        /// <param name="task">A function that returns the task to run</param>
        /// <param name="handle">Error handling action, null by default</param>
        public static void FireAndForget(Func<Task> task, Action<Exception> handle = null)
        {
            Task.Run(() =>
                {
                    ((Func<Task>)(async () =>
                        {
                            try
                            {
                                await task().ConfigureAwait(true);
                            }
                            catch (Exception e)
                            {
                                if (null != handle)
                                {
                                    handle(e);
                                }
                            }
                        }))();
                });
        }

        #endregion

        /// <summary>
        /// A class to bridge synchronous asynchronous methods
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1512:SingleLineCommentsMustNotBeFollowedByBlankLine", Justification = "Reviewed. Suppression is OK here.")]
        public class AsyncBridge : IDisposable
        {
            #region Fields

            [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable InconsistentNaming
            // ReSharper disable FieldCanBeMadeReadOnly.Local
            private ExclusiveSynchronizationContext CurrentContext;

            // ReSharper restore FieldCanBeMadeReadOnly.Local

            // ReSharper restore InconsistentNaming
            [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable InconsistentNaming
            // ReSharper disable FieldCanBeMadeReadOnly.Local
            private SynchronizationContext OldContext;

            // ReSharper restore FieldCanBeMadeReadOnly.Local

            // ReSharper restore InconsistentNaming
            [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable InconsistentNaming
            private int TaskCount;

            #endregion

            // ReSharper restore InconsistentNaming
            #region Constructors and Destructors

            /// <summary>
            /// Constructs the AsyncBridge by capturing the current
            /// SynchronizationContext and replacing it with a new
            /// ExclusiveSynchronizationContext.
            /// </summary>
            [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1642:ConstructorSummaryDocumentationMustBeginWithStandardText", Justification = "Reviewed. Suppression is OK here.")]
            internal AsyncBridge()
            {
                this.OldContext = SynchronizationContext.Current;
                this.CurrentContext = new ExclusiveSynchronizationContext(this.OldContext);
                SynchronizationContext.SetSynchronizationContext(this.CurrentContext);
            }

            #endregion

            #region Public Methods and Operators

            /// <summary>
            /// Disposes the object
            /// </summary>
            [SuppressMessage("Microsoft.Usage", "CA2200:RethrowToPreserveStackDetails", Justification = "Reviewed. Suppression is OK here.")]
            public void Dispose()
            {
                try
                {
                    this.CurrentContext.BeginMessageLoop();
                }
                catch (Exception e)
                {
                    // ReSharper disable PossibleIntendedRethrow
                    throw e;
                    // ReSharper restore PossibleIntendedRethrow
                }
                finally
                {
                    SynchronizationContext.SetSynchronizationContext(this.OldContext);
                }
            }

            /// <summary>
            /// Execute's an async task with a void return type
            /// from a synchronous context
            /// </summary>
            /// <param name="task">Task to execute</param>
            /// <param name="callback">Optional callback</param>
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1115:ParameterMustFollowComma", Justification = "Reviewed. Suppression is OK here.")]
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1116:SplitParametersMustStartOnLineAfterDeclaration", Justification = "Reviewed. Suppression is OK here.")]
            [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
            public void Run(Task task, Action<Task> callback = null)
            {
                this.CurrentContext.Post(async _ =>
                    {
                        try
                        {
                            this.Increment();
                            await task.ConfigureAwait(true);

                            if (null != callback)
                            {
                                callback(task);
                            }
                        }
                        catch (Exception e)
                        {
                            this.CurrentContext.InnerException = e;
                        }
                        finally
                        {
                            this.Decrement();
                        }
                    }, null);
            }

            /// <summary>
            /// Execute's an async task with a T return type
            /// from a synchronous context
            /// </summary>
            /// <typeparam name="T">The type of the task</typeparam>
            /// <param name="task">Task to execute</param>
            /// <param name="callback">Optional callback</param>
            [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable MemberCanBePrivate.Local
            public void Run<T>(Task<T> task, Action<Task<T>> callback = null) // ReSharper restore MemberCanBePrivate.Local
            {
                if (null != callback)
                {
                    this.Run((Task)task, finishedTask => callback((Task<T>)finishedTask));
                }
                else
                {
                    this.Run((Task)task);
                }
            }

            /// <summary>
            /// Execute's an async task with a T return type
            /// from a synchronous context
            /// </summary>
            /// <typeparam name="T">The type of the task</typeparam>
            /// <param name="task">Task to execute</param>
            /// <param name="callback">
            /// The callback function that uses the result of the task
            /// </param>
            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:PrefixLocalCallsWithThis", Justification = "Reviewed. Suppression is OK here.")]
            [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
            public void Run<T>(Task<T> task, Action<T> callback)
            {
                this.Run(task, t => callback(t.Result));
            }

            #endregion

            #region Methods

            private void Decrement()
            {
                Interlocked.Decrement(ref this.TaskCount);
                if (this.TaskCount == 0)
                {
                    this.CurrentContext.EndMessageLoop();
                }
            }

            private void Increment()
            {
                Interlocked.Increment(ref this.TaskCount);
            }

            #endregion
        }

        [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Justification = "Reviewed. Suppression is OK here.")]
        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1512:SingleLineCommentsMustNotBeFollowedByBlankLine", Justification = "Reviewed. Suppression is OK here.")]
        private class ExclusiveSynchronizationContext : SynchronizationContext
        {
            #region Fields

            [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:FieldNamesMustNotBeginWithUnderscore", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable InconsistentNaming
            private readonly AutoResetEvent _workItemsWaiting = new AutoResetEvent(false);

            // ReSharper restore InconsistentNaming
            [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:FieldNamesMustNotBeginWithUnderscore", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable InconsistentNaming
            private bool _done;

            // ReSharper restore InconsistentNaming
            [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1309:FieldNamesMustNotBeginWithUnderscore", Justification = "Reviewed. Suppression is OK here.")]
            // ReSharper disable InconsistentNaming
            // ReSharper disable FieldCanBeMadeReadOnly.Local
            private ConcurrentQueue<Tuple<SendOrPostCallback, object>> _items;

            #endregion

            // ReSharper restore FieldCanBeMadeReadOnly.Local

            // ReSharper restore InconsistentNaming
            // ReSharper restore FieldCanBeMadeReadOnly.Local
            #region Constructors and Destructors

            public ExclusiveSynchronizationContext(SynchronizationContext old)
            {
                ExclusiveSynchronizationContext oldEx = old as ExclusiveSynchronizationContext;

                // ReSharper disable ConvertIfStatementToConditionalTernaryExpression
                if (null != oldEx) // ReSharper restore ConvertIfStatementToConditionalTernaryExpression
                {
                    this._items = oldEx._items;
                }
                else
                {
                    this._items = new ConcurrentQueue<Tuple<SendOrPostCallback, object>>();
                }
            }

            #endregion

            // ReSharper disable MemberCanBePrivate.Local
            #region Public Properties

            public Exception InnerException { get; set; }

            #endregion

            // ReSharper restore MemberCanBePrivate.Local
            #region Public Methods and Operators

            [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1108:BlockStatementsMustNotContainEmbeddedComments", Justification = "Reviewed. Suppression is OK here.")]
            public void BeginMessageLoop()
            {
                while (!this._done)
                {
                    // ReSharper disable RedundantAssignment
                    Tuple<SendOrPostCallback, object> task = null;
                    // ReSharper restore RedundantAssignment
                    if (!this._items.TryDequeue(out task))
                    {
                        task = null;
                    }

                    if (task != null)
                    {
                        task.Item1(task.Item2);
                        if (this.InnerException != null) // method threw an exeption
                        {
                            throw new AggregateException("AsyncBridge.Run method threw an exception.", this.InnerException);
                        }
                    }
                    else
                    {
                        this._workItemsWaiting.WaitOne();
                    }
                }
            }

            public override SynchronizationContext CreateCopy()
            {
                return this;
            }

            public void EndMessageLoop()
            {
                this.Post(_ => this._done = true, null);
            }

            public override void Post(SendOrPostCallback d, object state)
            {
                this._items.Enqueue(Tuple.Create(d, state));
                this._workItemsWaiting.Set();
            }

            public override void Send(SendOrPostCallback d, object state)
            {
                throw new NotSupportedException("We cannot send to our same thread");
            }

            #endregion
        }
    }
}