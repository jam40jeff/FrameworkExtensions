#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumUtility.cs" company="MorseCode Software">
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
    /// Contains generically typed static methods to be used as replacements for use their counterparts in <see cref="System.Enum"/>.
    /// </summary>
    public static class EnumUtility
    {
        #region Public Methods and Operators

        /// <summary>
        /// Retrieves a typed array of the values of the constants in a specified enumeration.
        /// </summary>
        /// <typeparam name="T">
        /// The enumeration type to retrieve values from.
        /// </typeparam>
        /// <returns>
        /// A typed array that contains the values of the constants in <typeparamref name="T"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T[] GetValues<T>() where T : struct
        {
            Contract.Ensures(Contract.Result<T[]>() != null);

            return (T[])Enum.GetValues(typeof(T));
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="string"/> containing the name or value to convert.
        /// </param>
        /// <typeparam name="T">
        /// An enumeration type.
        /// </typeparam>
        /// <returns>
        /// An object of type <typeparamref name="T"/> whose value is represented by <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.-or- <paramref name="value"/> is either an empty string or only contains white space.-or- <paramref name="value"/> is a name, but not one of the named constants defined for the enumeration.</exception>
        /// <exception cref="T:System.OverflowException"><paramref name="value"/> is outside the range of the underlying type of <typeparamref name="T"/>.</exception>
        public static T Parse<T>(string value) where T : struct
        {
            Contract.Requires<ArgumentNullException>(value != null, "value");

            return (T)Enum.Parse(typeof(T), value);
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// A parameter specifies whether the operation is case-insensitive.
        /// </summary>
        /// <param name="value">
        /// A <see cref="string"/> containing the name or value to convert.
        /// </param>
        /// <param name="ignoreCase">
        /// <code>true</code> to ignore case; <code>false</code> to regard case.
        /// </param>
        /// <typeparam name="T">
        /// An enumeration type.
        /// </typeparam>
        /// <returns>
        /// An object of type <typeparamref name="T"/> whose value is represented by <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.-or- <paramref name="value"/> is either an empty string or only contains white space.-or- <paramref name="value"/> is a name, but not one of the named constants defined for the enumeration.</exception>
        /// <exception cref="T:System.OverflowException"><paramref name="value"/> is outside the range of the underlying type of <typeparamref name="T"/>.</exception>
        public static T Parse<T>(string value, bool ignoreCase) where T : struct
        {
            Contract.Requires<ArgumentNullException>(value != null, "value");

            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }

        /// <summary>
        /// Converts the specified 8-bit unsigned integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(byte value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified 32-bit signed integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(int value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified 64-bit signed integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(long value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified object with an integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// <typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.-or- <paramref name="value"/> is not type <see cref="T:System.SByte"/>, <see cref="T:System.Int16"/>, <see cref="T:System.Int32"/>,
        /// <see cref="T:System.Int64"/>, <see cref="T:System.Byte"/>, <see cref="T:System.UInt16"/>, <see cref="T:System.UInt32"/>, or <see cref="T:System.UInt64"/>.
        /// </exception>
        public static T ToObject<T>(object value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified 8-bit signed integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(sbyte value) where T : struct
        {
            object returnValue = Enum.ToObject(typeof(T), value);
            Contract.Assume(returnValue != null);
            return (T)returnValue;
        }

        /// <summary>
        /// Converts the specified 16-bit signed integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(short value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified 32-bit unsigned integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(uint value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified 64-bit unsigned integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(ulong value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        /// <summary>
        /// Converts the specified 16-bit unsigned integer value to an enumeration member.
        /// </summary>
        /// <param name="value">
        /// The value to convert to an enumeration member.
        /// </param>
        /// <typeparam name="T">
        /// The enumeration type to return.
        /// </typeparam>
        /// <returns>
        /// An instance of the enumeration set to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> is not an <see cref="T:System.Enum"/>.</exception>
        public static T ToObject<T>(ushort value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        #endregion
    }
}