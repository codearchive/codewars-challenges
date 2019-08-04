using System;

namespace Exercise_2_CSharp
{
    public class Exercise_2
    {
        public static void Main(string[] args)
        {
            bool[] inputArray = {true, true, true, false,
                                true, true, true, true,
                                true, false, true, false,
                                true, false, false, true,
                                true, true, true, true,
                                false, false, true, true};

            Console.WriteLine(CountSheeps(inputArray));
        }

        public static int CountSheeps(bool[] sheeps)
        {
            int counter = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i]) counter++;
            }

            return counter;
        }
    }
}
