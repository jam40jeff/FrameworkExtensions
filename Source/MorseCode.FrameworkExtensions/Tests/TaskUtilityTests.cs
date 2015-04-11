#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TaskUtilityTests.cs" company="MorseCode Software">
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

namespace MorseCode.FrameworkExtensions.Tests
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using MorseCode.ITask;

    using NUnit.Framework;

    [TestFixture]
    public class TaskUtilityTests
    {
        #region Public Methods and Operators

        [Test]
        public void FireAndForgetForITask()
        {
            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                    }
                    finally
                    {
                        r.Set();
                    }
                }).AsITask());

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }
        }

        [Test]
        public void FireAndForgetForITaskAndHandleException()
        {
            Exception actual = null;

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                    }
                    finally
                    {
                        r.Set();
                    }
                }).AsITask(), e => actual = e);

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }

            Assert.IsNull(actual);
        }

        [Test]
        public void FireAndForgetForITaskAndHandleExceptionWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    Thread.Sleep(50);
                    throw new Exception(ExpectedExceptionMessage);
                }).AsITask(), e =>
                    {
                        try
                        {
                            actual = e;
                        }
                        finally
                        {
                            r.Set();
                        }
                    });

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void FireAndForgetForITaskWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                        throw new Exception(ExpectedExceptionMessage);
                    }
                    finally
                    {
                        r.Set();
                    }
                }).AsITask());

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }
        }

        [Test]
        public void FireAndForgetForITaskWithReturnValue()
        {
            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                        return 0;
                    }
                    finally
                    {
                        r.Set();
                    }
                }).AsITask());

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }
        }

        [Test]
        public void FireAndForgetForITaskWithReturnValueAndHandleException()
        {
            Exception actual = null;

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                        return 0;
                    }
                    finally
                    {
                        r.Set();
                    }
                }).AsITask(), e => actual = e);

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }

            Assert.IsNull(actual);
        }

        [Test]
        public void FireAndForgetForITaskWithReturnValueAndHandleExceptionWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run((Func<int>)(() =>
                {
                    Thread.Sleep(50);
                    throw new Exception(ExpectedExceptionMessage);
                })).AsITask(), e =>
                    {
                        try
                        {
                            actual = e;
                        }
                        finally
                        {
                            r.Set();
                        }
                    });

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void FireAndForgetForITaskWithReturnValueWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run((Func<int>)(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                        throw new Exception(ExpectedExceptionMessage);
                    }
                    finally
                    {
                        r.Set();
                    }
                })).AsITask());

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }
        }

        [Test]
        public void FireAndForgetForTask()
        {
            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                    }
                    finally
                    {
                        r.Set();
                    }
                }));

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }
        }

        [Test]
        public void FireAndForgetForTaskAndHandleException()
        {
            Exception actual = null;

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                    }
                    finally
                    {
                        r.Set();
                    }
                }), e => actual = e);

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }

            Assert.IsNull(actual);
        }

        [Test]
        public void FireAndForgetForTaskAndHandleExceptionWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    Thread.Sleep(50);
                    throw new Exception(ExpectedExceptionMessage);
                }), e =>
                    {
                        try
                        {
                            actual = e;
                        }
                        finally
                        {
                            r.Set();
                        }
                    });

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void FireAndForgetForTaskWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            ManualResetEventSlim r = new ManualResetEventSlim();
            TaskUtility.FireAndForget(() => Task.Run(() =>
                {
                    try
                    {
                        Thread.Sleep(50);
                        throw new Exception(ExpectedExceptionMessage);
                    }
                    finally
                    {
                        r.Set();
                    }
                }));

            if (!r.Wait(1000))
            {
                throw new Exception("Timed out waiting for the task to complete.");
            }
        }

        [Test]
        public void SafelyRunSynchronouslyForITask()
        {
            bool finished = false;

            TaskUtility.SafelyRunSynchronously(
                () => TaskInterfaceFactory.CreateTask(async () =>
                    {
                        await Task.Delay(50).ConfigureAwait(true);
                        finished = true;
                    }));

            Assert.IsTrue(finished);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously((Func<ITask>)(() => { throw new Exception(ExpectedExceptionMessage); }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithNull()
        {
            ArgumentException actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously(() => (ITask)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The createTask function may not return null." + Environment.NewLine + "Parameter name: createTask", actual.Message);
            Assert.AreEqual("createTask", actual.ParamName);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithReturn()
        {
            const int Value = 5;

            bool finished = false;

            int result = TaskUtility.SafelyRunSynchronously(
                () => TaskInterfaceFactory.CreateTask(async () =>
                    {
                        await Task.Delay(50).ConfigureAwait(true);
                        finished = true;
                        return Value;
                    }));

            Assert.IsTrue(finished);
            Assert.AreEqual(Value, result);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithReturnWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously((Func<ITask<int>>)(() => { throw new Exception(ExpectedExceptionMessage); }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithReturnWithNull()
        {
            ArgumentException actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously(() => (ITask<int>)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The createTask function may not return null." + Environment.NewLine + "Parameter name: createTask", actual.Message);
            Assert.AreEqual("createTask", actual.ParamName);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithReturnWithTaskThrowingException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously(
                    () => TaskInterfaceFactory.CreateTask<int>(async () =>
                    {
                        await Task.Delay(50).ConfigureAwait(true);
                        throw new Exception(ExpectedExceptionMessage);
                    }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForITaskWithTaskThrowingException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously(
                    () => TaskInterfaceFactory.CreateTask(async () =>
                        {
                            await Task.Delay(50).ConfigureAwait(true);
                            throw new Exception(ExpectedExceptionMessage);
                        }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForTask()
        {
            bool finished = false;

            TaskUtility.SafelyRunSynchronously(async () =>
                {
                    await Task.Delay(50).ConfigureAwait(true);
                    finished = true;
                });

            Assert.IsTrue(finished);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithNull()
        {
            ArgumentException actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously(() => (Task)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The createTask function may not return null." + Environment.NewLine + "Parameter name: createTask", actual.Message);
            Assert.AreEqual("createTask", actual.ParamName);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithReturn()
        {
            const int Value = 5;

            bool finished = false;

            int result = TaskUtility.SafelyRunSynchronously(async () =>
                {
                    await Task.Delay(50).ConfigureAwait(true);
                    finished = true;
                    return Value;
                });

            Assert.IsTrue(finished);
            Assert.AreEqual(Value, result);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithReturnWithNull()
        {
            ArgumentException actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously(() => (Task<int>)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The createTask function may not return null." + Environment.NewLine + "Parameter name: createTask", actual.Message);
            Assert.AreEqual("createTask", actual.ParamName);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously((Func<Task>)(() => { throw new Exception(ExpectedExceptionMessage); }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithReturnWithException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously((Func<Task<int>>)(() => { throw new Exception(ExpectedExceptionMessage); }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithReturnWithTaskThrowingException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously((Func<Task<int>>)(async () =>
                    {
                        await Task.Delay(50).ConfigureAwait(true);
                        throw new Exception(ExpectedExceptionMessage);
                    }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public void SafelyRunSynchronouslyForTaskWithTaskThrowingException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            try
            {
                TaskUtility.SafelyRunSynchronously((Func<Task>)(async () =>
                    {
                        await Task.Delay(50).ConfigureAwait(true);
                        throw new Exception(ExpectedExceptionMessage);
                    }));
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public async Task FromException()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            Task task = TaskUtility.FromException(new Exception(ExpectedExceptionMessage));

            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsFaulted);
            Assert.IsTrue(task.IsCompleted);
            Assert.AreEqual(task.Status, TaskStatus.Faulted);

            try
            {
                await task.ConfigureAwait(true);
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        [Test]
        public async Task FromExceptionWithReturn()
        {
            const string ExpectedExceptionMessage = "Expected exception message.";

            Exception actual = null;

            Task<int> task = TaskUtility.FromException<int>(new Exception(ExpectedExceptionMessage));

            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsFaulted);
            Assert.IsTrue(task.IsCompleted);
            Assert.AreEqual(task.Status, TaskStatus.Faulted);

            try
            {
                await task.ConfigureAwait(true);
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedExceptionMessage, actual.Message);
        }

        #endregion
    }
}