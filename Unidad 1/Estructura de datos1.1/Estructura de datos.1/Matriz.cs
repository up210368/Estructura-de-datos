using System;
using System.Globalization;

namespace clase3
{
    class program
    {
        static void Main(string[] args)
        {
            // filling a matrix with fixed values
            int[,] matriz = new int[2, 4] { {10, 20, 30, 40}, {50, 60, 70, 80} };
            for (int i = 0; i<2; i++) 
            {
                for(int j=0; j<4; j++) 
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            // filling a matrix with user data
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Escribe un numero a ingresar.");
                    int num = int.Parse(Console.ReadLine());
                    matriz[i, j] = num;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
