#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListExtensionMethodsTests.cs" company="MorseCode Software">
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
    public class ListExtensionMethodsTests
    {
        #region Public Methods and Operators

        [Test]
        public void SetTo()
        {
            List<int> target = new List<int> { 5, 6, 7 };
            target.SetTo(new[] { 1, 2 });

            Assert.IsNotNull(target);
            Assert.AreEqual(2, target.Count);
            Assert.AreEqual(1, target[0]);
            Assert.AreEqual(2, target[1]);
        }

        [Test]
        public void SetToEmpty()
        {
            List<int> target = new List<int> { 5, 6, 7 };
            target.SetTo(new int[0]);

            Assert.IsNotNull(target);
            Assert.AreEqual(0, target.Count);
        }

        [Test]
        public void SetToNull()
        {
            List<int> target = new List<int> { 5, 6, 7 };
            target.SetTo(null);

            Assert.IsNotNull(target);
            Assert.AreEqual(0, target.Count);
        }

        [Test]
        public void SetToSame()
        {
            List<int> target = new List<int> { 5, 6, 7 };
            List<int> source = target;
            target.SetTo(source);

            Assert.AreSame(source, target);
        }

        #endregion
    }
}