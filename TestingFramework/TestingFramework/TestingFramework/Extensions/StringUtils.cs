using System;

namespace TestingFramework.Extensions
{
    public static class StringUtils
    {
        public static string MakeRandomString(int stringLength)
        {
            Random rndGen = new Random();
            string symbols = "qwertyuiopasdfghjklzxcvbnm0123456789";
            char[] letters = symbols.ToCharArray();
            string s = "";
            for (int i = 0; i < stringLength; i++)
            {
                s += letters[rndGen.Next(letters.Length)].ToString();
            }
            return s;
        }
    }
}
