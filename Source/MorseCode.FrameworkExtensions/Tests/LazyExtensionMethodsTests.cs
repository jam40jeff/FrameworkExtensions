#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyExtensionMethodsTests.cs" company="MorseCode Software">
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
    public class LazyExtensionMethodsTests
    {
        [Test]
        public void EnsureValue()
        {
            Lazy<int> lazy = new Lazy<int>(() => 5);
            lazy.EnsureValue();

            Assert.IsTrue(lazy.IsValueCreated);
        }

        [Test]
        public void EnsureValueThrowsException()
        {
            const string ExpectedMessage = "expected exception message";

            Lazy<int> lazy = new Lazy<int>(() => { throw new Exception(ExpectedMessage); });

            Exception actual = null;
            try
            {
                lazy.EnsureValue();
            }
            catch (Exception e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(ExpectedMessage, actual.Message);
        }

        [Test]
        public void EnsureValueForNull()
        {
            ArgumentNullException actual = null;
            try
            {
                ((Lazy<int>)null).EnsureValue();
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("lazy", actual.ParamName);
        }
    }
}