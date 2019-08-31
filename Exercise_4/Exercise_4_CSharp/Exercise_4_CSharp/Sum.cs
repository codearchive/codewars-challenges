namespace Exercise_4_CSharp
{
    public class Sum
    {
        public static int GetSum(int a, int b)
        {
            int sum = 0;
            int end = 0;
            int start = 0;

            if (a == b) return a;
            
            if (a < b)
            {
                start = a;
                end = b;
            }
            else
            {
                start = b;
                end = a;
            }

            for (int i = start; i <= end; ++i)
            {
                sum += i;
            }
            
            return sum;
        }
    }
}
