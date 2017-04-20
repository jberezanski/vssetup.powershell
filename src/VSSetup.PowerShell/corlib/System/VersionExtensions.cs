namespace System
{
    internal static class VersionExtensions
    {
        public static bool TryParse(string s, out Version v)
        {
            try
            {
                v = new Version(s);
            }
            catch
            {
                v = null;
            }

            return v != null;
        }
    }
}
