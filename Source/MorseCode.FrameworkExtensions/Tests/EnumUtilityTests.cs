#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumUtilityTests.cs" company="MorseCode Software">
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
    using System.Globalization;

    using NUnit.Framework;

    [TestFixture]
    public class EnumUtilityTests
    {
        [Test]
        public void GetValues()
        {
            TestEnum[] values = EnumUtility.GetValues<TestEnum>();

            Assert.IsNotNull(values);
            Assert.AreEqual(5, values.Length);
            Assert.AreEqual(TestEnum.First, values[0]);
            Assert.AreEqual(TestEnum.Second, values[1]);
            Assert.AreEqual(TestEnum.Third, values[2]);
            Assert.AreEqual(TestEnum.Fourth, values[3]);
            Assert.AreEqual(TestEnum.Fifth, values[4]);
        }

        [Test]
        public void Parse()
        {
            TestEnum value = EnumUtility.Parse<TestEnum>(TestEnum.Third.ToString());

            Assert.AreEqual(TestEnum.Third, value);
        }

        [Test]
        public void ParseIgnoreCase()
        {
            TestEnum value = EnumUtility.Parse<TestEnum>(TestEnum.Fourth.ToString().ToLowerInvariant(), true);

            Assert.AreEqual(TestEnum.Fourth, value);
        }

        [Test]
        public void ToObjectByte()
        {
            TestEnum value = EnumUtility.ToObject<TestEnum>((byte)TestEnum.Second);

            Assert.AreEqual(TestEnum.Second, value);
        }

        [Test]
        public void ToObjectInt32()
        {
            TestEnum value = EnumUtility.ToObject<TestEnum>((int)TestEnum.Fifth);

            Assert.AreEqual(TestEnum.Fifth, value);
        }

        private enum TestEnum
        {
            First,
            Second,
            Third,
            Fourth,
            Fifth
        }
    }
}