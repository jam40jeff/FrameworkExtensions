#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotNullExtensionMethods.cs" company="MorseCode Software">
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
    /// Provides extension methods for working with the <see cref="NotNullMutable{T}"/> struct.
    /// </summary>
    public static class NotNullExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Translates an <see cref="INotNull{T1}"/> value into a new <see cref="INotNullMutable{T2}"/> value using the given bind function.  This is the bind monad operator for type <see cref="INotNullMutable{T1}"/>.
        /// </summary>
        /// <param name="o">
        /// The object to translate.
        /// </param>
        /// <param name="bind">
        /// The bind function which translates the value contained in <paramref name="o"/>.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the object to translate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the resulting object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNullMutable{T2}"/> value which results from executing <paramref name="bind"/> on the value contained in <paramref name="o"/>.
        /// </returns>
        public static INotNullMutable<T2> Bind<T1, T2>(this INotNull<T1> o, Func<T1, INotNullMutable<T2>> bind)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Requires<ArgumentNullException>(bind != null, "bind");
            Contract.Ensures(Contract.Result<INotNullMutable<T2>>() != null);

            INotNullMutable<T2> result = bind(o.Value);
            if (result == null)
            {
                throw new ArgumentException("The bind function cannot return null.", "bind");
            }

            return result;
        }

        /// <summary>
        /// Translates an <see cref="INotNull{T1}"/> value into a new <see cref="INotNull{T2}"/> value using the given bind function.  This is the bind monad operator for type <see cref="INotNull{T1}"/>.
        /// </summary>
        /// <param name="o">
        /// The object to translate.
        /// </param>
        /// <param name="bind">
        /// The bind function which translates the value contained in <paramref name="o"/>.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the object to translate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the resulting object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNull{T2}"/> value which results from executing <paramref name="bind"/> on the value contained in <paramref name="o"/>.
        /// </returns>
        public static INotNull<T2> Bind<T1, T2>(this INotNull<T1> o, Func<T1, INotNull<T2>> bind)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Requires<ArgumentNullException>(bind != null, "bind");
            Contract.Ensures(Contract.Result<INotNull<T2>>() != null);

            INotNull<T2> result = bind(o.Value);
            if (result == null)
            {
                throw new ArgumentException("The bind function cannot return null.", "bind");
            }

            return result;
        }

        /// <summary>
        /// Translates an <see cref="INotNull{T1}"/> value into a new <see cref="INotNullMutable{T2}"/> value using the given bind function and selector function.
        /// </summary>
        /// <param name="o">
        /// The object to translate.
        /// </param>
        /// <param name="map">
        /// The mapping function which translates a value of type <typeparamref name="T1"/> into a value of type <typeparamref name="T2"/>.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the object to translate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the resulting object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNullMutable{T2}"/> value which results from executing <paramref name="map"/> on the value contained in <paramref name="o"/>.
        /// </returns>
        public static INotNullMutable<T2> SelectMutable<T1, T2>(this INotNull<T1> o, Func<T1, T2> map)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Requires<ArgumentNullException>(map != null, "map");
            Contract.Ensures(Contract.Result<INotNullMutable<T2>>() != null);

            T2 mappedValue = map(o.Value);
            if (ReferenceEquals(mappedValue, null))
            {
                throw new ArgumentException("The mapping function cannot return null.", "map");
            }

            return mappedValue.ToNotNullMutable();
        }

        /// <summary>
        /// Translates an <see cref="INotNull{T1}"/> value into a new <see cref="INotNullMutable{T3}"/> value using the given bind function and selector function.  This method allows for the use of <see cref="INotNullMutable{T1}"/> in query comprehension syntax statements.
        /// </summary>
        /// <param name="o">
        /// The object to translate.
        /// </param>
        /// <param name="bind">
        /// The bind function which translates the value contained in <paramref name="o"/>.
        /// </param>
        /// <param name="select">
        /// The selector function which translates the result of the bind function.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the object to translate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the intermediate result after calling the bind function.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the resulting object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNullMutable{T3}"/> value which results from executing <paramref name="bind"/> then <paramref name="select"/> on the value contained in <paramref name="o"/>.
        /// </returns>
        public static INotNullMutable<T3> SelectMany<T1, T2, T3>(this INotNull<T1> o, Func<T1, INotNullMutable<T2>> bind, Func<T1, T2, T3> select)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Requires<ArgumentNullException>(bind != null, "bind");
            Contract.Requires<ArgumentNullException>(select != null, "select");
            Contract.Ensures(Contract.Result<INotNullMutable<T3>>() != null);

            return o.Bind(aValue =>
            {
                INotNullMutable<T2> b = bind(aValue);
                if (b == null)
                {
                    throw new ArgumentException("The bind function cannot return null.", "bind");
                }

                return b.Bind(bValue => select(aValue, bValue).ToNotNullMutable());
            });
        }

        /// <summary>
        /// Translates an <see cref="INotNull{T1}"/> value into a new <see cref="INotNull{T3}"/> value using the given bind function and selector function.  This method allows for the use of <see cref="INotNull{T1}"/> in query comprehension syntax statements.
        /// </summary>
        /// <param name="o">
        /// The object to translate.
        /// </param>
        /// <param name="bind">
        /// The bind function which translates the value contained in <paramref name="o"/>.
        /// </param>
        /// <param name="select">
        /// The selector function which translates the result of the bind function.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the object to translate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the intermediate result after calling the bind function.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the resulting object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNull{T3}"/> value which results from executing <paramref name="bind"/> then <paramref name="select"/> on the value contained in <paramref name="o"/>.
        /// </returns>
        public static INotNull<T3> SelectMany<T1, T2, T3>(this INotNull<T1> o, Func<T1, INotNull<T2>> bind, Func<T1, T2, T3> select)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Requires<ArgumentNullException>(bind != null, "bind");
            Contract.Requires<ArgumentNullException>(select != null, "select");
            Contract.Ensures(Contract.Result<INotNull<T3>>() != null);

            return o.Bind(aValue =>
                {
                    INotNull<T2> b = bind(aValue);
                    if (b == null)
                    {
                        throw new ArgumentException("The bind function cannot return null.", "bind");
                    }

                    return b.Bind(bValue => select(aValue, bValue).ToNotNull());
                });
        }

        /// <summary>
        /// Translates an <see cref="INotNull{T1}"/> value into a new <see cref="INotNull{T2}"/> value using the given bind function and selector function.
        /// </summary>
        /// <param name="o">
        /// The object to translate.
        /// </param>
        /// <param name="map">
        /// The mapping function which translates a value of type <typeparamref name="T1"/> into a value of type <typeparamref name="T2"/>.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the object to translate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the resulting object.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNull{T2}"/> value which results from executing <paramref name="map"/> on the value contained in <paramref name="o"/>.
        /// </returns>
        public static INotNull<T2> Select<T1, T2>(this INotNull<T1> o, Func<T1, T2> map)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Requires<ArgumentNullException>(map != null, "map");
            Contract.Ensures(Contract.Result<INotNull<T2>>() != null);

            T2 mappedValue = map(o.Value);
            if (ReferenceEquals(mappedValue, null))
            {
                throw new ArgumentException("The mapping function cannot return null.", "map");
            }

            return mappedValue.ToNotNull();
        }

        /// <summary>
        /// Converts the given object of type <typeparamref name="T"/> into an <see cref="INotNullMutable{T}"/>.  This is the return (or unit) monad operator for type <see cref="INotNullMutable{T}"/>.
        /// </summary>
        /// <param name="o">
        /// The object to convert to an instance of <see cref="NotNullMutable{T}"/>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the object to convert.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNullMutable{T}"/> instance containing the value <paramref name="o"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="o"/> is null.</exception>
        public static INotNullMutable<T> ToNotNullMutable<T>(this T o)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Ensures(Contract.Result<INotNullMutable<T>>() != null);

            return new NotNullMutable<T>(o);
        }

        /// <summary>
        /// Converts the given object of type <typeparamref name="T"/> into an <see cref="INotNull{T}"/>.  This is the return (or unit) monad operator for type <see cref="INotNull{T}"/>.
        /// </summary>
        /// <param name="o">
        /// The object to convert to an instance of <see cref="INotNull{T}"/>.
        /// </param>
        /// <typeparam name="T">
        /// The type of the object to convert.
        /// </typeparam>
        /// <returns>
        /// The <see cref="INotNull{T}"/> instance containing the value <paramref name="o"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="o"/> is null.</exception>
        public static INotNull<T> ToNotNull<T>(this T o)
        {
            Contract.Requires<ArgumentNullException>(!ReferenceEquals(o, null), "o");
            Contract.Ensures(Contract.Result<INotNull<T>>() != null);

            return new NotNull<T>(o);
        }

        #endregion
    }
}