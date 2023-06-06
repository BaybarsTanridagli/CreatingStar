using System;

namespace CreatingStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Star");
            Console.WriteLine("Enter Value");
            int value = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < value; i++)
            {
                for (int k = value; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            for (int i = (value-1); i> 1; i--)
            {
                for (int k = value; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}

