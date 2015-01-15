using System;
using System.Collections.Generic;

namespace MorseCode.FrameworkExtensions
{
    /// <summary>
    /// Provides extension methods for working with enumerables.
    /// </summary>
    public static class EnumerableExtensionMethods
    {
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
        public static IEnumerable<T> ToEnumerableForStruct<T>(this T item, Func<T, bool> excludeFromEnumerable = null) where T : struct
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
    }
}