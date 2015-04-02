#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNull.cs" company="MorseCode Software">
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
    /// Provides factory methods for creating <see cref="INotNull{T}"/> and <see cref="INotNullMutable{T}"/> instances.
    /// </summary>
    public static class NotNull
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a <see cref="INotNull{T}"/> instance representing an immutable object with a non-null value.
        /// </summary>
        /// <param name="value">
        /// The value of the immutable object.  This value must not be <code>null</code>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the value of the immutable object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNull{T}"/> instance with value <paramref name="value"/>.
        /// </returns>
        public static INotNull<T> Create<T>(T value)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(value, null), "value");
            Contract.Ensures(Contract.Result<INotNull<T>>() != null);

            return new NotNull<T>(value);
        }

        /// <summary>
        /// Creates a <see cref="INotNullMutable{T}"/> instance representing a mutable object with a non-null value.
        /// </summary>
        /// <param name="value">
        /// The value of the mutable object.  This value must not be <code>null</code>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the value of the mutable object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNullMutable{T}"/> instance with value <paramref name="value"/>.
        /// </returns>
        public static INotNullMutable<T> CreateMutable<T>(T value)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(value, null), "value");
            Contract.Ensures(Contract.Result<INotNull<T>>() != null);

            return new NotNullMutable<T>(value);
        }

        #endregion
    }
}