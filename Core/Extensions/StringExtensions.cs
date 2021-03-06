using System.Globalization;

namespace Core.Extensions
{
    public static class StringExtensions
    {
        public static string FirstCharToLowerCase( this string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsLower(str[0]))
                return str;
            return char.ToLower(str[0],new CultureInfo("en-US", false)) + str[1..];
        }
    }
}