#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectionExtensionMethods.cs" company="MorseCode Software">
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
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    /// <summary>
    /// Provides extension methods for working with collections.
    /// </summary>
    public static class CollectionExtensionMethods
    {
        #region Delegates

        internal delegate void AddRangeDelegate<in TCollection, in T>(TCollection target, IEnumerable<T> source) where TCollection : class, ICollection<T>;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Sets the contents of the collection to be equal to the contents of the specified enumerable.
        /// </summary>
        /// <param name="target">The collection to modify.</param>
        /// <param name="source">The source enumerable.</param>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        public static void SetTo<T>(this ICollection<T> target, IEnumerable<T> source)
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");

            target.SetTo(source, c => c.Clear(), (t, s) => s.ForEach(t.Add));
        }

        #endregion

        #region Methods

        internal static void SetTo<TCollection, T>(this TCollection target, IEnumerable<T> source, Action<ICollection<T>> clearAction, AddRangeDelegate<TCollection, T> addRangeAction) where TCollection : class, ICollection<T>
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(clearAction != null, "clearAction");
            Contract.Requires<ArgumentNullException>(addRangeAction != null, "addRangeAction");

            if (ReferenceEquals(source, target))
            {
                return;
            }

            if (source == null)
            {
                clearAction(target);
                return;
            }

            List<T> sourceList = source.ToList();

            if (sourceList.Count < 1)
            {
                clearAction(target);
            }

            clearAction(target);
            addRangeAction(target, sourceList);
        }

        #endregion
    }
}