using System;
using System.Globalization;
using System.Numerics;

namespace proyecto
{
    class selectionmethod
    {
        static int origRow;
        static int origCol;
        static int[] array = new int[20];
        // - - - - - - - Cargar numeros - - - - - - - - 
        // Lee un .txt con numeros aleatorios para crear un array e imprimirlo
        static void CargarNum(int[] array)
        {
            string num;
            try
            {
                //StreamReader sr = new StreamReader("C:\\Users\\Jona_\\OneDrive\\Escritorio\\numeros.txt");
                StreamReader sr = new StreamReader("C:\\Users\\isai4470\\Desktop\\programacion\\Visual Studio Community\\Estructura-de-datos\\Unidad 2\\numeros.txt");
                num = sr.ReadLine();
                int i = 0;
                while (num != null)
                {
                    array[i] = Convert.ToInt32(num);
                    num = sr.ReadLine();
                    i++;
                }
                sr.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo abrir el archivo");

            }

        }

        // - - - - - - - M A I N - - - - - - - - 
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //int[] array = { 10, 5, 2, 8, 7, 6, 10, 2, 4, 8, 59, 69, 70, 83, 96, 29, 19, 34, 62, 44 };
            CargarNum(array);
            Console.Clear();
            valores();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;
            Impresion(array);
            Console.SetCursorPosition(0, 41);
            Console.Read();
            seleccion(array);
            Console.SetCursorPosition(0, 44);
            Console.WriteLine("fin."); Console.ReadLine();
        }

        // - - - - - - - - I M P R E S I O N - - - - - - - -
        static void Impresion(int[] array)
        {
            for (int i = 2; i <= 40; i = i + 2)
            {
                barra(array[(i - 2) / 2], i);
            }
        }

        // - - - - - - - S E L E C T I O N - - - - - - - - - - 
        // En esta funcion se ordenan los números y llama a las barras
        static void seleccion(int[] array)
        {
            int menor = 0;
            int pos = 0;
            int aux = 0;
            int contador = 0;
            int pasos = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                menor = array[i];
                pos = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < menor)
                    {
                        menor = array[j];
                        pos = j;
                    }
                    contador++;
                }
                if (pos != i)
                {
                    aux = array[i];
                    array[i] = array[pos];
                    array[pos] = aux;
                }
                pasos++;
                barra(array[i], i * 2 + 2);
                Console.SetCursorPosition(0, 41); Console.Read();
                barra(array[pos], pos * 2 + 2);
                Console.SetCursorPosition(0, 41); Console.Read();

            }
            Console.WriteLine("Se hicieron " + pasos + " pasadas");
            Console.WriteLine("Se hicieron " + contador + " comparaciones");
        }

        // - - - - - - - - B A R R A S - - - - - - - - - -
        // en esta funcion se representa el numero deseado en barras
        static void barra(int numero, int y)
        {
            int[] valor = new int[4] { 20, 10, 5, 1 };
            char cuadro = '█';
            int i = 0;
            int x = 1;
            int num = numero;
            borrar(y); // borra la barra en esa posicion
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
            Console.Write("   " + num);
        }
        static void borrar(int pos)
        {
            Console.SetCursorPosition(1, pos);
            Console.Write("                                    ");
        }
        static void valores()
        {
            char cuadro = '█';
            int x = 1;
            for (int j = 0; j < 4; j++)
            {
                Console.SetCursorPosition(x, 0);
                switch (j)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(cuadro + " = 20"); break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(cuadro + " = 10"); break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(cuadro + " = 5"); break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(cuadro + " = 1"); break;
                }
                x += 7;
            }
            Console.ResetColor();
        }
    }
}