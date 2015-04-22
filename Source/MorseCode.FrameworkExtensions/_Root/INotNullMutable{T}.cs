#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotNull{T}.cs" company="MorseCode Software">
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
    using System.Diagnostics.Contracts;

    /// <summary>
    /// An interface representing a mutable object which contains a value which may not be <code>null</code>.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value.
    /// </typeparam>
    /// <remarks>
    /// This interface is implemented internally and should not be implemented by any other class outside of this assembly.
    /// To obtain an <see cref="INotNullMutable{T}"/> instance, either use the <see cref="NotNullMonad.ToNotNullMutable{T}"/> extension method,
    /// or use the <see cref="NotNull.CreateMutable{T}"/> factory method.
    /// </remarks>
    [ContractClass(typeof(NotNullMutableInterfaceContract<>))]
    public interface INotNullMutable<T> : INotNull<T>
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the mutable object's value.
        /// </summary>
        /// <remarks>The value retrieved will not be <code>null</code>.  The value set must not be <code>null</code>.</remarks>
        new T Value { get; set; }

        #endregion
    }
}