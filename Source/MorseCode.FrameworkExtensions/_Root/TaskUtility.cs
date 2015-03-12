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
            Contract.Requires(createTask != null);

            AsyncHelper.FireAndForget(createTask);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete and ignoring any unhandled exceptions.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        public static void FireAndForget(Func<ITask> createTask)
        {
            Contract.Requires(createTask != null);

            AsyncHelper.FireAndForget(createTask().AsTask);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="Task"/> to execute asynchronously.</param>
        /// <param name="handleException">Method to handle exceptions thrown by the task created by <paramref name="createTask"/>.</param>
        public static void FireAndForget(Func<Task> createTask, Action<Exception> handleException)
        {
            Contract.Requires(createTask != null);

            AsyncHelper.FireAndForget(createTask, handleException);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        /// <param name="handleException">Method to handle exceptions thrown by the task created by <paramref name="createTask"/>.</param>
        public static void FireAndForget(Func<ITask> createTask, Action<Exception> handleException)
        {
            Contract.Requires(createTask != null);

            AsyncHelper.FireAndForget(createTask().AsTask, handleException);
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="Task"/> to execute asynchronously.</param>
        public static void SafelyRunSynchronously(Func<Task> createTask)
        {
            Contract.Requires(createTask != null);

            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                asyncBridge.Run(createTask());
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously.
        /// </summary>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        public static void SafelyRunSynchronously(Func<ITask> createTask)
        {
            Contract.Requires(createTask != null);

            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                asyncBridge.Run(createTask().AsTask());
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
            Contract.Requires(createTask != null);

            T result = default(T);
            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                asyncBridge.Run(createTask(), r => result = r);
            }

            return result;
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously and returns its result.
        /// </summary>
        /// <typeparam name="T">The type of the return value of the task created by <paramref name="createTask"/>.</typeparam>
        /// <param name="createTask">A function that creates and returns the <see cref="ITask"/> to execute asynchronously.</param>
        /// <returns>The result of the task created by <paramref name="createTask"/>.</returns>
        public static T SafelyRunSynchronously<T>(Func<ITask<T>> createTask)
        {
            Contract.Requires(createTask != null);

            T result = default(T);
            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                asyncBridge.Run(createTask().AsTask(), r => result = r);
            }

            return result;
        }

        #endregion
    }
}