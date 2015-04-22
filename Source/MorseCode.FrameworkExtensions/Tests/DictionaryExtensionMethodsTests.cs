#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DictionaryExtensionMethodsTests.cs" company="MorseCode Software">
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
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class DictionaryExtensionMethodsTests
    {
        #region Public Methods and Operators

        [Test]
        public void GetValue()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 5, "first" }, { 7, "second" } };
            string result = dictionary.GetValue(5, "NOT FOUND!");

            Assert.AreEqual("first", result);
        }

        [Test]
        public void GetValueNotFound()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 5, "first" }, { 7, "second" } };
            string result = dictionary.GetValue(1, "NOT FOUND!");

            Assert.AreEqual("NOT FOUND!", result);
        }

        [Test]
        public void GetValueWithFactory()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 5, "first" }, { 7, "second" } };
            string result = dictionary.GetValue(5, () => "NOT FOUND!");

            Assert.AreEqual("first", result);
        }

        [Test]
        public void GetValueNotFoundWithFactory()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 5, "first" }, { 7, "second" } };
            string result = dictionary.GetValue(1, () => "NOT FOUND!");

            Assert.AreEqual("NOT FOUND!", result);
        }

        [Test]
        public void GetValueOrNull()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 5, "first" }, { 7, "second" } };
            string result = dictionary.GetValueOrNull(5);

            Assert.AreEqual("first", result);
        }

        [Test]
        public void GetValueOrNullNotFound()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 5, "first" }, { 7, "second" } };
            string result = dictionary.GetValueOrNull(1);

            Assert.IsNull(result);
        }

        [Test]
        public void GetValueOrNullWithStruct()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int> { { 5, 1 }, { 7, 2 } };
            int? result = dictionary.GetValueOrNullForStruct(5);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetValueOrNullWithStructNotFound()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int> { { 5, 1 }, { 7, 2 } };
            int? result = dictionary.GetValueOrNullForStruct(1);

            Assert.IsNull(result);
        }

        #endregion
    }
}