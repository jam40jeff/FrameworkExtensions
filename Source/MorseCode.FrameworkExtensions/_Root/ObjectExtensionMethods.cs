namespace MorseCode.FrameworkExtensions
{
    public static class ObjectExtensionMethods
    {
        public static string SafeToString(this object o)
        {
            return o == null ? null : o.ToString();
        }
    }
}