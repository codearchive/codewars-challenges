using System;

namespace Exercise_1_CSharp
{
    public class Exercise_1
    {
        public static void Main()
        {
            Console.WriteLine(Remove_char("#Hello#"));
        }

        public static string Remove_char(string s)
        {
            char[] tempString = new char[s.Length-2];
            s.CopyTo(1, tempString, 0, s.Length - 2);
            return new string(tempString);
        }
    }
}
