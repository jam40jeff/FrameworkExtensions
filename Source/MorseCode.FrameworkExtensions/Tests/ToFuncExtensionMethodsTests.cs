#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToFuncExtensionMethodsTests.cs" company="MorseCode Software">
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

    using MorseCode.FrameworkExtensions;

    using NUnit.Framework;

    [TestFixture]
    public class ToFuncExtensionMethodsTests
    {
        #region Public Methods and Operators

        [Test]
        public void ActionWith0Parameters()
        {
            int id = -1;
            Action action = () => id = 0;
			Func<Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func();

            Assert.AreEqual(0, id);
        }

        [Test]
        public void ActionWith1Parameters()
        {
            const int Value1 = 1;
            int id = -1;
            int value1 = default(int);
            Action<int> action = a => { id = 1; value1 = a; };
			Func<int, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1);

            Assert.AreEqual(1, id);
            Assert.AreEqual(Value1, value1);
        }

        [Test]
        public void ActionWith2Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            Action<int, string> action = (a, b) => { id = 2; value1 = a; value2 = b; };
			Func<int, string, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2);

            Assert.AreEqual(2, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
        }

        [Test]
        public void ActionWith3Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            Action<int, string, double> action = (a, b, c) => { id = 3; value1 = a; value2 = b; value3 = c; };
			Func<int, string, double, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3);

            Assert.AreEqual(3, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
        }

        [Test]
        public void ActionWith4Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            Action<int, string, double, long> action = (a, b, c, d) => { id = 4; value1 = a; value2 = b; value3 = c; value4 = d; };
			Func<int, string, double, long, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4);

            Assert.AreEqual(4, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
        }

        [Test]
        public void ActionWith5Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            Action<int, string, double, long, int> action = (a, b, c, d, e) => { id = 5; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; };
			Func<int, string, double, long, int, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5);

            Assert.AreEqual(5, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
        }

        [Test]
        public void ActionWith6Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            Action<int, string, double, long, int, string> action = (a, b, c, d, e, f) => { id = 6; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; };
			Func<int, string, double, long, int, string, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6);

            Assert.AreEqual(6, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
        }

        [Test]
        public void ActionWith7Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            Action<int, string, double, long, int, string, double> action = (a, b, c, d, e, f, g) => { id = 7; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; };
			Func<int, string, double, long, int, string, double, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7);

            Assert.AreEqual(7, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
        }

        [Test]
        public void ActionWith8Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            Action<int, string, double, long, int, string, double, long> action = (a, b, c, d, e, f, g, h) => { id = 8; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; };
			Func<int, string, double, long, int, string, double, long, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8);

            Assert.AreEqual(8, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
        }

        [Test]
        public void ActionWith9Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            Action<int, string, double, long, int, string, double, long, int> action = (a, b, c, d, e, f, g, h, i) => { id = 9; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; };
			Func<int, string, double, long, int, string, double, long, int, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9);

            Assert.AreEqual(9, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
        }

        [Test]
        public void ActionWith10Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            Action<int, string, double, long, int, string, double, long, int, string> action = (a, b, c, d, e, f, g, h, i, j) => { id = 10; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; };
			Func<int, string, double, long, int, string, double, long, int, string, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10);

            Assert.AreEqual(10, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
        }

        [Test]
        public void ActionWith11Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            const double Value11 = 11;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            double value11 = default(double);
            Action<int, string, double, long, int, string, double, long, int, string, double> action = (a, b, c, d, e, f, g, h, i, j, k) => { id = 11; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; };
			Func<int, string, double, long, int, string, double, long, int, string, double, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11);

            Assert.AreEqual(11, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
            Assert.AreEqual(Value11, value11);
        }

        [Test]
        public void ActionWith12Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            const double Value11 = 11;
            const long Value12 = 12;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            double value11 = default(double);
            long value12 = default(long);
            Action<int, string, double, long, int, string, double, long, int, string, double, long> action = (a, b, c, d, e, f, g, h, i, j, k, l) => { id = 12; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; };
			Func<int, string, double, long, int, string, double, long, int, string, double, long, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12);

            Assert.AreEqual(12, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
            Assert.AreEqual(Value11, value11);
            Assert.AreEqual(Value12, value12);
        }

        [Test]
        public void ActionWith13Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            const double Value11 = 11;
            const long Value12 = 12;
            const int Value13 = 13;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            double value11 = default(double);
            long value12 = default(long);
            int value13 = default(int);
            Action<int, string, double, long, int, string, double, long, int, string, double, long, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m) => { id = 13; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; };
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13);

            Assert.AreEqual(13, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
            Assert.AreEqual(Value11, value11);
            Assert.AreEqual(Value12, value12);
            Assert.AreEqual(Value13, value13);
        }

        [Test]
        public void ActionWith14Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            const double Value11 = 11;
            const long Value12 = 12;
            const int Value13 = 13;
            const string Value14 = "14";
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            double value11 = default(double);
            long value12 = default(long);
            int value13 = default(int);
            string value14 = default(string);
            Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => { id = 14; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; };
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14);

            Assert.AreEqual(14, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
            Assert.AreEqual(Value11, value11);
            Assert.AreEqual(Value12, value12);
            Assert.AreEqual(Value13, value13);
            Assert.AreEqual(Value14, value14);
        }

        [Test]
        public void ActionWith15Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            const double Value11 = 11;
            const long Value12 = 12;
            const int Value13 = 13;
            const string Value14 = "14";
            const double Value15 = 15;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            double value11 = default(double);
            long value12 = default(long);
            int value13 = default(int);
            string value14 = default(string);
            double value15 = default(double);
            Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => { id = 15; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; value15 = o; };
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15);

            Assert.AreEqual(15, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
            Assert.AreEqual(Value11, value11);
            Assert.AreEqual(Value12, value12);
            Assert.AreEqual(Value13, value13);
            Assert.AreEqual(Value14, value14);
            Assert.AreEqual(Value15, value15);
        }

        [Test]
        public void ActionWith16Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            const int Value9 = 9;
            const string Value10 = "10";
            const double Value11 = 11;
            const long Value12 = 12;
            const int Value13 = 13;
            const string Value14 = "14";
            const double Value15 = 15;
            const long Value16 = 16;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            string value10 = default(string);
            double value11 = default(double);
            long value12 = default(long);
            int value13 = default(int);
            string value14 = default(string);
            double value15 = default(double);
            long value16 = default(long);
            Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => { id = 16; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; value15 = o; value16 = p; };
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long, Unit> func = action.ToFunc();

			Assert.IsNotNull(func);

			func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15, Value16);

            Assert.AreEqual(16, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
            Assert.AreEqual(Value7, value7);
            Assert.AreEqual(Value8, value8);
            Assert.AreEqual(Value9, value9);
            Assert.AreEqual(Value10, value10);
            Assert.AreEqual(Value11, value11);
            Assert.AreEqual(Value12, value12);
            Assert.AreEqual(Value13, value13);
            Assert.AreEqual(Value14, value14);
            Assert.AreEqual(Value15, value15);
            Assert.AreEqual(Value16, value16);
        }

        [Test]
        public void NullActionWith0Parameters()
        {
			Func<Unit> func = ((Action)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith1Parameters()
        {
			Func<int, Unit> func = ((Action<int>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith2Parameters()
        {
			Func<int, string, Unit> func = ((Action<int, string>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith3Parameters()
        {
			Func<int, string, double, Unit> func = ((Action<int, string, double>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith4Parameters()
        {
			Func<int, string, double, long, Unit> func = ((Action<int, string, double, long>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith5Parameters()
        {
			Func<int, string, double, long, int, Unit> func = ((Action<int, string, double, long, int>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith6Parameters()
        {
			Func<int, string, double, long, int, string, Unit> func = ((Action<int, string, double, long, int, string>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith7Parameters()
        {
			Func<int, string, double, long, int, string, double, Unit> func = ((Action<int, string, double, long, int, string, double>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith8Parameters()
        {
			Func<int, string, double, long, int, string, double, long, Unit> func = ((Action<int, string, double, long, int, string, double, long>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith9Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, Unit> func = ((Action<int, string, double, long, int, string, double, long, int>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith10Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith11Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, double, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string, double>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith12Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, double, long, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string, double, long>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith13Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string, double, long, int>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith14Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith15Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double>)null).ToFunc();

			Assert.IsNull(func);
        }

        [Test]
        public void NullActionWith16Parameters()
        {
			Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long, Unit> func = ((Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long>)null).ToFunc();

			Assert.IsNull(func);
        }

        #endregion
    }
}
