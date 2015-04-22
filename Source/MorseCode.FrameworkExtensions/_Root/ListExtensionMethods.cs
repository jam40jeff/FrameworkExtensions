#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListExtensionMethods.cs" company="MorseCode Software">
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

namespace MorseCode.FrameworkExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Provides extension methods for working with lists.
    /// </summary>
    public static class ListExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Return the specified list as a read-only list by using a wrapper.
        /// </summary>
        /// <param name="list">
        /// The list to convert to a read-only list.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="list"/>.
        /// </typeparam>
        /// <returns>
        /// A read-only list of items in <paramref name="list"/>.
        /// </returns>
        public static IReadOnlyList<T> AsReadOnly<T>(this IList<T> list)
        {
            return list == null ? null : new ReadOnlyListWrapper<T>(list);
        }

        /// <summary>
        /// Sets the contents of the list to be equal to the contents of the specified enumerable.
        /// </summary>
        /// <param name="target">The list to modify.</param>
        /// <param name="source">The source enumerable.</param>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        public static void SetTo<T>(this List<T> target, IEnumerable<T> source)
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");

            target.SetTo(source, c => c.Clear(), (t, s) => t.AddRange(s));
        }

        #endregion

        private sealed class ReadOnlyListWrapper<T> : IReadOnlyList<T>
        {
            #region Fields

            private readonly IList<T> source;

            #endregion

            #region Constructors and Destructors

            public ReadOnlyListWrapper(IList<T> source)
            {
                this.source = source;
            }

            #endregion

            #region Explicit Interface Properties

            int IReadOnlyCollection<T>.Count
            {
                get
                {
                    return this.source.Count;
                }
            }

            #endregion

            #region Explicit Interface Indexers

            T IReadOnlyList<T>.this[int index]
            {
                get
                {
                    return this.source[index];
                }
            }

            #endregion

            #region Explicit Interface Methods

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                return this.source.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<T>)this).GetEnumerator();
            }

            #endregion
        }
    }
}