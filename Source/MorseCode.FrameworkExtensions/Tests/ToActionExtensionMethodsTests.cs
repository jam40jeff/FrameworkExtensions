#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToActionExtensionMethodsTests.cs" company="MorseCode Software">
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
    public class ToActionExtensionMethodsTests
    {
        #region Public Methods and Operators

        [Test]
        public void FuncWith0Parameters()
        {
            int id = -1;
            Func<Unit> func = () => { id = 0; return Unit.Value; };
			Action action = func.ToAction();

			Assert.IsNotNull(action);

			action();

            Assert.AreEqual(0, id);
        }

        [Test]
        public void FuncWith1Parameters()
        {
            const int Value1 = 1;
            int id = -1;
            int value1 = default(int);
            Func<int, Unit> func = a => { id = 1; value1 = a; return Unit.Value; };
			Action<int> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1);

            Assert.AreEqual(1, id);
            Assert.AreEqual(Value1, value1);
        }

        [Test]
        public void FuncWith2Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            Func<int, string, Unit> func = (a, b) => { id = 2; value1 = a; value2 = b; return Unit.Value; };
			Action<int, string> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2);

            Assert.AreEqual(2, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
        }

        [Test]
        public void FuncWith3Parameters()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            int id = -1;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            Func<int, string, double, Unit> func = (a, b, c) => { id = 3; value1 = a; value2 = b; value3 = c; return Unit.Value; };
			Action<int, string, double> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3);

            Assert.AreEqual(3, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
        }

        [Test]
        public void FuncWith4Parameters()
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
            Func<int, string, double, long, Unit> func = (a, b, c, d) => { id = 4; value1 = a; value2 = b; value3 = c; value4 = d; return Unit.Value; };
			Action<int, string, double, long> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4);

            Assert.AreEqual(4, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
        }

        [Test]
        public void FuncWith5Parameters()
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
            Func<int, string, double, long, int, Unit> func = (a, b, c, d, e) => { id = 5; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; return Unit.Value; };
			Action<int, string, double, long, int> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5);

            Assert.AreEqual(5, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
        }

        [Test]
        public void FuncWith6Parameters()
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
            Func<int, string, double, long, int, string, Unit> func = (a, b, c, d, e, f) => { id = 6; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; return Unit.Value; };
			Action<int, string, double, long, int, string> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6);

            Assert.AreEqual(6, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
            Assert.AreEqual(Value6, value6);
        }

        [Test]
        public void FuncWith7Parameters()
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
            Func<int, string, double, long, int, string, double, Unit> func = (a, b, c, d, e, f, g) => { id = 7; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; return Unit.Value; };
			Action<int, string, double, long, int, string, double> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7);

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
        public void FuncWith8Parameters()
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
            Func<int, string, double, long, int, string, double, long, Unit> func = (a, b, c, d, e, f, g, h) => { id = 8; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8);

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
        public void FuncWith9Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, Unit> func = (a, b, c, d, e, f, g, h, i) => { id = 9; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9);

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
        public void FuncWith10Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, Unit> func = (a, b, c, d, e, f, g, h, i, j) => { id = 10; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10);

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
        public void FuncWith11Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, double, Unit> func = (a, b, c, d, e, f, g, h, i, j, k) => { id = 11; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string, double> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11);

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
        public void FuncWith12Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, double, long, Unit> func = (a, b, c, d, e, f, g, h, i, j, k, l) => { id = 12; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string, double, long> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12);

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
        public void FuncWith13Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, double, long, int, Unit> func = (a, b, c, d, e, f, g, h, i, j, k, l, m) => { id = 13; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13);

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
        public void FuncWith14Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, Unit> func = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => { id = 14; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14);

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
        public void FuncWith15Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, Unit> func = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => { id = 15; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; value15 = o; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15);

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
        public void FuncWith16Parameters()
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
            Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long, Unit> func = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => { id = 16; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; value15 = o; value16 = p; return Unit.Value; };
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long> action = func.ToAction();

			Assert.IsNotNull(action);

			action(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15, Value16);

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
        public void NullFuncWith0Parameters()
        {
			Action action = ((Func<Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith1Parameters()
        {
			Action<int> action = ((Func<int, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith2Parameters()
        {
			Action<int, string> action = ((Func<int, string, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith3Parameters()
        {
			Action<int, string, double> action = ((Func<int, string, double, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith4Parameters()
        {
			Action<int, string, double, long> action = ((Func<int, string, double, long, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith5Parameters()
        {
			Action<int, string, double, long, int> action = ((Func<int, string, double, long, int, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith6Parameters()
        {
			Action<int, string, double, long, int, string> action = ((Func<int, string, double, long, int, string, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith7Parameters()
        {
			Action<int, string, double, long, int, string, double> action = ((Func<int, string, double, long, int, string, double, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith8Parameters()
        {
			Action<int, string, double, long, int, string, double, long> action = ((Func<int, string, double, long, int, string, double, long, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith9Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int> action = ((Func<int, string, double, long, int, string, double, long, int, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith10Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string> action = ((Func<int, string, double, long, int, string, double, long, int, string, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith11Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string, double> action = ((Func<int, string, double, long, int, string, double, long, int, string, double, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith12Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string, double, long> action = ((Func<int, string, double, long, int, string, double, long, int, string, double, long, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith13Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int> action = ((Func<int, string, double, long, int, string, double, long, int, string, double, long, int, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith14Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string> action = ((Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith15Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double> action = ((Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        [Test]
        public void NullFuncWith16Parameters()
        {
			Action<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long> action = ((Func<int, string, double, long, int, string, double, long, int, string, double, long, int, string, double, long, Unit>)null).ToAction();

			Assert.IsNull(action);
        }

        #endregion
    }
}
