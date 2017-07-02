namespace ThuctapCSDL
{
    public static class ExtensionMethods
    {
        public static bool IsNumber(this string s)
        {
            double i = 0;
            return double.TryParse(s, out i);
        }
    }
}
