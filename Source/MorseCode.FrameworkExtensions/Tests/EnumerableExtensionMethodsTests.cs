#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerableExtensionMethodsTests.cs" company="MorseCode Software">
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
    using System.Collections.Generic;
    using System.Linq;

    using NUnit.Framework;

    [TestFixture]
    public class EnumerableExtensionMethodsTests
    {
        #region Public Methods and Operators

        [Test]
        public void EmptyIfNullOnEmpty()
        {
            IEnumerable<int> original = new int[0];
            IEnumerable<int> result = original.EmptyIfNull();

            Assert.IsNotNull(result);
            Assert.AreSame(original, result);
        }

        [Test]
        public void EmptyIfNullOnNonEmpty()
        {
            IEnumerable<int> original = new[] { 1, 2, 3 };
            IEnumerable<int> result = original.EmptyIfNull();

            Assert.IsNotNull(result);
            Assert.AreSame(original, result);
        }

        [Test]
        public void EmptyIfNullOnNull()
        {
            IEnumerable<int> original = null;
            // ReSharper disable ExpressionIsAlwaysNull
            IEnumerable<int> result = original.EmptyIfNull();

            // ReSharper restore ExpressionIsAlwaysNull
            Assert.IsNotNull(result);
            // ReSharper disable ExpressionIsAlwaysNull
            Assert.AreNotSame(original, result);
            // ReSharper restore ExpressionIsAlwaysNull
            Assert.IsFalse(result.Any());
        }

        [Test]
        public void EnumerableFlattenRecursively()
        {
            IEnumerable<Hierarchy> h = new[]
                                           {
                                               new Hierarchy(1, null),
                                               new Hierarchy(
                                                   2,
                                                   new[]
                                                       {
                                                           new Hierarchy(
                                                               3,
                                                               new[]
                                                                   {
                                                                       new Hierarchy(4, null),
                                                                       new Hierarchy(
                                                                           5,
                                                                           new[]
                                                                               {
                                                                                   new Hierarchy(6, null),
                                                                                   new Hierarchy(7, null),
                                                                                   new Hierarchy(8, null)
                                                                               }),
                                                                       new Hierarchy(9, null)
                                                                   }),
                                                           new Hierarchy(10, null),
                                                           new Hierarchy(11, null),
                                                           new Hierarchy(
                                                               12,
                                                               new[]
                                                                   {
                                                                       new Hierarchy(13, null)
                                                                   })
                                                       }),
                                               new Hierarchy(
                                                   14,
                                                   new[]
                                                       {
                                                           new Hierarchy(15, null),
                                                           new Hierarchy(16, null),
                                                           new Hierarchy(17, null)
                                                       })
                                           };
            IReadOnlyList<Hierarchy> result = h.FlattenRecursively(o => o.Children).ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(17, result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                try
                {
                    Assert.AreEqual(i + 1, result[i].Id);
                }
                catch (AssertionException e)
                {
                    throw new AssertionException("Assertion failed for i = " + i + ".", e);
                }
            }
        }

        [Test]
        public void FlattenRecursively()
        {
            Hierarchy h = new Hierarchy(
                1,
                new[]
                    {
                        new Hierarchy(
                            2,
                            new[]
                                {
                                    new Hierarchy(3, null),
                                    new Hierarchy(
                                        4,
                                        new[]
                                            {
                                                new Hierarchy(5, null),
                                                new Hierarchy(6, null),
                                                new Hierarchy(7, null)
                                            }),
                                    new Hierarchy(8, null)
                                }),
                        new Hierarchy(9, null),
                        new Hierarchy(10, null),
                        new Hierarchy(
                            11,
                            new[]
                                {
                                    new Hierarchy(12, null)
                                })
                    });
            IReadOnlyList<Hierarchy> result = h.FlattenRecursively(o => o.Children).ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(12, result.Count);
            for (int i = 0; i < result.Count; i++)
            {
                try
                {
                    Assert.AreEqual(i + 1, result[i].Id);
                }
                catch (AssertionException e)
                {
                    throw new AssertionException("Assertion failed for i = " + i + ".", e);
                }
            }
        }

        [Test]
        public void ForEach()
        {
            List<string> result = new List<string>();
            IEnumerable<string> source = new[] { "a", "b", "c" };
            source.ForEach(result.Add);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("a", result[0]);
            Assert.AreEqual("b", result[1]);
            Assert.AreEqual("c", result[2]);
        }

        [Test]
        public void ForEachOnEmpty()
        {
            List<string> result = new List<string>();
            IEnumerable<string> source = new string[0];
            source.ForEach(result.Add);

            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void ForEachOnNull()
        {
            List<string> result = new List<string>();
            IEnumerable<string> source = null;
            // ReSharper disable ExpressionIsAlwaysNull
            source.ForEach(result.Add);

            // ReSharper restore ExpressionIsAlwaysNull
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void ForEachWithIndex()
        {
            List<Tuple<int, string>> result = new List<Tuple<int, string>>();
            IEnumerable<string> source = new[] { "a", "b", "c" };
            source.ForEach((s, i) => result.Add(Tuple.Create(i, s)));

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(0, result[0].Item1);
            Assert.AreEqual("a", result[0].Item2);
            Assert.AreEqual(1, result[1].Item1);
            Assert.AreEqual("b", result[1].Item2);
            Assert.AreEqual(2, result[2].Item1);
            Assert.AreEqual("c", result[2].Item2);
        }

        [Test]
        public void ForEachWithIndexOnEmpty()
        {
            List<Tuple<int, string>> result = new List<Tuple<int, string>>();
            IEnumerable<string> source = new string[0];
            source.ForEach((s, i) => result.Add(Tuple.Create(i, s)));

            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void ForEachWithIndexOnNull()
        {
            List<Tuple<int, string>> result = new List<Tuple<int, string>>();
            IEnumerable<string> source = null;
            // ReSharper disable ExpressionIsAlwaysNull
            source.ForEach((s, i) => result.Add(Tuple.Create(i, s)));

            // ReSharper restore ExpressionIsAlwaysNull
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void ToEnumerable()
        {
            const string Item = "s";
            IReadOnlyList<string> result = Item.ToEnumerable().ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Item, result[0]);
        }

        [Test]
        public void ToEnumerableOnNull()
        {
            IReadOnlyList<string> result = ((string)null).ToEnumerable().ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void ToEnumerableForStruct()
        {
            const int Item = 5;
            IReadOnlyList<int> result = Item.ToEnumerableForStruct().ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Item, result[0]);
        }

        [Test]
        public void ToEnumerableForStructExcludeMatch()
        {
            const int Item = 0;
            IReadOnlyList<int> result = Item.ToEnumerableForStruct(n => n == 0).ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void ToEnumerableForStructExcludeNoMatch()
        {
            const int Item = 5;
            IReadOnlyList<int> result = Item.ToEnumerableForStruct(n => n == 0).ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Item, result[0]);
        }

        [Test]
        public void ToSingleEnumerable()
        {
            const string Item = "s";
            IReadOnlyList<string> result = Item.ToSingleEnumerable().ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Item, result[0]);
        }

        [Test]
        public void ToSingleEnumerableOnStruct()
        {
            const int Item = 5;
            IReadOnlyList<int> result = Item.ToSingleEnumerable().ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(Item, result[0]);
        }

        [Test]
        public void ToSingleEnumerableOnNull()
        {
            IReadOnlyList<string> result = ((string)null).ToSingleEnumerable().ToArray();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsNull(result[0]);
        }

        #endregion

        private class Hierarchy
        {
            #region Fields

            private readonly IReadOnlyList<Hierarchy> children;

            private readonly int id;

            #endregion

            #region Constructors and Destructors

            public Hierarchy(int id, IEnumerable<Hierarchy> children)
            {
                this.id = id;
                this.children = (children ?? new Hierarchy[0]).ToArray();
            }

            #endregion

            #region Public Properties

            public IEnumerable<Hierarchy> Children
            {
                get
                {
                    return this.children;
                }
            }

            public int Id
            {
                get
                {
                    return this.id;
                }
            }

            #endregion
        }
    }
}