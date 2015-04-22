#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DictionaryExtensionMethods.cs" company="MorseCode Software">
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

    /// <summary>
    /// Provides extension methods for working with dictionaries.
    /// </summary>
    public static class DictionaryExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Gets the value for the specified key from the dictionary if it exists,
        /// otherwise returns the result of <paramref name="keyNotFoundValueFactory"/>.
        /// </summary>
        /// <param name="dictionary">
        /// The dictionary to search.
        /// </param>
        /// <param name="key">
        /// The key to search for in <paramref name="dictionary"/>.
        /// </param>
        /// <param name="keyNotFoundValueFactory">
        /// The function to produce a value to be returned if <paramref name="key"/>
        /// is not found in <paramref name="dictionary"/>.
        /// </param>
        /// <typeparam name="TKey">
        /// The type of the keys in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <typeparam name="TValue">
        /// The type of the values in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <returns>
        /// The value for the specified key from the dictionary if it exists,
        /// otherwise returns the result of <paramref name="keyNotFoundValueFactory"/>.
        /// </returns>
        public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> keyNotFoundValueFactory)
        {
            Contract.Requires<ArgumentNullException>(dictionary != null, "dictionary");
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(key, null), "key");
            Contract.Requires<ArgumentNullException>(keyNotFoundValueFactory != null, "keyNotFoundValueFactory");

            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : keyNotFoundValueFactory();
        }

        /// <summary>
        /// Gets the value for the specified key from the dictionary if it exists,
        /// otherwise returns <paramref name="keyNotFoundValue"/>.
        /// </summary>
        /// <param name="dictionary">
        /// The dictionary to search.
        /// </param>
        /// <param name="key">
        /// The key to search for in <paramref name="dictionary"/>.
        /// </param>
        /// <param name="keyNotFoundValue">
        /// The value to be returned if <paramref name="key"/> is not found in <paramref name="dictionary"/>.
        /// </param>
        /// <typeparam name="TKey">
        /// The type of the keys in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <typeparam name="TValue">
        /// The type of the values in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <returns>
        /// The value for the specified key from the dictionary if it exists,
        /// otherwise returns <paramref name="keyNotFoundValue"/>.
        /// </returns>
        public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue keyNotFoundValue)
        {
            Contract.Requires<ArgumentNullException>(dictionary != null, "dictionary");
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(key, null), "key");

            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : keyNotFoundValue;
        }

        /// <summary>
        /// Gets the value for the specified key from the dictionary if it exists, otherwise returns <c>null</c>.
        /// </summary>
        /// <param name="dictionary">
        /// The dictionary to search.
        /// </param>
        /// <param name="key">
        /// The key to search for in <paramref name="dictionary"/>.
        /// </param>
        /// <typeparam name="TKey">
        /// The type of the keys in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <typeparam name="TValue">
        /// The type of the values in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <returns>
        /// The value for the specified key from the dictionary if it exists, otherwise returns <c>null</c>.
        /// </returns>
        public static TValue GetValueOrNull<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TValue : class
        {
            Contract.Requires<ArgumentNullException>(dictionary != null, "dictionary");
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(key, null), "key");

            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : null;
        }

        /// <summary>
        /// Gets the value for the specified key from the dictionary if it exists, otherwise returns <c>null</c>.
        /// </summary>
        /// <param name="dictionary">
        /// The dictionary to search.
        /// </param>
        /// <param name="key">
        /// The key to search for in <paramref name="dictionary"/>.
        /// </param>
        /// <typeparam name="TKey">
        /// The type of the keys in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <typeparam name="TValue">
        /// The type of the values in <paramref name="dictionary"/>.
        /// </typeparam>
        /// <returns>
        /// The value for the specified key from the dictionary if it exists, otherwise returns <c>null</c>.
        /// </returns>
        public static TValue? GetValueOrNullForStruct<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TValue : struct
        {
            Contract.Requires<ArgumentNullException>(dictionary != null, "dictionary");
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(key, null), "key");

            TValue value;
            return dictionary.TryGetValue(key, out value) ? value : (TValue?)null;
        }

        #endregion
    }
}