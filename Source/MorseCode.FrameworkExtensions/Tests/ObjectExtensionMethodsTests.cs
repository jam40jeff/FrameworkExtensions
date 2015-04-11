﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectExtensionMethodsTests.cs" company="MorseCode Software">
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
    using NUnit.Framework;

    [TestFixture]
    public class ObjectExtensionMethodsTests
    {
        #region Public Methods and Operators

        [Test]
        public void ImplictConvert()
        {
            const string Value = "test";
            object o = Value.ImplicitConvert<object>();

            Assert.AreSame(Value, o);
        }

        [Test]
        public void ImplictConvertWithSameType()
        {
            const string Value = "test";
            string o = Value.ImplicitConvert();

            Assert.AreSame(Value, o);
        }

        [Test]
        public void SafeToString()
        {
            const string Value = "test";
            Test test = new Test(Value);

            Assert.AreEqual("The value is " + Value + ".", test.SafeToString());
        }

        [Test]
        public void SafeToWithString()
        {
            Assert.AreEqual(null, ((Test)null).SafeToString());
        }

        #endregion

        private class Test
        {
            #region Fields

            private readonly string value;

            #endregion

            #region Constructors and Destructors

            public Test(string value)
            {
                this.value = value;
            }

            #endregion

            #region Public Methods and Operators

            public override string ToString()
            {
                return "The value is " + this.value + ".";
            }

            #endregion
        }
    }
}