#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToFuncExtensionMethod.cs" company="MorseCode Software">
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

    /// <summary>
    /// Provides an extension method for converting <see cref="Action"/> delegates to <see cref="Func{T}"/> delegates, where <c>T</c> is <see cref="Unit"/>.
    /// </summary>
    public static class ToFuncExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Converts the given <see cref="Action"/> delegate to a
        /// <see cref="Func{T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <param name="action">
        /// The <see cref="Action"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<Unit> ToFunc(this Action action)
        {
            if (action == null)
            {
                return null;
            }

            return () =>
                {
                    action();
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1}"/> delegate to a
        /// <see cref="Func{T1,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, Unit> ToFunc<T1>(this Action<T1> action)
        {
            if (action == null)
            {
                return null;
            }

            return a =>
                {
                    action(a);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2}"/> delegate to a
        /// <see cref="Func{T1,T2,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, Unit> ToFunc<T1, T2>(this Action<T1, T2> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b) =>
                {
                    action(a, b);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, Unit> ToFunc<T1, T2, T3>(this Action<T1, T2, T3> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c) =>
                {
                    action(a, b, c);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, Unit> ToFunc<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d) =>
                {
                    action(a, b, c, d);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, Unit> ToFunc<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e) =>
                {
                    action(a, b, c, d, e);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, Unit> ToFunc<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f) =>
                {
                    action(a, b, c, d, e, f);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g) =>
                {
                    action(a, b, c, d, e, f, g);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h) =>
                {
                    action(a, b, c, d, e, f, g, h);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i) =>
                {
                    action(a, b, c, d, e, f, g, h, i);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j, k);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j, k, l);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j, k, l, m);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
                    return null;
                };
        }

        /// <summary>
        /// Converts the given <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> delegate to a
        /// <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit> ToFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            if (action == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
                {
                    action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
                    return null;
                };
        }

        #endregion
    }
}