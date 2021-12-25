namespace Extensions
{
    public static class Extensions
    {
        public static string Remove(this string str, params string[] values)
        {
            values.ToList().ForEach(v => str = str.Replace(v, string.Empty));
            return str;
        }
    }
}