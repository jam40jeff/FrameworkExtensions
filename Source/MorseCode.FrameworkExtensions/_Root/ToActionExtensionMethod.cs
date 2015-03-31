#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ToActionExtensionMethod.cs" company="MorseCode Software">
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
    /// Provides an extension method for converting <see cref="Func{T}"/> delegates to <see cref="Action"/> delegates, where <c>T</c> is <see cref="Unit"/>.
    /// </summary>
    public static class ToActionExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Converts the given <see cref="Func{T}"/> delegate to a
        /// <see cref="Action"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <param name="func">
        /// The <see cref="Func{T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action ToAction(this Func<Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return () => func();
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T}"/> delegate to a
        /// <see cref="Action{T1}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The <see cref="Func{T1,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1> ToAction<T1>(this Func<T1, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return a => func(a);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T}"/> delegate to a
        /// <see cref="Action{T1,T2}"/> delegate,
        /// where <c>T</c> is <see cref="Unit"/>.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2> ToAction<T1, T2>(this Func<T1, T2, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b) => func(a, b);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3> ToAction<T1, T2, T3>(this Func<T1, T2, T3, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c) => func(a, b, c);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4> ToAction<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d) => func(a, b, c, d);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5> ToAction<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e) => func(a, b, c, d, e);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6> ToAction<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f) => func(a, b, c, d, e, f);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7> ToAction<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g) => func(a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> ToAction<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h) => func(a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i) => func(a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j) => func(a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k) => func(a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l) => func(a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => func(a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        /// <summary>
        /// Converts the given <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T}"/> delegate to a
        /// <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> delegate,
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
        /// <param name="func">
        /// The <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T}"/> delegate to convert.
        /// </param>
        /// <returns>
        /// The resulting <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> delegate, where <c>T</c> is <see cref="Unit"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit> func)
        {
            if (func == null)
            {
                return null;
            }

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        #endregion
    }
}