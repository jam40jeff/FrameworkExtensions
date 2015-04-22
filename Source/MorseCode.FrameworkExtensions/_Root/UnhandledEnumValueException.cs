#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnhandledEnumValueException.cs" company="MorseCode Software">
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
    using System.Diagnostics.Contracts;
    using System.Runtime.Serialization;

    /// <summary>
    /// The exception that is thrown when an unhandled enumeration value is encountered.
    /// </summary>
    /// <remarks>
    /// The intended usage for this exception is to throw it in the default block of a switch statement on an enumeration value
    /// meant to handle all possible values of the enumeration.
    /// </remarks>
    [SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", Justification = "Implemented by base class.")]
    [Serializable]
    public class UnhandledEnumValueException : Exception
    {
        #region Fields

        private readonly Type type;

        private readonly Enum value;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException"/> class with a specified message, enumeration type, and unhandled enumeration value.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="type">
        /// The type of the enumeration.
        /// </param>
        /// <param name="value">
        /// The unhandled enumeration value.
        /// </param>
        public UnhandledEnumValueException(string message, Type type, Enum value)
            : this(message)
        {
            this.type = type;
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException"/> class.
        /// </summary>
        public UnhandledEnumValueException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public UnhandledEnumValueException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
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
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException"/> class with a specified message and enumeration type.
        /// </summary>
        /// <param name="message">
        /// The error message that explains the reason for the exception.
        /// </param>
        /// <param name="type">
        /// The type of the enumeration.
        /// </param>
        protected UnhandledEnumValueException(string message, Type type)
            : this(message)
        {
            this.type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledEnumValueException"/> class with serialized data.
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
        /// Gets the enumeration type.
        /// </summary>
        public Type Type
        {
            get
            {
                return this.type;
            }
        }

        /// <summary>
        /// Gets the unhandled enumeration value.
        /// </summary>
        public Enum Value
        {
            get
            {
                return this.GetValue();
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Creates an unhandled enumeration value exception.
        /// </summary>
        /// <param name="value">
        /// The unhandled enumeration value.
        /// </param>
        /// <typeparam name="T">
        /// The type of the enumeration.
        /// </typeparam>
        /// <returns>
        /// An <see cref="UnhandledEnumValueException{T}"/> initialized with <paramref name="value"/>.
        /// </returns>
        public static UnhandledEnumValueException<T> Create<T>(T value) where T : struct, IComparable, IFormattable, IConvertible
        {
            Contract.Requires<InvalidOperationException>(typeof(T).IsEnum, "Type T must be an enum.");
            Contract.Ensures(Contract.Result<UnhandledEnumValueException<T>>() != null);

            return new UnhandledEnumValueException<T>("An unhandled enum value \"" + value + "\" was encountered for enum type " + value.GetType().FullName + ".", value);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the unhandled enumeration value typed as <see cref="Enum"/>.
        /// </summary>
        /// <returns>
        /// The unhandled enumeration value typed as <see cref="Enum"/>.
        /// </returns>
        protected virtual Enum GetValue()
        {
            return this.value;
        }

        #endregion
    }
}