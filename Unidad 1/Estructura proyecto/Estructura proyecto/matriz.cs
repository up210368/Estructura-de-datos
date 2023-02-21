using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Memorama
{
    class Matriz
    {
        static void tablero(int[,] matriz) // imprime tablero
        {
            char cuadro = '#';
            int a = 0;
            int b = 0;
            Console.WriteLine("Encuentra la pareja que sume 29\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Thread.Sleep(200);
                    if (i == 0 && a <= 6) { Console.Write("   " + a++); }
                    if (j == 0 && b <= 3 && i > 0) { Console.Write(b++ + "  "); }
                    if (i > 0 && j > 0) { Console.Write(cuadro + "   "); }
                }
                Console.WriteLine();
            }
        }
        // Función para destapar casilla
        static int casilla(int x, int y, int[,] matriz, int c, int d)
        {
            char cuadro = '#';
            int a = 0;
            int b = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //Thread.Sleep(200);
                    bool f = false;
                    if (i == 0 && a <= 6) { Console.Write("\t" + a++); }
                    if (j == 0 && b <= 3 && i > 0) { Console.Write(b++ + "\t"); }
                    if (i > 0 && j > 0) 
                    { 
                        if (i-1==y && j-1==x)
                        {
                            Console.Write(matriz[y, x] + "\t");
                            f = true;
                        }
                        if (i - 1 == d && j - 1 == c)
                        {
                            Console.Write(matriz[d, c] + "\t");
                            f = true;
                        }
                        if (f==false) { Console.Write(cuadro + "\t"); } 
                    }
                }
                Console.WriteLine();
            }
            continuar();
            return (matriz[y,x] + matriz[d,c]);
        }
        static void Main(string[] args)
        {
            var (Matriz, MatrizG) = Llenarmatriz();
            int w = 0;
            do
            {
                if (w == 0) { printrmatrizg(MatrizG); }
                Console.WriteLine("ingresa posicion de la primer casilla.");
                var (x, y) = jugada();
                Console.WriteLine("ingresa la posicion de la segunda casilla.");
                var (c, d) = jugada();
                System.Console.Clear();
                int twenty9 = casilla(x, y, Matriz, c, d);
                if (twenty9==29)
                {
                    Console.WriteLine("Encontraste el par");
                    w++;
                }
                else { System.Console.Clear(); }
                if (w==14) { Console.WriteLine("Ganaste"); continuar(); }
            } while (w != 14);
            //Imprimirmatriz(Matriz);
            System.Console.SetCursorPosition(0, 19);
        }
        static (int, int) jugada()
        {
            int x, y = 0;
            Console.WriteLine("Ingresa la posicion en x.");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion en y.");
            y = int.Parse(Console.ReadLine());
            return (x, y);
        }
        static (int[,], string[,]) Llenarmatriz()
        {
            Random random = new();
            int[,] matriz = new int[4, 7];
            string[,] matrizG = new string[4, 7];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    int numero = random.Next(1, 29);
                    while (comparar(matriz, numero) == false)
                    {
                        numero = random.Next(1, 29);
                    }
                    matriz[i, j] = numero;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrizG[i, j] = "#";
                }
            }
            return (matriz, matrizG);
        }
        static bool comparar(int[,] com, int parar)
        {
            Random random = new();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (com[i, j] == parar)
                    { return false; }
                }
            }
            return true;
        }
        static void continuar()
        {
            Console.WriteLine("Pulsa enter para continuar..."); Console.ReadLine();
            //System.Console.Clear();
        }
        static void Imprimirmatriz(int[,] imprimir)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(imprimir[i, j] + "  |  ");
                }
                Console.WriteLine();
            }
        }
        static void printrmatrizg(string[,] imprimir)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Thread.Sleep(200);
                    if (i == 0 && a <= 6) { Console.Write("\t" + a++); }
                    if (j == 0 && b <= 3 && i > 0) { Console.Write(b++ + "\t"); }
                    if (i > 0 && j > 0) { Console.Write(imprimir[i-1, j-1] + "\t"); }
                }
                Console.WriteLine();
            }
        }
    }
}