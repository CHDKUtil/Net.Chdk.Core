namespace Net.Chdk
{
    public static class StringExtensions
    {
        public static string TrimStart(this string str, string prefix)
        {
            if (!str.StartsWith(prefix))
                return null;
            return str.Substring(prefix.Length);
        }
    }
}
