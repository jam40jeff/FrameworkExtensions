﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskExtensionMethods.cs" company="MorseCode Software">
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
    /// Provides extension methods for the <see cref="Task"/> class.
    /// </summary>
    public static class TaskExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete and ignoring any unhandled exceptions.
        /// </summary>
        /// <param name="task">The task to execute asynchronously.</param>
        public static void FireAndForget(this Task task)
        {
            Contract.Requires(task != null);

            AsyncHelper.FireAndForget(() => task);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete and ignoring any unhandled exceptions.
        /// </summary>
        /// <param name="task">The task to execute asynchronously.</param>
        public static void FireAndForget(this ITask task)
        {
            Contract.Requires(task != null);

            AsyncHelper.FireAndForget(task.AsTask);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete.
        /// </summary>
        /// <param name="task">The task to execute asynchronously.</param>
        /// <param name="handleException">Method to handle exceptions thrown by <paramref name="task"/>.</param>
        public static void FireAndForget(this Task task, Action<Exception> handleException)
        {
            Contract.Requires(task != null);

            AsyncHelper.FireAndForget(() => task, handleException);
        }

        /// <summary>
        /// Executes an asynchronous method without waiting for it to complete.
        /// </summary>
        /// <param name="task">The task to execute asynchronously.</param>
        /// <param name="handleException">Method to handle exceptions thrown by <paramref name="task"/>.</param>
        public static void FireAndForget(this ITask task, Action<Exception> handleException)
        {
            Contract.Requires(task != null);

            AsyncHelper.FireAndForget(task.AsTask, handleException);
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously.
        /// </summary>
        /// <param name="task">The task to execute synchronously.</param>
        public static void SafelyRunSynchronously(this Task task)
        {
            Contract.Requires(task != null);

            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                asyncBridge.Run(task);
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously.
        /// </summary>
        /// <param name="task">The task to execute synchronously.</param>
        public static void SafelyRunSynchronously(this ITask task)
        {
            Contract.Requires(task != null);

            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                asyncBridge.Run(task.AsTask());
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously and returns its result.
        /// </summary>
        /// <typeparam name="T">The type of the return value of <paramref name="task"/>.</typeparam>
        /// <param name="task">The task to execute synchronously.</param>
        /// <returns>The result of <paramref name="task"/>.</returns>
        public static T SafelyRunSynchronously<T>(this Task<T> task)
        {
            Contract.Requires(task != null);

            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                T result = default(T);
                asyncBridge.Run(task, r => result = r);
                return result;
            }
        }

        /// <summary>
        /// Safely executes an asynchronous method synchronously and returns its result.
        /// </summary>
        /// <typeparam name="T">The type of the return value of <paramref name="task"/>.</typeparam>
        /// <param name="task">The task to execute synchronously.</param>
        /// <returns>The result of <paramref name="task"/>.</returns>
        public static T SafelyRunSynchronously<T>(this ITask<T> task)
        {
            Contract.Requires(task != null);

            using (AsyncHelper.AsyncBridge asyncBridge = AsyncHelper.CreateBridge())
            {
                T result = default(T);
                asyncBridge.Run(task.AsTask(), r => result = r);
                return result;
            }
        }

        #endregion
    }
}