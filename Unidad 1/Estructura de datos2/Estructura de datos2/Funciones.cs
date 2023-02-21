using System;
using System.Diagnostics.CodeAnalysis;

namespace Program
{
    class matriz
    {
        static int sumar(int x, int y) {return x + y;}   
        static double sumar(double x, double y) { return x + y; } 
        static int sumar(int x, int y, int z) { return x + y + z;}
        static void Main(string[] args)
        {
            int x = 1;
            int y = 4;
            Console.WriteLine(sumar(x, y));
            Console.WriteLine(sumar(4.3, 5.4));
            Console.WriteLine(sumar (3, 6, 9));
            
            Console.ReadLine();
        }
    }
}