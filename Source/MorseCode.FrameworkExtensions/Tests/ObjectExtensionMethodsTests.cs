#region License

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
        public void ImplictlyConvert()
        {
            const string Value = "test";
            object o = Value.ImplicitlyConvert<object>();

            Assert.AreSame(Value, o);
        }

        [Test]
        public void ImplictlyConvertWithSameType()
        {
            const string Value = "test";
            string o = Value.ImplicitlyConvert();

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

        [Test]
        public void SymmetricEqualsFalse()
        {
            A a = new A();
            a.BaseValue = 5;
            a.Value = 7;

            B b = new B();
            b.BaseValue = 5;

            Assert.IsFalse(a.SymmetricEquals(b));
        }

        [Test]
        public void SymmetricEqualsTrue()
        {
            A a1 = new A();
            a1.BaseValue = 5;
            a1.Value = 7;

            A a2 = new A();
            a2.BaseValue = 5;
            a2.Value = 7;

            Assert.IsTrue(a1.SymmetricEquals(a2));
        }

        [Test]
        public void SymmetricFirstNull()
        {
            A a = new A();

            Assert.IsFalse(((object)null).SymmetricEquals(a));
        }

        [Test]
        public void SymmetricSecondNull()
        {
            A a = new A();

            Assert.IsFalse(a.SymmetricEquals(null));
        }

        [Test]
        public void SymmetricBothNull()
        {
            Assert.IsTrue(((object)null).SymmetricEquals(null));
        }

        #endregion

        private class A : Base
        {
            #region Public Properties

            public int Value { get; set; }

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

            protected bool Equals(A other)
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

            public int BaseValue { get; set; }

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