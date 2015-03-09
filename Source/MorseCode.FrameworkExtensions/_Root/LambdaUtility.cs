#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LambdaUtility.cs" company="MorseCode Software">
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
    /// Provides utilities for use with lambdas.
    /// </summary>
    public static class LambdaUtility
    {
        #region Public Methods and Operators

        /// <summary>
        /// Allows for implicitly typing of a lambda.
        /// </summary>
        /// <param name="action">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action"/>.
        /// </returns>
        public static Action TypeLambda(Action action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T}"/>.
        /// </returns>
        public static Action<T> TypeLambda<T>(Action<T> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <param name="action">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2}"/>.
        /// </returns>
        public static Action<T1, T2> TypeLambda<T1, T2>(Action<T1, T2> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3}"/>.
        /// </returns>
        public static Action<T1, T2, T3> TypeLambda<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4> TypeLambda<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5> TypeLambda<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6> TypeLambda<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7> TypeLambda<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Action{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/>.
        /// </returns>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return action;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T}"/>.
        /// </returns>
        public static Func<T> TypeLambda<T>(Func<T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T,T1}"/>.
        /// </returns>
        public static Func<T1, T> TypeLambda<T1, T>(Func<T1, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
        /// </summary>
        /// <typeparam name="T1">
        /// The type of the first parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of the delegate.
        /// </typeparam>
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T,T1,T2}"/>.
        /// </returns>
        public static Func<T1, T2, T> TypeLambda<T1, T2, T>(Func<T1, T2, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T,T1,T2,T3}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T> TypeLambda<T1, T2, T3, T>(Func<T1, T2, T3, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T,T1,T2,T3,T4}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T> TypeLambda<T1, T2, T3, T4, T>(Func<T1, T2, T3, T4, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T> TypeLambda<T1, T2, T3, T4, T5, T>(Func<T1, T2, T3, T4, T5, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T> TypeLambda<T1, T2, T3, T4, T5, T6, T>(Func<T1, T2, T3, T4, T5, T6, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T>(Func<T1, T2, T3, T4, T5, T6, T7, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T> func)
        {
            return func;
        }

        /// <summary>
        /// Allows for implicitly typing of a lambda.
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
        /// <typeparam name="T">
        /// The type of the return value of the delegate.
        /// </typeparam>
        /// <param name="func">
        /// The lambda to implicitly type.
        /// </param>
        /// <returns>
        /// The typed <see cref="Func{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,T}"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T> TypeLambda<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T> func)
        {
            return func;
        }

        #endregion
    }
}