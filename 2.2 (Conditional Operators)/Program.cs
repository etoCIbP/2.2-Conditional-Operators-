using System;

namespace _2._2__Conditional_Operators_
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2.2 Условные операторы 
            Console.WriteLine("Введите двухзначное число n: ");
            int n = int.Parse(Console.ReadLine());
            int a = 3;
            int b = 7;
            for (int i = 0; i < n; i++)
            {
                a = n / 10; b = n % 10;
                if (a == 3 || a == 7 || b == 3 || b == 7)

                {
                    Console.WriteLine("Число содержит 3 или 7");
                }
                else
                {
                    Console.WriteLine("Число не содержит 3 или 7");
                }
                break;
            }
        }
    }
}
