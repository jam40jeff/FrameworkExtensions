#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SymmetricEqualityComparer{T}.cs" company="MorseCode Software">
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
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// An equality comparer which compares two objects for symmetric equality, where two non-null objects are equal
    /// if and only if <c>a.Equals(b)</c> and <c>b.Equals(a)</c>.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the objects being compared.
    /// </typeparam>
    /// <remarks>
    /// This class is valid for value types as it avoids boxing.  Use the non-generic version,
    /// <see cref="SymmetricEqualityComparer"/>, for reference types.
    /// </remarks>
    public class SymmetricEqualityComparer<T> : IEqualityComparer<T>, IEqualityComparer
        where T : struct
    {
        #region Static Fields

        private static readonly SymmetricEqualityComparer<T> PrivateInstance = new SymmetricEqualityComparer<T>();

        #endregion

        #region Constructors and Destructors

        private SymmetricEqualityComparer()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the singleton instance of <see cref="SymmetricEqualityComparer{T}"/>.
        /// </summary>
        public static SymmetricEqualityComparer<T> Instance
        {
            get
            {
                Contract.Ensures(Contract.Result<SymmetricEqualityComparer<T>>() != null);

                return PrivateInstance;
            }
        }

        #endregion

        #region Explicit Interface Methods

        bool IEqualityComparer.Equals(object x, object y)
        {
            if (x is T && y is T)
            {
                return this.ImplicitlyConvert<IEqualityComparer<T>>().Equals((T)x, (T)y);
            }

            return x == y;
        }

        int IEqualityComparer.GetHashCode(object obj)
        {
            if (!(obj is T))
            {
                throw new ArgumentException("Parameter obj must be convertible to type " + typeof(T).FullName + ".", "obj");
            }

            return this.ImplicitlyConvert<IEqualityComparer<T>>().GetHashCode((T)obj);
        }

        bool IEqualityComparer<T>.Equals(T x, T y)
        {
            return x.SymmetricEquals(y);
        }

        int IEqualityComparer<T>.GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
}