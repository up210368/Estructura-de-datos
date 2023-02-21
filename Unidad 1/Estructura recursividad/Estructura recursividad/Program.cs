using System;

namespace estructura
{
    class recursividad
    {
        static int factor;
        static void Main()
        {
            Console.WriteLine("Input your number.");
            int n = int.Parse(Console.ReadLine()); // n = convert.Toint32(Console.ReadLine());
            int factor = factorial(n);
            Console.WriteLine("El factorial de "+n+" es igual a "+factor);
        }
        static int factorial(int n)
        {
            if (n > 0) 
            {
                return n*factorial(n-1);
            }
            else
            {
                return 1;
            }
        }
    }
}
