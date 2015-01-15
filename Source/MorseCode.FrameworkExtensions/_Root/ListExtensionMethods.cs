using System.Collections.Generic;

namespace MorseCode.FrameworkExtensions
{
    /// <summary>
    /// Provides extension methods for working with lists.
    /// </summary>
    public static class ListExtensionMethods
    {
        /// <summary>
        /// Sets the contents of the list to be equal to the contents of the specified enumerable.
        /// </summary>
        /// <param name="target">The list to modify.</param>
        /// <param name="source">The source enumerable.</param>
        /// <typeparam name="T">The type of the items in the collection.</typeparam>
        /// <exception cref=""
        public static void SetTo<T>(this List<T> target, IEnumerable<T> source)
        {
            target.SetTo(source, c => c.Clear(), (t, s) => t.AddRange(s));
        }
    }
}