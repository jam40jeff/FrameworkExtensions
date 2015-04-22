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
    using System.Diagnostics.Contracts;
    using System.Linq;

    /// <summary>
    /// Provides extension methods for working with enumerable instances.
    /// </summary>
    public static class EnumerableExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Returns an empty enumerable if the original enumerable is <code>null</code>.  Otherwise, returns the original enumerable.
        /// </summary>
        /// <param name="enumerable">The original enumerable.</param>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        /// <returns>Returns an empty <see cref="IEnumerable{T}"/> if <paramref name="enumerable"/> is <code>null</code>.  Otherwise, returns <paramref name="enumerable"/>.</returns>
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> enumerable)
        {
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);

            return enumerable ?? new T[0];
        }

        /// <summary>
        /// Returns the first element of the sequence or <c>null</c> if the sequence contains no elements.
        /// </summary>
        /// <param name="enumerable">
        /// The <see cref="IEnumerable{T}"/> to return the first element of.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <returns>
        /// The first element of <paramref name="enumerable"/> or <c>null</c> if the sequence contains no elements.
        /// </returns>
        public static T? FirstOrDefaultForStruct<T>(this IEnumerable<T> enumerable) where T : struct
        {
            Contract.Requires<ArgumentNullException>(enumerable != null, "enumerable");

            return enumerable.Cast<T?>().FirstOrDefault();
        }

        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or <c>null</c> if no such element is found.
        /// </summary>
        /// <param name="enumerable">
        /// The <see cref="IEnumerable{T}"/> to return the an element from.
        /// </param>
        /// <param name="predicate">
        /// A function to test each element for a condition.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <returns>
        /// The first element of <paramref name="enumerable"/> that satisfies the condition specified by <paramref name="predicate"/>
        /// or <c>null</c> if the sequence contains no such element.
        /// </returns>
        public static T? FirstOrDefaultForStruct<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate) where T : struct
        {
            Contract.Requires<ArgumentNullException>(enumerable != null, "enumerable");
            Contract.Requires<ArgumentNullException>(predicate != null, "predicate");

            return enumerable.Where(predicate).Cast<T?>().FirstOrDefault();
        }

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
            Contract.Requires<ArgumentNullException>(getChildren != null, "getChildren");
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);

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
            Contract.Requires<ArgumentNullException>(getChildren != null, "getChildren");
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);

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
        /// Executes the specified action for each item in the enumerable.
        /// </summary>
        /// <param name="enumerable">The enumerable to operate on.  This parameter may be <value>null</value>.</param>
        /// <param name="action">The action to execute for each item in <paramref name="enumerable"/>.  This action takes the item as input.</param>
        /// <typeparam name="T">The type of the items in the enumerable.</typeparam>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            Contract.Requires<ArgumentNullException>(action != null, "action");

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
            Contract.Requires<ArgumentNullException>(action != null, "action");

            if (enumerable == null)
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
        /// Finds the index of the first element that satisfies a condition or <c>null</c>.
        /// </summary>
        /// <param name="enumerable">
        /// The <see cref="IEnumerable{T}"/> to return the an element index from.
        /// </param>
        /// <param name="predicate">
        /// A function to test each element for a condition.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <returns>
        /// The index of the first element of <paramref name="enumerable"/> that satisfies the condition specified by <paramref name="predicate"/>
        /// or <c>null</c> if the sequence contains no such element.
        /// </returns>
        public static int? IndexOf<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(enumerable != null, "enumerable");
            Contract.Requires<ArgumentNullException>(predicate != null, "predicate");

            return enumerable.IndexesWhere(predicate).FirstOrDefaultForStruct();
        }

        /// <summary>
        /// Finds the index of the first element that is equal to the given element or <c>null</c>.
        /// </summary>
        /// <param name="enumerable">
        /// The <see cref="IEnumerable{T}"/> to return the an element index from.
        /// </param>
        /// <param name="item">
        /// The element to find in the sequence.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <returns>
        /// The index of the first element of <paramref name="enumerable"/> that is equal to <paramref name="item"/>
        /// or <c>null</c> if the sequence contains no such element.
        /// </returns>
        /// <remarks>
        /// The default equality comparer for type <typeparamref name="T"/> will be used.
        /// </remarks>
        public static int? IndexOf<T>(this IEnumerable<T> enumerable, T item)
        {
            Contract.Requires<ArgumentNullException>(enumerable != null, "enumerable");

            return enumerable.IndexOf(item, EqualityComparer<T>.Default);
        }

        /// <summary>
        /// Finds the index of the first element that is equal to the given element or <c>null</c>.
        /// </summary>
        /// <param name="enumerable">
        /// The <see cref="IEnumerable{T}"/> to return the an element index from.
        /// </param>
        /// <param name="item">
        /// The element to find in the sequence.
        /// </param>
        /// <param name="comparer">
        /// The equality comparer to use to compare each element of the sequence to <paramref name="item"/>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <returns>
        /// The index of the first element of <paramref name="enumerable"/> that is equal to <paramref name="item"/>
        /// or <c>null</c> if the sequence contains no such element.
        /// </returns>
        public static int? IndexOf<T>(this IEnumerable<T> enumerable, T item, IEqualityComparer<T> comparer)
        {
            Contract.Requires<ArgumentNullException>(enumerable != null, "enumerable");
            Contract.Requires<ArgumentNullException>(comparer != null, "comparer");

            return enumerable.IndexOf(i => comparer.Equals(i, item));
        }

        /// <summary>
        /// Filters a sequence of elements based on a predicate and returns their indexes in the original sequence.
        /// </summary>
        /// <param name="enumerable">
        /// The <see cref="IEnumerable{T}"/> to filter.
        /// </param>
        /// <param name="predicate">
        /// A function to test each element for a condition.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <returns>
        /// A list of indexes of the filtered elements in the original sequence.
        /// </returns>
        public static IEnumerable<int> IndexesWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
        {
            Contract.Requires<ArgumentNullException>(enumerable != null, "enumerable");
            Contract.Requires<ArgumentNullException>(predicate != null, "predicate");
            Contract.Ensures(Contract.Result<IEnumerable<int>>() != null);

            return enumerable.Select((item, index) => new { Item = item, Index = index }).Where(i => predicate(i.Item)).Select(i => i.Index);
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
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);

            return item == null ? new T[0] : new[] { item };
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
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);

            excludeFromEnumerable = excludeFromEnumerable ?? (o => o.Equals(default(T)));

            return excludeFromEnumerable(item) ? new T[0] : new[] { item };
        }

        /// <summary>
        /// Converts a single item into an enumerable.
        /// </summary>
        /// <param name="item">The item to convert into an enumerable.</param>
        /// <typeparam name="T">The type of the item.</typeparam>
        /// <returns>A non-null enumerable instance.  An enumerable with <paramref name="item"/> will always be returned, even if <paramref name="item"/> is <value>null</value>.</returns>
        public static IEnumerable<T> ToSingleEnumerable<T>(this T item)
        {
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);

            return new[] { item };
        }

        /// <summary>
        /// Determines whether two sequences contain the same elements in any order by using the default equality comparer for their type.
        /// </summary>
        /// <param name="first">
        /// An <see cref="IEnumerable{T}"/> to compare to the second sequence.
        /// </param>
        /// <param name="second">
        /// An <see cref="IEnumerable{T}"/> to compare to the first sequence.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements.
        /// </typeparam>
        /// <returns>
        /// Whether or not the two sequences contain the same elements in any order.
        /// </returns>
        public static bool SetEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            return first.SetEqual(second, EqualityComparer<T>.Default);
        }

        /// <summary>
        /// Determines whether two sequences contain the same elements in any order by using a specified <see cref="IEqualityComparer{T}"/>.
        /// </summary>
        /// <param name="first">
        /// An <see cref="IEnumerable{T}"/> to compare to the second sequence.
        /// </param>
        /// <param name="second">
        /// An <see cref="IEnumerable{T}"/> to compare to the first sequence.
        /// </param>
        /// <param name="comparer">
        /// An <see cref="IEqualityComparer{T}"/> to use to compare elements.
        /// </param>
        /// <typeparam name="T">
        /// The type of the elements.
        /// </typeparam>
        /// <returns>
        /// Whether or not the two sequences contain the same elements in any order.
        /// </returns>
        public static bool SetEqual<T>(this IEnumerable<T> first, IEnumerable<T> second, IEqualityComparer<T> comparer)
        {
            Dictionary<T, int> dictionary = new Dictionary<T, int>(comparer);

            IReadOnlyCollection<T> firstCollection;
            if (first == null)
            {
                firstCollection = new T[0];
            }
            else if (first is IReadOnlyCollection<T>)
            {
                firstCollection = (IReadOnlyCollection<T>)first;
            }
            else
            {
                firstCollection = first.ToArray();
            }

            IReadOnlyCollection<T> secondCollection;
            if (second == null)
            {
                secondCollection = new T[0];
            }
            else if (second is IReadOnlyCollection<T>)
            {
                secondCollection = (IReadOnlyCollection<T>)second;
            }
            else
            {
                secondCollection = second.ToArray();
            }

            if (firstCollection.Count != secondCollection.Count)
            {
                return false;
            }

            foreach (T item in firstCollection)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary[item] = 1;
                }
            }

            foreach (T item in secondCollection)
            {
                if (dictionary.ContainsKey(item))
                {
                    int value = dictionary[item];
                    if (value < 1)
                    {
                        return false;
                    }

                    dictionary[item] = value - 1;
                }
                else
                {
                    return false;
                }
            }

            return dictionary.Values.All(count => count == 0);
        }

        #endregion
    }
}