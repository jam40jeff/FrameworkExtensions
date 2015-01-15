using System;

namespace MorseCode.FrameworkExtensions
{
    public static class EnumExtensionMethods
    {
        public static T[] GetValues<T>()
        {
            return (T[])Enum.GetValues(typeof(T));
        }

        public static T Parse<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        public static T Parse<T>(string value, bool ignoreCase)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }

        public static T ToObject<T>(byte value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(int value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(long value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(object value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(sbyte value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(short value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(uint value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(ulong value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static T ToObject<T>(ushort value)
        {
            return (T)Enum.ToObject(typeof(T), value);
        }
    }
}