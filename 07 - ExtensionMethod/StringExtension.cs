namespace _07___ExtensionMethod
{
    public static class StringExtension
    {
        public static string FirstToUpper(this string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}
