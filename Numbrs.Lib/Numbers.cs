using System;

namespace Numbers.Lib
{
    public static class Numbers
    {
        private static bool IsSimple(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void PrimeNum(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (IsSimple(i))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}, ");
                    Console.ResetColor();
                }
            }
        }

        public static void Fibonachi(int n)
        {
            uint[] temp = new uint[] { 1, 1 };

            for (int i = 2; i <= n; i++)
            {
                temp[i % 2] = temp[0] + temp[1];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{temp[i % 2]}  ");
                Console.ResetColor();
            }
        }
    }
}
