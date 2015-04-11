#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNullMutableTests.cs" company="MorseCode Software">
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

    using NUnit.Framework;

    [TestFixture]
    public class NotNullMutableTests
    {
        #region Public Methods and Operators

        [Test]
        public void Create()
        {
            const string Value = "test value";

            INotNullMutable<string> value = NotNull.CreateMutable(Value);

            Assert.IsNotNull(value);
            Assert.IsNotNull(value.Value);
            Assert.AreEqual(Value, value.Value);
        }

        [Test]
        public void CreateWithNull()
        {
            ArgumentNullException actual = null;

            try
            {
                NotNull.CreateMutable<string>(null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("value", actual.ParamName);
        }

        [Test]
        public void CreateWithValueType()
        {
            const int Value = 5;

            INotNullMutable<int> value = NotNull.CreateMutable(Value);

            Assert.IsNotNull(value);
            Assert.IsNotNull(value.Value);
            Assert.AreEqual(Value, value.Value);
        }

        [Test]
        public void Modify()
        {
            const string Value = "test value";
            const string Value2 = "test value 2";

            INotNullMutable<string> value = NotNull.CreateMutable(Value);
            value.Value = Value2;

            Assert.IsNotNull(value);
            Assert.IsNotNull(value.Value);
            Assert.AreEqual(Value2, value.Value);
        }

        [Test]
        public void ModifyWithNull()
        {
            const string Value = "test value";

            ArgumentNullException actual = null;

            INotNullMutable<string> value = NotNull.CreateMutable(Value);

            try
            {
                value.Value = null;
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("value", actual.ParamName);
        }

        #endregion
    }
}