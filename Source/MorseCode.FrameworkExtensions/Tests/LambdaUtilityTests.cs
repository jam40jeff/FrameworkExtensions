#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LambdaUtilityTests.cs" company="MorseCode Software">
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
    using MorseCode.FrameworkExtensions;

    using NUnit.Framework;

    [TestFixture]
    public class LambdaUtilityTests
    {
        #region Public Methods and Operators

        [Test]
        public void TestActionWith0ParametersWithAnonymousType()
        {
            const int Id = 0;
            var action = LambdaUtility.TypeLambda(() => { });
            action();

            Assert.AreEqual(0, Id);
        }

        [Test]
        public void TestActionWith1ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            int id = 0;
            int value1 = default(int);
            var action = LambdaUtility.TypeLambda((int a) => { id = 1; value1 = a; });
            action(Value1);

            Assert.AreEqual(1, id);
            Assert.AreEqual(Value1, value1);
        }

        [Test]
        public void TestActionWith2ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            var action = LambdaUtility.TypeLambda((int a, string b) => { id = 2; value1 = a; value2 = b; });
            action(Value1, Value2);

            Assert.AreEqual(2, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
        }

        [Test]
        public void TestActionWith3ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            var action = LambdaUtility.TypeLambda((int a, string b, double c) => { id = 3; value1 = a; value2 = b; value3 = c; });
            action(Value1, Value2, Value3);

            Assert.AreEqual(3, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
        }

        [Test]
        public void TestActionWith4ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d) => { id = 4; value1 = a; value2 = b; value3 = c; value4 = d; });
            action(Value1, Value2, Value3, Value4);

            Assert.AreEqual(4, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
        }

        [Test]
        public void TestActionWith5ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e) => { id = 5; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; });
            action(Value1, Value2, Value3, Value4, Value5);

            Assert.AreEqual(5, id);
            Assert.AreEqual(Value1, value1);
            Assert.AreEqual(Value2, value2);
            Assert.AreEqual(Value3, value3);
            Assert.AreEqual(Value4, value4);
            Assert.AreEqual(Value5, value5);
        }

        [Test]
        public void TestActionWith6ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f) => { id = 6; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; });
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
        public void TestActionWith7ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g) => { id = 7; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; });
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
        public void TestActionWith8ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h) => { id = 8; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; });
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
        public void TestActionWith9ParametersWithAnonymousType()
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
            int id = 0;
            int value1 = default(int);
            string value2 = default(string);
            double value3 = default(double);
            long value4 = default(long);
            int value5 = default(int);
            string value6 = default(string);
            double value7 = default(double);
            long value8 = default(long);
            int value9 = default(int);
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i) => { id = 9; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; });
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
        public void TestActionWith10ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j) => { id = 10; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; });
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
        public void TestActionWith11ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k) => { id = 11; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; });
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
        public void TestActionWith12ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l) => { id = 12; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; });
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
        public void TestActionWith13ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m) => { id = 13; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; });
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
        public void TestActionWith14ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m, string n) => { id = 14; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; });
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
        public void TestActionWith15ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m, string n, double o) => { id = 15; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; value15 = o; });
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
        public void TestActionWith16ParametersWithAnonymousType()
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
            int id = 0;
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
            var action = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m, string n, double o, long p) => { id = 16; value1 = a; value2 = b; value3 = c; value4 = d; value5 = e; value6 = f; value7 = g; value8 = h; value9 = i; value10 = j; value11 = k; value12 = l; value13 = m; value14 = n; value15 = o; value16 = p; });
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
        public void TestFuncWith0ParametersWithAnonymousType()
        {
            var func = LambdaUtility.TypeLambda(() => new { Id = 0 });
            var result = func();

            Assert.AreEqual(0, result.Id);
        }

        [Test]
        public void TestFuncWith1ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            var func = LambdaUtility.TypeLambda((int a) => new { Id = 1, A = a });
            var result = func(Value1);

            Assert.AreEqual(1, result.Id);
            Assert.AreEqual(Value1, result.A);
        }

        [Test]
        public void TestFuncWith2ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            var func = LambdaUtility.TypeLambda((int a, string b) => new { Id = 2, A = a, B = b });
            var result = func(Value1, Value2);

            Assert.AreEqual(2, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
        }

        [Test]
        public void TestFuncWith3ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            var func = LambdaUtility.TypeLambda((int a, string b, double c) => new { Id = 3, A = a, B = b, C = c });
            var result = func(Value1, Value2, Value3);

            Assert.AreEqual(3, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
        }

        [Test]
        public void TestFuncWith4ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d) => new { Id = 4, A = a, B = b, C = c, D = d });
            var result = func(Value1, Value2, Value3, Value4);

            Assert.AreEqual(4, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
        }

        [Test]
        public void TestFuncWith5ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e) => new { Id = 5, A = a, B = b, C = c, D = d, E = e });
            var result = func(Value1, Value2, Value3, Value4, Value5);

            Assert.AreEqual(5, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
        }

        [Test]
        public void TestFuncWith6ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f) => new { Id = 6, A = a, B = b, C = c, D = d, E = e, F = f });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6);

            Assert.AreEqual(6, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
        }

        [Test]
        public void TestFuncWith7ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g) => new { Id = 7, A = a, B = b, C = c, D = d, E = e, F = f, G = g });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7);

            Assert.AreEqual(7, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
        }

        [Test]
        public void TestFuncWith8ParametersWithAnonymousType()
        {
            const int Value1 = 1;
            const string Value2 = "2";
            const double Value3 = 3;
            const long Value4 = 4;
            const int Value5 = 5;
            const string Value6 = "6";
            const double Value7 = 7;
            const long Value8 = 8;
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h) => new { Id = 8, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8);

            Assert.AreEqual(8, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
        }

        [Test]
        public void TestFuncWith9ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i) => new { Id = 9, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9);

            Assert.AreEqual(9, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
        }

        [Test]
        public void TestFuncWith10ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j) => new { Id = 10, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10);

            Assert.AreEqual(10, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
        }

        [Test]
        public void TestFuncWith11ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k) => new { Id = 11, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j, K = k });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11);

            Assert.AreEqual(11, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
            Assert.AreEqual(Value11, result.K);
        }

        [Test]
        public void TestFuncWith12ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l) => new { Id = 12, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j, K = k, L = l });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12);

            Assert.AreEqual(12, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
            Assert.AreEqual(Value11, result.K);
            Assert.AreEqual(Value12, result.L);
        }

        [Test]
        public void TestFuncWith13ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m) => new { Id = 13, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j, K = k, L = l, M = m });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13);

            Assert.AreEqual(13, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
            Assert.AreEqual(Value11, result.K);
            Assert.AreEqual(Value12, result.L);
            Assert.AreEqual(Value13, result.M);
        }

        [Test]
        public void TestFuncWith14ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m, string n) => new { Id = 14, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j, K = k, L = l, M = m, N = n });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14);

            Assert.AreEqual(14, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
            Assert.AreEqual(Value11, result.K);
            Assert.AreEqual(Value12, result.L);
            Assert.AreEqual(Value13, result.M);
            Assert.AreEqual(Value14, result.N);
        }

        [Test]
        public void TestFuncWith15ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m, string n, double o) => new { Id = 15, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j, K = k, L = l, M = m, N = n, O = o });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15);

            Assert.AreEqual(15, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
            Assert.AreEqual(Value11, result.K);
            Assert.AreEqual(Value12, result.L);
            Assert.AreEqual(Value13, result.M);
            Assert.AreEqual(Value14, result.N);
            Assert.AreEqual(Value15, result.O);
        }

        [Test]
        public void TestFuncWith16ParametersWithAnonymousType()
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
            var func = LambdaUtility.TypeLambda((int a, string b, double c, long d, int e, string f, double g, long h, int i, string j, double k, long l, int m, string n, double o, long p) => new { Id = 16, A = a, B = b, C = c, D = d, E = e, F = f, G = g, H = h, I = i, J = j, K = k, L = l, M = m, N = n, O = o, P = p });
            var result = func(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15, Value16);

            Assert.AreEqual(16, result.Id);
            Assert.AreEqual(Value1, result.A);
            Assert.AreEqual(Value2, result.B);
            Assert.AreEqual(Value3, result.C);
            Assert.AreEqual(Value4, result.D);
            Assert.AreEqual(Value5, result.E);
            Assert.AreEqual(Value6, result.F);
            Assert.AreEqual(Value7, result.G);
            Assert.AreEqual(Value8, result.H);
            Assert.AreEqual(Value9, result.I);
            Assert.AreEqual(Value10, result.J);
            Assert.AreEqual(Value11, result.K);
            Assert.AreEqual(Value12, result.L);
            Assert.AreEqual(Value13, result.M);
            Assert.AreEqual(Value14, result.N);
            Assert.AreEqual(Value15, result.O);
            Assert.AreEqual(Value16, result.P);
        }

        #endregion
    }
}
