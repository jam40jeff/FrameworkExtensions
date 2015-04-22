#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNullMonadTests.cs" company="MorseCode Software">
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
    public class NotNullMonadTests
    {
        #region Public Methods and Operators

        [Test]
        public void Bind()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNull<int> result = value.Bind(v => NotNull.Create(v + 2));

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Value);
        }

        [Test]
        public void BindMutable()
        {
            INotNullMutable<int> value = NotNull.CreateMutable(5);
            INotNullMutable<int> result = value.Bind(v => NotNull.CreateMutable(v + 2));
            result.Value++;

            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Value);
        }

        [Test]
        public void BindMutableWithBindFunctionReturningNull()
        {
            ArgumentException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.Bind(v => (INotNullMutable<int>)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The bind function may not return null." + Environment.NewLine + "Parameter name: bind", actual.Message);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void BindMutableWithNullBindFunction()
        {
            ArgumentNullException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.Bind((Func<int, INotNullMutable<int>>)null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void BindMutableWithNullInput()
        {
            ArgumentNullException actual = null;

            try
            {
                ((INotNullMutable<int>)null).Bind(v => NotNull.CreateMutable(v + 2));
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void BindNonMutableToMutable()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNullMutable<int> result = value.Bind(v => NotNull.CreateMutable(v + 2));
            result.Value++;

            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Value);
        }

        [Test]
        public void BindWithBindFunctionReturningNull()
        {
            ArgumentException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.Bind(v => (INotNull<int>)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The bind function may not return null." + Environment.NewLine + "Parameter name: bind", actual.Message);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void BindWithNullBindFunction()
        {
            ArgumentNullException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.Bind((Func<int, INotNull<int>>)null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void BindWithNullInput()
        {
            ArgumentNullException actual = null;

            try
            {
                ((INotNull<int>)null).Bind(v => NotNull.Create(v + 2));
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void Select()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNull<int> result = value.Select(v => v + 2);

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Value);
        }

        [Test]
        public void SelectMany()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNull<int> result = value.SelectMany(v => NotNull.Create(v + 2), (x, y) => x * y);

            Assert.IsNotNull(result);
            Assert.AreEqual(35, result.Value);
        }

        [Test]
        public void SelectManyMutable()
        {
            INotNullMutable<int> value = NotNull.CreateMutable(5);
            INotNullMutable<int> result = value.SelectManyMutable(v => NotNull.Create(v + 2), (x, y) => x * y);
            result.Value++;

            Assert.IsNotNull(result);
            Assert.AreEqual(36, result.Value);
        }

        [Test]
        public void SelectManyMutableWithBindFunctionReturningNull()
        {
            ArgumentException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.SelectManyMutable(v => (INotNull<int>)null, (x, y) => x * y);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The bind function may not return null." + Environment.NewLine + "Parameter name: bind", actual.Message);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void SelectManyMutableWithNullBindFunction()
        {
            ArgumentNullException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.SelectManyMutable((Func<int, INotNull<int>>)null, (x, y) => x * y);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void SelectManyMutableWithNullInput()
        {
            ArgumentNullException actual = null;

            try
            {
                ((INotNullMutable<int>)null).SelectManyMutable(v => NotNull.Create(v + 2), (x, y) => x * y);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void SelectManyMutableWithNullSelectFunction()
        {
            ArgumentNullException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.SelectManyMutable(v => NotNull.Create(v + 2), (Func<int, int, int>)null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("select", actual.ParamName);
        }

        [Test]
        public void SelectManyNonMutableToMutable()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNullMutable<int> result = value.SelectManyMutable(v => NotNull.Create(v + 2), (x, y) => x * y);
            result.Value++;

            Assert.IsNotNull(result);
            Assert.AreEqual(36, result.Value);
        }

        [Test]
        public void SelectManyQuerySyntax()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNull<int> result = from x in value from y in NotNull.Create(x + 2) select x * y;

            Assert.IsNotNull(result);
            Assert.AreEqual(35, result.Value);
        }

        [Test]
        public void SelectManyWithBindFunctionReturningNull()
        {
            ArgumentException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.SelectMany(v => (INotNull<int>)null, (x, y) => x * y);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The bind function may not return null." + Environment.NewLine + "Parameter name: bind", actual.Message);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void SelectManyWithNullBindFunction()
        {
            ArgumentNullException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.SelectMany((Func<int, INotNull<int>>)null, (x, y) => x * y);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("bind", actual.ParamName);
        }

        [Test]
        public void SelectManyWithNullInput()
        {
            ArgumentNullException actual = null;

            try
            {
                ((INotNull<int>)null).SelectMany(v => NotNull.Create(v + 2), (x, y) => x * y);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void SelectManyWithNullSelectFunction()
        {
            ArgumentNullException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.SelectMany(v => NotNull.Create(v + 2), (Func<int, int, int>)null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("select", actual.ParamName);
        }

        [Test]
        public void SelectMutable()
        {
            INotNullMutable<int> value = NotNull.CreateMutable(5);
            INotNullMutable<int> result = value.SelectMutable(v => v + 2);
            result.Value++;

            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Value);
        }

        [Test]
        public void SelectMutableWithNullInput()
        {
            ArgumentNullException actual = null;

            try
            {
                ((INotNullMutable<int>)null).Select(v => NotNull.CreateMutable(v + 2));
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void SelectMutableWithNullSelectFunction()
        {
            ArgumentNullException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.Select((Func<int, INotNullMutable<int>>)null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("map", actual.ParamName);
        }

        [Test]
        public void SelectMutableWithSelectFunctionReturningNull()
        {
            ArgumentException actual = null;

            INotNullMutable<int> value = NotNull.CreateMutable(5);
            try
            {
                value.SelectMutable(v => (INotNullMutable<int>)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The mapping function may not return null." + Environment.NewLine + "Parameter name: map", actual.Message);
            Assert.AreEqual("map", actual.ParamName);
        }

        [Test]
        public void SelectNonMutableToMutable()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNullMutable<int> result = value.SelectMutable(v => v + 2);
            result.Value++;

            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Value);
        }

        [Test]
        public void SelectQuerySyntax()
        {
            INotNull<int> value = NotNull.Create(5);
            INotNull<int> result = from v in value select v + 2;

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Value);
        }

        [Test]
        public void SelectWithNullInput()
        {
            ArgumentNullException actual = null;

            try
            {
                ((INotNull<int>)null).Select(v => NotNull.Create(v + 2));
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void SelectWithNullSelectFunction()
        {
            ArgumentNullException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.Select((Func<int, INotNull<int>>)null);
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("map", actual.ParamName);
        }

        [Test]
        public void SelectWithSelectFunctionReturningNull()
        {
            ArgumentException actual = null;

            INotNull<int> value = NotNull.Create(5);
            try
            {
                value.Select(v => (INotNull<int>)null);
            }
            catch (ArgumentException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("The mapping function may not return null." + Environment.NewLine + "Parameter name: map", actual.Message);
            Assert.AreEqual("map", actual.ParamName);
        }

        [Test]
        public void ToNotNull()
        {
            INotNull<int> result = (5).ToNotNull();

            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Value);
        }

        [Test]
        public void ToNotNullMutable()
        {
            INotNullMutable<int> result = (5).ToNotNullMutable();
            result.Value += 2;

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Value);
        }

        [Test]
        public void ToNotNullMutableWithNull()
        {
            ArgumentNullException actual = null;

            try
            {
                ((string)null).ToNotNullMutable();
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        [Test]
        public void ToNotNullWithNull()
        {
            ArgumentNullException actual = null;

            try
            {
                ((string)null).ToNotNull();
            }
            catch (ArgumentNullException e)
            {
                actual = e;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual("o", actual.ParamName);
        }

        #endregion
    }
}