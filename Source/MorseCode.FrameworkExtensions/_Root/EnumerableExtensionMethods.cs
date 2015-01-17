#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerableExtensionMethods.cs" company="MorseCode Software">
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
    using System.Linq;

    /// <summary>
    /// Provides extension methods for working with enumerable instances.
    /// </summary>
    public static class EnumerableExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Recursively flatten a hierarchical item.
        /// </summary>
        /// <param name="root">
        /// The root item.
        /// </param>
        /// <param name="getChildren">
        /// The method which returns the children of the given parent item.
        /// </param>
        /// <typeparam name="T">
        /// The type of the items.
        /// </typeparam>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> of the recursively flattened items.
        /// </returns>
        public static IEnumerable<T> FlattenRecursively<T>(this T root, Func<T, IEnumerable<T>> getChildren)
        {
            if (ReferenceEquals(root, null))
            {
                yield break;
            }

            yield return root;
            foreach (T child in getChildren(root).FlattenRecursively(getChildren))
            {
                yield return child;
            }
        }

        /// <summary>
        /// Recursively flatten a hierarchical list of items.
        /// </summary>
        /// <param name="root">
        /// The root list of items.
        /// </param>
        /// <param name="getChildren">
        /// The method which returns the children of the given parent item.
        /// </param>
        /// <typeparam name="T">
        /// The type of the items.
        /// </typeparam>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> of the recursively flattened items.
        /// </returns>
        public static IEnumerable<T> FlattenRecursively<T>(this IEnumerable<T> root, Func<T, IEnumerable<T>> getChildren)
        {
            if (root == null)
            {
                yield break;
            }

            foreach (T child in root.SelectMany(item => item.FlattenRecursively(getChildren)))
            {
                yield return child;
            }
        }

        /// <summary>
        /// Returns an empty enumerable if the original enumerable is <code>null</code>.  Otherwise, returns the original enumerable.
        /// </summary>
        /// <param name="enumerable">The original enumerable.</param>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        /// <returns>Returns an empty <see cref="IEnumerable{T}"/> if <paramref name="enumerable"/> is <code>null</code>.  Otherwise, returns <paramref name="enumerable"/>.</returns>
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> enumerable)
        {
            return enumerable ?? new T[0];
        }

        /// <summary>
        /// Executes the specified action for each item in the enumerable.
        /// </summary>
        /// <param name="enumerable">The enumerable to operate on.  This parameter may be <value>null</value>.</param>
        /// <param name="action">The action to execute for each item in <paramref name="enumerable"/>.  This action takes the item as input.</param>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            ForEach(enumerable, (o, i) => action(o));
        }

        /// <summary>
        /// Executes the specified action for each item in the enumerable.
        /// </summary>
        /// <param name="enumerable">The enumerable to operate on.  This parameter may be <value>null</value>.</param>
        /// <param name="action">The action to execute for each item in <paramref name="enumerable"/>.  This action takes the item and the item's index as input.</param>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T, int> action)
        {
            if (action == null || enumerable == null)
            {
                return;
            }

            int count = 0;
            foreach (T o in enumerable)
            {
                action(o, count);
                count++;
            }
        }

        /// <summary>
        /// Converts a single reference type item into an enumerable.
        /// </summary>
        /// <param name="item">The item to convert into an enumerable.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>A non-null enumerable instance.  If <paramref name="item"/> is <value>null</value>, an empty enumerable will be returned.
        /// Otherwise, an enumerable with only <paramref name="item"/> in it will be returned.</returns>
        public static IEnumerable<T> ToEnumerable<T>(this T item) where T : class
        {
            if (item == null)
            {
                return new T[0];
            }

            return new[] { item };
        }

        /// <summary>
        /// Converts a single value type item into an enumerable.
        /// </summary>
        /// <param name="item">The item to convert into an enumerable.</param>
        /// <param name="excludeFromEnumerable">A predicate to determine if the item should be excluded from the resulting enumerable.  If this parameter is <value>null</value>,
        /// then the item will be excluded if it is equal to the default value for its type.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>A non-null enumerable instance.  If <paramref name="item"/> is <value>null</value>, an empty enumerable will be returned.
        /// Otherwise, an enumerable with only <paramref name="item"/> in it will be returned.</returns>
        /// <remarks>To ensure that <paramref name="item"/> is never excluded from the resulting enumerable, either pass the predicate <value>o => false</value>,
        /// or call <see cref="ToSingleEnumerable{T}"/> instead.</remarks>
        public static IEnumerable<T> ToEnumerableForStruct<T>(this T item, Func<T, bool> excludeFromEnumerable = null)
            where T : struct
        {
            excludeFromEnumerable = excludeFromEnumerable ?? (o => o.Equals(default(T)));

            if (excludeFromEnumerable(item))
            {
                return new T[0];
            }

            return new[] { item };
        }

        /// <summary>
        /// Converts a single item into an enumerable.
        /// </summary>
        /// <param name="item">The item to convert into an enumerable.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>A non-null enumerable instance.  An enumerable with <paramref name="item"/> will always be returned, even if <paramref name="item"/> is <value>null</value>.</returns>
        public static IEnumerable<T> ToSingleEnumerable<T>(this T item)
        {
            return new[] { item };
        }

        #endregion
    }
}