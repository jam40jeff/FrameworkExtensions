#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReferenceEqualsEqualityComparerTests.cs" company="MorseCode Software">
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
    using System.Collections;
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class ReferenceEqualsEqualityComparerTests
    {
        #region Public Methods and Operators

        [Test]
        public void BothNull()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(null, null));
        }

        [Test]
        public void FirstNull()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, new Test()));
        }

        [Test]
        public void FirstNullForStruct()
        {
            IEqualityComparer<object> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, 5));
        }

        [Test]
        public void GetHashCodeTest()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;
            Test a = new Test();

            Assert.AreEqual(a.GetHashCode(), comparer.GetHashCode(a));
        }

        [Test]
        public void GetHashCodeTestForStruct()
        {
            IEqualityComparer<object> comparer = ReferenceEqualsEqualityComparer.Instance;
            const int Value = 5;

            Assert.AreEqual(Value.GetHashCode(), comparer.GetHashCode(Value));
        }

        [Test]
        public void GetHashCodeWithNull()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.AreEqual(0, comparer.GetHashCode(null));
        }

        [Test]
        public void IsEqual()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;
            Test a = new Test();

            Assert.IsTrue(comparer.Equals(a, a));
        }

        [Test]
        public void IsEqualForStruct()
        {
            IEqualityComparer<object> comparer = ReferenceEqualsEqualityComparer.Instance;
            const int Value = 5;

            Assert.IsFalse(comparer.Equals(Value, Value));
        }

        [Test]
        public void IsNotEqual()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new Test(), new Test()));
        }

        [Test]
        public void IsNotEqualForStruct()
        {
            IEqualityComparer<object> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, 5));
        }

        [Test]
        public void SecondNull()
        {
            IEqualityComparer<Test> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new Test(), null));
        }

        [Test]
        public void SecondNullForStruct()
        {
            IEqualityComparer<object> comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, null));
        }

        [Test]
        public void UntypedBothNull()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(null, null));
        }

        [Test]
        public void UntypedFirstNull()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, new Test()));
        }

        [Test]
        public void UntypedFirstNullForStruct()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, 5));
        }

        [Test]
        public void UntypedGetHashCodeTest()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;
            Test a = new Test();

            Assert.AreEqual(a.GetHashCode(), comparer.GetHashCode(a));
        }

        [Test]
        public void UntypedGetHashCodeTestForStruct()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;
            const int Value = 5;

            Assert.AreEqual(Value.GetHashCode(), comparer.GetHashCode(Value));
        }

        [Test]
        public void UntypedIsEqual()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;
            Test a = new Test();

            Assert.IsTrue(comparer.Equals(a, a));
        }

        [Test]
        public void UntypedIsNotEqual()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new Test(), new Test()));
        }

        [Test]
        public void UntypedIsNotEqualForStruct()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, 5));
        }

        [Test]
        public void UntypedSecondNull()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new Test(), null));
        }

        [Test]
        public void UntypedSecondNullForStruct()
        {
            IEqualityComparer comparer = ReferenceEqualsEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, null));
        }

        #endregion

        private class Test
        {
        }
    }
}