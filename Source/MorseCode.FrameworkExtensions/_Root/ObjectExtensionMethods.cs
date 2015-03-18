#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectExtensionMethods.cs" company="MorseCode Software">
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
    /// <summary>
    /// Contains extension methods for use with any <see cref="object"/>.
    /// </summary>
    public static class ObjectExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Safely casts an object to type <typeparamref name="T"/> using only an implicit conversion.
        /// </summary>
        /// <param name="o">The object to cast.</param>
        /// <typeparam name="T">The type to which to cast.</typeparam>
        /// <returns>The object as type <typeparamref name="T"/>.</returns>
        public static T SafeCast<T>(this T o)
        {
            return o;
        }

        /// <summary>
        /// Safely converts any object to a string, returning <code>null</code> if the object is <code>null</code> or calling the <see cref="object.ToString"/> method on it otherwise.
        /// </summary>
        /// <param name="o">
        /// The object to convert to a string.
        /// </param>
        /// <returns>
        /// The <see cref="string"/> representation of <paramref name="o"/>.
        /// </returns>
        public static string SafeToString(this object o)
        {
            return o == null ? null : o.ToString();
        }

        #endregion
    }
}