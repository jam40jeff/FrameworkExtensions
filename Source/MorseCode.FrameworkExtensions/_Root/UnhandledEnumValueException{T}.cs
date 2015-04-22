#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnhandledEnumValueException{T}.cs" company="MorseCode Software">
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
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    /// <summary>
    /// The exception that is thrown when an unhandled enumeration value is encountered.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the enumeration.
    /// </typeparam>
    /// <remarks>
    /// The intended usage for this exception is to throw it in the default block of a switch statement on an enumeration value
    /// meant to handle all possible values of the enumeration.
    /// </remarks>
    [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", Justification = "Implemented by base class.")]
    [Serializable]
    public class UnhandledEnumValueException<T> : UnhandledEnumValueException
        where T : struct, IComparable, IFormattable, IConvertible
    {
        #region Fields

        private readonly T value;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException{T}"/> class with a specified message and unhandled enumeration value.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="value">
        /// The unhandled enumeration value.
        /// </param>
        public UnhandledEnumValueException(string message, T value)
            : base(message, typeof(T))
        {
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException{T}"/> class.
        /// </summary>
        public UnhandledEnumValueException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException{T}"/> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public UnhandledEnumValueException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException{T}"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.
        /// </param>
        public UnhandledEnumValueException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException{T}"/> class with serialized data.
        /// </summary>
        /// <param name="info">
        /// The object that holds the serialized object data.
        /// </param>
        /// <param name="context">
        /// The contextual information about the source or destination.
        /// </param>
        protected UnhandledEnumValueException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the unhandled enumeration value.
        /// </summary>
        public new T Value
        {
            get
            {
                return this.value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the unhandled enumeration value typed as <see cref="Enum"/>.
        /// </summary>
        /// <returns>
        /// The unhandled enumeration value typed as <see cref="Enum"/>.
        /// </returns>
        protected override sealed Enum GetValue()
        {
            return (dynamic)this.value;
        }

        #endregion
    }
}