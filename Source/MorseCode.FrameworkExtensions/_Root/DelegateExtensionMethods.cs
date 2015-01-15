using System;
using System.Reflection;

namespace MorseCode.FrameworkExtensions
{
    public static class DelegateExtensionMethods
    {
        public static T CreateDelegate<T>(MethodInfo method)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), method);
        }

        public static T CreateDelegate<T>(MethodInfo method, bool throwOnBindFailure)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), method, throwOnBindFailure);
        }

        public static T CreateDelegate<T>(object firstArgument, MethodInfo method)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), firstArgument, method);
        }

        public static T CreateDelegate<T>(object target, string method)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method);
        }

        public static T CreateDelegate<T>(Type target, string method)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method);
        }

        public static T CreateDelegate<T>(object firstArgument, MethodInfo method, bool throwOnBindFailure)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), firstArgument, method, throwOnBindFailure);
        }

        public static T CreateDelegate<T>(object target, string method, bool ignoreCase)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase);
        }

        public static T CreateDelegate<T>(Type target, string method, bool ignoreCase)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase);
        }

        public static T CreateDelegate<T>(object target, string method, bool ignoreCase, bool throwOnBindFailure)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase, throwOnBindFailure);
        }

        public static T CreateDelegate<T>(Type target, string method, bool ignoreCase, bool throwOnBindFailure)
        {
            return (T)(object)Delegate.CreateDelegate(typeof(T), target, method, ignoreCase, throwOnBindFailure);
        }
    }
}