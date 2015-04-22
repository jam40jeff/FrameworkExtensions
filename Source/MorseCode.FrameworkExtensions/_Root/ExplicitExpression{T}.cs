#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExplicitExpression{T}.cs" company="MorseCode Software">
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
    using System.Linq.Expressions;

    /// <summary>
    /// Provides a factory method for creating an explicit property expression.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the object on which to get the property for the expression.
    /// </typeparam>
    /// <remarks>
    /// Explicit property expressions can be used to prevent expressions from apply a conversion to their return type automatically.
    /// For instance, if a method expects an expression of type <see cref="Expression{TDelegate}"/> where <c>TDelegate</c> is a function returning
    /// a nullable value-type from an object, then an expression returning a non-nullable property may be passed in as the return type of the
    /// function will automatically be converted to the nullable type.  This class is a way to declare the expression with the exact type of the
    /// property to ensure no automatic conversions are unknowingly applied.
    /// </remarks>
    public static class ExplicitExpression<T>
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates an explicit property expression from the provided expression.
        /// </summary>
        /// <param name="expression">
        /// The expression from which to create an explicit property expression.
        /// </param>
        /// <typeparam name="TProperty">
        /// The type of the property returned by <paramref name="expression"/>.
        /// </typeparam>
        /// <returns>
        /// The explicit property expression created from the <paramref name="expression"/>.
        /// </returns>
        public static ExplicitExpression<T, TProperty> Create<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            Contract.Requires<ArgumentNullException>(expression != null, "expression");
            Contract.Ensures(Contract.Result<ExplicitExpression<T, TProperty>>() != null);

            return new ExplicitExpression<T, TProperty>(expression);
        }

        #endregion
    }
}