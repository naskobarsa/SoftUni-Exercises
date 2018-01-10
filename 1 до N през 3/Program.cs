using System;

namespace _1_до_N_през_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i+=3)
            {
                Console.WriteLine(i);
            }
           
        }
    }
}
