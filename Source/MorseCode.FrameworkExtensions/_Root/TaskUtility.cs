#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskUtility.cs" company="MorseCode Software">
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
    using System.Diagnostics.Contracts;
    using System.Threading.Tasks;

    using MorseCode.ITask;

    /// <summary>
    /// Provides utility methods for the <see cref="Task"/> class.
    /// </summary>
    public static class TaskUtility
    {
        #region Public Methods and Operators

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete and ignoring any unhandled exceptions.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="Task"/> to execute asynchronously.</param>
        public static void FireAndForget(Func<Task> createTask)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            AsyncHelper.FireAndForget(createTask);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete and ignoring any unhandled exceptions.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        public static void FireAndForget(Func<ITask> createTask)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            AsyncHelper.FireAndForget(createTask().AsTask);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="Task"/> to execute asynchronously.</param>
        /// <param name="handleException">Method to handle exceptions thrown by the task created by <paramref name="createTask"/>.</param>
        public static void FireAndForget(Func<Task> createTask, Action<Exception> handleException)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            AsyncHelper.FireAndForget(createTask, handleException);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        /// <param name="handleException">Method to handle exceptions thrown by the task created by <paramref name="createTask"/>.</param>
        public static void FireAndForget(Func<ITask> createTask, Action<Exception> handleException)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            AsyncHelper.FireAndForget(createTask().AsTask, handleException);
        }

        /// <summary>Creates a <see cref="Task"/> that's completed with the specified exception.</summary>
        /// <param name="exception">The exception to store into the completed task.</param>
        /// <returns>The completed task in a faulted state.</returns>
        public static Task FromException(Exception exception)
        {
            Contract.Requires<ArgumentNullException>(exception != null, "exception");
            Contract.Ensures(Contract.Result<Task>() != null);

            return FromException<bool>(exception);
        }

        /// <summary>Creates a <see cref="Task{T}"/> that's completed with the specified exception.</summary>
        /// <typeparam name="T">The type of the result returned by the task.</typeparam>
        /// <param name="exception">The exception to store into the completed task.</param>
        /// <returns>The completed task in a faulted state.</returns>
        public static Task<T> FromException<T>(Exception exception)
        {
            Contract.Requires<ArgumentNullException>(exception != null, "exception");
            Contract.Ensures(Contract.Result<Task<T>>() != null);

            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            tcs.SetException(exception);
            Contract.Assume(tcs.Task != null);
            return tcs.Task;
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="Task"/> to execute asynchronously.</param>
        public static void SafelyRunSynchronously(Func<Task> createTask)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            try
            {
                using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
                {
                    Task task;
                    try
                    {
                        task = createTask() ?? FromException(new ArgumentException("The createTask function may not return null.", "createTask"));
                    }
                    catch (Exception e)
                    {
                        task = FromException(e);
                    }

                    asyncBridge.Run(task);
                }
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        public static void SafelyRunSynchronously(Func<ITask> createTask)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            try
            {
                using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
                {
                    ITask task;
                    try
                    {
                        task = createTask() ?? FromException(new ArgumentException("The createTask function may not return null.", "createTask")).AsITask();
                    }
                    catch (Exception e)
                    {
                        task = FromException(e).AsITask();
                    }

                    asyncBridge.Run(task.AsTask());
                }
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously and returns its result.
        /// </summary>
        /// <typeparam name="T">The type of the return value of the task created by <paramref name="createTask"/>.</typeparam>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        /// <returns>The result of the task created by <paramref name="createTask"/>.</returns>
        public static T SafelyRunSynchronously<T>(Func<Task<T>> createTask)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            try
            {
                T result = default(T);
                using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
                {
                    Task<T> task;
                    try
                    {
                        task = createTask() ?? FromException<T>(new ArgumentException("The createTask function may not return null.", "createTask"));
                    }
                    catch (Exception e)
                    {
                        task = FromException<T>(e);
                    }

                    asyncBridge.Run(task, r => result = r);
                }

                return result;
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously and returns its result.
        /// </summary>
        /// <typeparam name="T">The type of the return value of the task created by <paramref name="createTask"/>.</typeparam>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        /// <returns>The result of the task created by <paramref name="createTask"/>.</returns>
        public static T SafelyRunSynchronously<T>(Func<ITask<T>> createTask)
        {
            Contract.Requires<ArgumentNullException>(createTask != null, "createTask");

            try
            {
                T result = default(T);
                using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
                {
                    ITask<T> task;
                    try
                    {
                        task = createTask() ?? FromException<T>(new ArgumentException("The createTask function may not return null.", "createTask")).AsITask();
                    }
                    catch (Exception e)
                    {
                        task = FromException<T>(e).AsITask();
                    }

                    asyncBridge.Run(task.AsTask(), r => result = r);
                }

                return result;
            }
            catch (AggregateException e)
            {
                throw e.InnerException;
            }
        }

        #endregion
    }
}