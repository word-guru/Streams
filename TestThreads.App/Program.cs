using System;
using System.Threading;
using Numbers.Lib;

namespace TestThreads.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапозон простых чисел");

            Console.Write("Начало диапазона: ");
            int _start = int.Parse(Console.ReadLine());

            Console.Write("Конец диапазона: ");
            int _end = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите N чисел Фибоначчи:");
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Thread threadPrimeNum = new Thread(() => Numbers.Lib.Numbers.PrimeNum(_start, _end));
            threadPrimeNum.Start();

            Thread threadFibonachi = new Thread(() => Numbers.Lib.Numbers.Fibonachi(n));           
            threadFibonachi.Start();
           
            
        }
    }
}
