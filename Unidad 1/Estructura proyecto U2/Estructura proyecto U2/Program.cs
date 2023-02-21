using System;
using System.Globalization;
using System.Numerics;

namespace proyecto
{
    class mayormenor
    {
        static void Main()
        {
            // programa que use el metodo de la burbuja
            int count = 0;
            int[] array = { 3, 10, 6, 9, 8, 1, 7, 5, 4, 2};
            for (int i=0; i<9; i++)
                for (int j = 0; j < 9-i; j++)
                {
                    if (array[j] <= array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    count++;
                }
            Console.ReadLine();
        }
    }
}
