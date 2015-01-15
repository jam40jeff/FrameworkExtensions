using System;
using System.Collections.Generic;
using System.Linq;

namespace MorseCode.FrameworkExtensions
{
    /// <summary>
    /// Provides extension methods for working with collections.
    /// </summary>
    public static class CollectionExtensionMethods
    {
        internal delegate void AddRangeDelegate<in TCollection, in T>(TCollection target, IEnumerable<T> source) where TCollection : class, ICollection<T>;

        internal static void SetTo<TCollection, T>(this TCollection target, IEnumerable<T> source, Action<ICollection<T>> clearAction, AddRangeDelegate<TCollection, T> addRangeAction) where TCollection : class,ICollection<T>
        {
            if (ReferenceEquals(source, target))
            {
                return;
            }

            if (source == null)
            {
                if (target != null)
                {
                    clearAction(target);
                }

                return;
            }

            List<T> sourceList = source.ToList();

            if (sourceList.Count < 1)
            {
                if (target != null)
                {
                    clearAction(target);
                }
            }

            if (target == null)
            {
                throw new InvalidOperationException("Target may not be null if source is not empty.");
            }

            clearAction(target);
            addRangeAction(target, sourceList);
        }

        /// <summary>
        /// Sets the contents of the collection to be equal to the contents of the specified enumerable.
        /// </summary>
        /// <param name="target">The collection to modify.</param>
        /// <param name="source">The source enumerable.</param>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        public static void SetTo<T>(this ICollection<T> target, IEnumerable<T> source)
        {
            target.SetTo(source, c => c.Clear(), (t, s) => s.ForEach(t.Add));
        }
    }
}
