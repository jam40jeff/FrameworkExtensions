﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SymmetricEqualityComparerTests.cs" company="MorseCode Software">
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
    using System.Collections;
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class SymmetricEqualityComparerTests
    {
        [Test]
        public void IsEqual()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(new A(), new A()));
        }

        [Test]
        public void IsNotEqual()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new A(), new B()));
        }

        [Test]
        public void FirstNull()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, new A()));
        }

        [Test]
        public void SecondNull()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new A(), null));
        }

        [Test]
        public void BothNull()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(null, null));
        }

        [Test]
        public void GetHashCodeTest()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;
            A a = new A();

            Assert.AreEqual(a.GetHashCode(), comparer.GetHashCode(a));
        }

        [Test]
        public void GetHashCodeWithNull()
        {
            IEqualityComparer<Base> comparer = SymmetricEqualityComparer.Instance;

            Assert.AreEqual(0, comparer.GetHashCode(null));
        }

        [Test]
        public void IsEqualForStruct()
        {
            IEqualityComparer<object> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(5, 5));
        }

        [Test]
        public void IsNotEqualForStruct()
        {
            IEqualityComparer<object> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, 7));
        }

        [Test]
        public void FirstNullForStruct()
        {
            IEqualityComparer<object> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, 5));
        }

        [Test]
        public void SecondNullForStruct()
        {
            IEqualityComparer<object> comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, null));
        }

        [Test]
        public void GetHashCodeTestForStruct()
        {
            IEqualityComparer<object> comparer = SymmetricEqualityComparer.Instance;
            const int Value = 5;

            Assert.AreEqual(Value.GetHashCode(), comparer.GetHashCode(Value));
        }

        [Test]
        public void UntypedIsEqual()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(new A(), new A()));
        }

        [Test]
        public void UntypedIsNotEqual()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new A(), new B()));
        }

        [Test]
        public void UntypedFirstNull()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, new A()));
        }

        [Test]
        public void UntypedSecondNull()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(new A(), null));
        }

        [Test]
        public void UntypedBothNull()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(null, null));
        }

        [Test]
        public void UntypedGetHashCodeTest()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;
            A a = new A();

            Assert.AreEqual(a.GetHashCode(), comparer.GetHashCode(a));
        }

        [Test]
        public void UntypedIsEqualForStruct()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsTrue(comparer.Equals(5, 5));
        }

        [Test]
        public void UntypedIsNotEqualForStruct()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, 7));
        }

        [Test]
        public void UntypedFirstNullForStruct()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(null, 5));
        }

        [Test]
        public void UntypedSecondNullForStruct()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;

            Assert.IsFalse(comparer.Equals(5, null));
        }

        [Test]
        public void UntypedGetHashCodeTestForStruct()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer.Instance;
            const int Value = 5;

            Assert.AreEqual(Value.GetHashCode(), comparer.GetHashCode(Value));
        }

        [Test]
        public void GenericIsEqual()
        {
            IEqualityComparer<int> comparer = SymmetricEqualityComparer<int>.Instance;

            Assert.IsTrue(comparer.Equals(5, 5));
        }

        [Test]
        public void GenericIsNotEqual()
        {
            IEqualityComparer<int> comparer = SymmetricEqualityComparer<int>.Instance;

            Assert.IsFalse(comparer.Equals(5, 7));
        }

        [Test]
        public void GenericGetHashCodeTest()
        {
            IEqualityComparer<int> comparer = SymmetricEqualityComparer<int>.Instance;
            const int Value = 5;

            Assert.AreEqual(Value.GetHashCode(), comparer.GetHashCode(Value));
        }

        [Test]
        public void GenericUntypedIsEqual()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer<int>.Instance;

            Assert.IsTrue(comparer.Equals(5, 5));
        }

        [Test]
        public void GenericUntypedIsNotEqual()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer<int>.Instance;

            Assert.IsFalse(comparer.Equals(5, 7));
        }

        [Test]
        public void GenericUntypedWrongTypeIsEqual()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer<int>.Instance;

            Assert.IsTrue(comparer.Equals("test", "test"));
        }

        [Test]
        public void GenericUntypedWrongTypeIsNotEqual()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer<int>.Instance;

            Assert.IsFalse(comparer.Equals("test", "test 2"));
        }

        [Test]
        public void GenericUntypedGetHashCodeTest()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer<int>.Instance;
            const int Value = 5;

            Assert.AreEqual(Value.GetHashCode(), comparer.GetHashCode(Value));
        }

        [Test]
        public void GenericUntypedGetHashCodeWrongType()
        {
            IEqualityComparer comparer = SymmetricEqualityComparer<int>.Instance;

            ArgumentException actual = null;

            try
            {
                // ReSharper disable ReturnValueOfPureMethodIsNotUsed
                comparer.GetHashCode(new object());
                // ReSharper restore ReturnValueOfPureMethodIsNotUsed
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("Parameter obj must be convertible to type " + typeof(int) + "." + Environment.NewLine + "Parameter name: obj", actual.Message);
            Assert.AreEqual("obj", actual.ParamName);
        }

        private class A : Base
        {
            #region Public Properties

            // ReSharper disable MemberCanBePrivate.Local
            // ReSharper disable UnusedAutoPropertyAccessor.Local
            public int Value { get; set; }
            // ReSharper restore UnusedAutoPropertyAccessor.Local
            // ReSharper restore MemberCanBePrivate.Local

            #endregion

            #region Public Methods and Operators

            public override bool Equals(object obj)
            {
                A personObj = obj as A;
                if (personObj == null || !base.Equals(obj))
                {
                    return false;
                }

                return Value.Equals(personObj.Value);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (base.GetHashCode() * 397) ^ this.Value;
                }
            }

            #endregion

            #region Methods

            // ReSharper disable UnusedMember.Local
            protected bool Equals(A other)
            // ReSharper restore UnusedMember.Local
            {
                return base.Equals(other) && this.Value == other.Value;
            }

            #endregion
        }

        private class B : Base
        {
        }

        private abstract class Base
        {
            #region Public Properties

            // ReSharper disable MemberCanBePrivate.Local
            // ReSharper disable UnusedAutoPropertyAccessor.Local
            public int BaseValue { get; set; }
            // ReSharper restore UnusedAutoPropertyAccessor.Local
            // ReSharper restore MemberCanBePrivate.Local

            #endregion

            #region Public Methods and Operators

            public override bool Equals(object obj)
            {
                Base personObj = obj as Base;
                if (personObj == null)
                {
                    return false;
                }

                return BaseValue.Equals(personObj.BaseValue);
            }

            public override int GetHashCode()
            {
                return this.BaseValue;
            }

            #endregion
        }
    }
}