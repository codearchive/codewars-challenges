using System;

namespace Exercise_3_CSharp
{
    public class Program
    {
        public static void Main()
        {
            string inputData = Console.ReadLine();
            if (inputData != null)
            {
                int currentPopultion = int.Parse(inputData.Split(' ')[0]);
                double percent = double.Parse(inputData.Split(' ')[1]);
                int aug = int.Parse(inputData.Split(' ')[2]);
                int expectedPopultion = int.Parse(inputData.Split(' ')[3]);

                Console.WriteLine($"nb_year({currentPopultion}, {percent}, {aug}, {expectedPopultion}) -> {Arge.NbYear(currentPopultion, percent, aug, expectedPopultion)}");
            }

        }
    }
}
