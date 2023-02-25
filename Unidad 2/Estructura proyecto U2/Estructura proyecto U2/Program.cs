using System;
using System.Globalization;
using System.Numerics;

namespace proyecto
{
    class selectionmethod
    {
        static void Main()
        {
            int numero = 99;
            int posicion = 0;
            Console.WriteLine("█");
            //barra(numero, posicion);
        }
        static void barra(int numero, int posicion)
        {
            int[] valor = new int[4] { 20, 10, 5, 1 };
            char[] cuadro = new char[4] { '█', '▓', '▒', '░' };
            int i = 0;
            do
            {
                if (numero >= valor[i])
                {
                    for (int j=0; j < (numero / valor[i]);j++)
                    {
                        Console.Write(cuadro[i]);
                    }
                    numero = numero % valor[i];
                }
                i++;
            } while (numero != 0);
        }
    }
}


/* programa que use el metodo de seleccion
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
            Console.ReadLine();*/