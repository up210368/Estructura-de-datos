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
            int x = 2;
            int y = 1;
            barra(numero, x, y);
            Console.ReadLine();
            barra(25, x, y+2);
            Console.ReadLine();
            barra(36, x, y+4);
            Console.ReadLine();
            barra(47, x, y+6);
            Console.ReadLine();
            barra(79, x, y+8);
            Console.ReadLine();
            barra(69, x, y+8);
            Console.SetCursorPosition(0, 25);
        }
        static void barra(int numero, int x, int y)
        {
            int[] valor = new int[4] { 20, 10, 5, 1 };
            char cuadro = '█';
            int i = 0;
            borrar(x, y); // borra la barra en esa posicion
            do
            {
                if (numero >= valor[i])
                {
                    for (int j = 0; j < (numero / valor[i]); j++)
                    {
                        Console.SetCursorPosition(x, y);
                        switch (i) //asigna un color a cada posicion del array
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(cuadro); break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(cuadro); break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(cuadro); break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(cuadro); break;
                        }
                        x += 2;
                    }
                    numero = numero % valor[i];
                }
                i++;
            } while (numero != 0);
            Console.ResetColor();
        }
        static void borrar(int x,int y)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                x += 2;
            }
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