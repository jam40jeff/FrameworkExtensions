#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DelegateUtility.cs" company="MorseCode Software">
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
    using System.Reflection;

    /// <summary>
    /// Contains generically typed static methods to be used as replacements for use their counterparts in <see cref="System.Delegate"/>.
    /// </summary>
    public static class DelegateUtility
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a delegate of the specified type to represent the specified static method.
        /// </summary>
        /// <param name="method">The <see cref="T:System.Reflection.MethodInfo"/> describing the static or instance method the delegate is to represent. Only static methods are supported in the .NET Framework version 1.0 and 1.1.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type to represent the specified static method.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or- <paramref name="method"/> is not a static method, and the .NET Framework version is 1.0 or 1.1. -or-<paramref name="method"/> cannot be bound.-or-<paramref name="method"/> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(MethodInfo method) where T : class
        {
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), method);
            if (result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type to represent the specified static method, with the specified behavior on failure to bind.
        /// </summary>
        /// <param name="method">The <see cref="T:System.Reflection.MethodInfo"/> describing the static or instance method the delegate is to represent. Only static methods are supported in the .NET Framework version 1.0 and 1.1.</param>
        /// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method"/> cannot be bound; otherwise, false.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type to represent the specified static method.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or- <paramref name="method"/> cannot be bound, and <paramref name="throwOnBindFailure"/> is true.-or-<paramref name="method"/> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(MethodInfo method, bool throwOnBindFailure) where T : class
        {
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null || !throwOnBindFailure);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), method, throwOnBindFailure);
            if (throwOnBindFailure && result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null if throwOnBindFailure is true.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument.
        /// </summary>
        /// <param name="firstArgument">The object to which the delegate is bound, or null to treat <paramref name="method"/> as static (Shared in Visual Basic).</param>
        /// <param name="method">The <see cref="T:System.Reflection.MethodInfo"/> describing the static or instance method the delegate is to represent.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified static or instance method.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method"/> cannot be bound.-or-<paramref name="method"/> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(object firstArgument, MethodInfo method) where T : class
        {
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), firstArgument, method);
            if (result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance.
        /// </summary>
        /// <param name="target">The class instance on which <paramref name="method"/> is invoked.</param>
        /// <param name="method">The name of the instance method that the delegate is to represent.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> is null.-or- <paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>. -or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection.-or- <paramref name="method"/> is not an instance method. -or-<paramref name="method"/> cannot be bound, for example because it cannot be found.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(object target, string method) where T : class
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), target, method);
            if (result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified static method of the specified class.
        /// </summary>
        /// <param name="target">The type representing the class that implements <paramref name="method"/>.</param>
        /// <param name="method">The name of the static method that the delegate is to represent.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> is null.-or- <paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or- <typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target"/> is not a RuntimeType.-or-<paramref name="target"/> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters"/> property is true.-or-<paramref name="method"/> is not a static method (Shared method in Visual Basic). -or-<paramref name="method"/> cannot be bound, for example because it cannot be found</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(Type target, string method) where T : class
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), target, method);
            if (result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument and the specified behavior on failure to bind.
        /// </summary>
        /// <param name="firstArgument">An <see cref="object"/> that is the first argument of the method the delegate represents. For instance methods, it must be compatible with the instance type.</param>
        /// <param name="method">The <see cref="T:System.Reflection.MethodInfo"/> describing the static or instance method the delegate is to represent.</param>
        /// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method"/> cannot be bound; otherwise, false.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified static or instance method, or null if <paramref name="throwOnBindFailure"/> is false and the delegate cannot be bound to <paramref name="method"/>.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method"/> cannot be bound, and <paramref name="throwOnBindFailure"/> is true.-or-<paramref name="method"/> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(object firstArgument, MethodInfo method, bool throwOnBindFailure) where T : class
        {
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null || !throwOnBindFailure);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), firstArgument, method, throwOnBindFailure);
            if (throwOnBindFailure && result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null if throwOnBindFailure is true.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance with the specified case-sensitivity.
        /// </summary>
        /// <param name="target">The class instance on which <paramref name="method"/> is invoked.</param>
        /// <param name="method">The name of the instance method that the delegate is to represent.</param>
        /// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> is null.-or- <paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection.-or- <paramref name="method"/> is not an instance method. -or-<paramref name="method"/> cannot be bound, for example because it cannot be found.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(object target, string method, bool ignoreCase) where T : class
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase);
            if (result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity.
        /// </summary>
        /// <param name="target">The <see cref="T:System.Type"/> representing the class that implements <paramref name="method"/>.</param>
        /// <param name="method">The name of the static method that the delegate is to represent.</param>
        /// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> is null.-or- <paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or- <typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target"/> is not a RuntimeType.-or-<paramref name="target"/> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters"/> property is true.-or-<paramref name="method"/> is not a static method (Shared method in Visual Basic). -or-<paramref name="method"/> cannot be bound, for example because it cannot be found.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(Type target, string method, bool ignoreCase) where T : class
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase);
            if (result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance, with the specified case-sensitivity and the specified behavior on failure to bind.
        /// </summary>
        /// <param name="target">The class instance on which <paramref name="method"/> is invoked.</param>
        /// <param name="method">The name of the instance method that the delegate is to represent.</param>
        /// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
        /// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method"/> cannot be bound; otherwise, false.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> is null.-or- <paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or-<typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or-  <paramref name="method"/> is not an instance method. -or-<paramref name="method"/> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure"/> is true.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(object target, string method, bool ignoreCase, bool throwOnBindFailure) where T : class
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null || !throwOnBindFailure);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase, throwOnBindFailure);
            if (throwOnBindFailure && result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null if throwOnBindFailure is true.");
            }

            return result;
        }

        /// <summary>
        /// Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity and the specified behavior on failure to bind.
        /// </summary>
        /// <param name="target">The <see cref="T:System.Type"/> representing the class that implements <paramref name="method"/>.</param>
        /// <param name="method">The name of the static method that the delegate is to represent.</param>
        /// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
        /// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method"/> cannot be bound; otherwise, false.</param>
        /// <typeparam name="T">The type of delegate to create.</typeparam>
        /// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="target"/> is null.-or- <paramref name="method"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><typeparamref name="T"/> does not inherit <see cref="T:System.MulticastDelegate"/>.-or- <typeparamref name="T"/> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target"/> is not a RuntimeType.-or-<paramref name="target"/> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters"/> property is true.-or-<paramref name="method"/> is not a static method (Shared method in Visual Basic). -or-<paramref name="method"/> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure"/> is true.</exception>
        /// <exception cref="T:System.MissingMethodException">The Invoke method of <typeparamref name="T"/> is not found.</exception>
        /// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method"/>.</exception>
        public static T CreateDelegate<T>(Type target, string method, bool ignoreCase, bool throwOnBindFailure) where T : class
        {
            Contract.Requires<ArgumentNullException>(target != null, "target");
            Contract.Requires<ArgumentNullException>(method != null, "method");
            Contract.Ensures(Contract.Result<T>() != null || !throwOnBindFailure);

            T result = (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase, throwOnBindFailure);
            if (throwOnBindFailure && result == null)
            {
                throw new InvalidOperationException("Delegate.CreateDelegate should not return null if throwOnBindFailure is true.");
            }

            return result;
        }

        #endregion
    }
}