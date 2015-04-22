#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReferenceEqualityComparer.cs" company="MorseCode Software">
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
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// An equality comparer which compares two objects for reference equality.
    /// </summary>
    /// <remarks>
    /// This equality comparer should only be used to compare reference types.
    /// </remarks>
    public class ReferenceEqualityComparer : IEqualityComparer<object>, IEqualityComparer
    {
        #region Static Fields

        private static readonly ReferenceEqualityComparer PrivateInstance = new ReferenceEqualityComparer();

        #endregion

        #region Constructors and Destructors

        private ReferenceEqualityComparer()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the singleton instance of <see cref="SymmetricEqualityComparer"/>.
        /// </summary>
        public static ReferenceEqualityComparer Instance
        {
            get
            {
                Contract.Ensures(Contract.Result<ReferenceEqualityComparer>() != null);

                return PrivateInstance;
            }
        }

        #endregion

        #region Explicit Interface Methods

        bool IEqualityComparer.Equals(object x, object y)
        {
            return this.ImplicitlyConvert<IEqualityComparer<object>>().Equals(x, y);
        }

        int IEqualityComparer.GetHashCode(object obj)
        {
            return this.ImplicitlyConvert<IEqualityComparer<object>>().GetHashCode(obj);
        }

        bool IEqualityComparer<object>.Equals(object x, object y)
        {
            return ReferenceEquals(x, y);
        }

        int IEqualityComparer<object>.GetHashCode(object obj)
        {
            return ReferenceEquals(obj, null) ? 0 : obj.GetHashCode();
        }

        #endregion
    }
}