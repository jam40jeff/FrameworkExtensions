#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyExtensionMethods.cs" company="MorseCode Software">
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
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Extension methods for use with lazy-loaded values.
    /// </summary>
    public static class LazyExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Ensures that the value has been created for the specified lazy-loaded value.
        /// </summary>
        /// <param name="lazy">
        /// The lazy-loaded value to for which to ensure that the value has been created.
        /// </param>
        /// <typeparam name="T">
        /// The type of the value created by <paramref name="lazy"/>.
        /// </typeparam>
        public static void EnsureValue<T>(this Lazy<T> lazy)
        {
            Contract.Requires<ArgumentNullException>(lazy != null, "lazy");

#pragma warning disable 168
            T value = lazy.Value;
#pragma warning restore 168
        }

        #endregion
    }
}