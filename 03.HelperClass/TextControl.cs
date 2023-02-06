namespace _03.HelperClass
{
    public static class TextControl
    {
        public static bool Control(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                if (!string.IsNullOrEmpty(strings[i + 1]))
                {
                    if (strings[0] != null)
                    {
                        return true;
                    }
                    return false;
                }
                else
                    break;
            }
            return false;
        }
    }
}
