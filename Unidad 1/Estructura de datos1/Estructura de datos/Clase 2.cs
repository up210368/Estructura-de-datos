using System;
namespace clase2
{
    class operaciones
    {
        static void Main(string[] args)
        {
            int x = 5; // = 0101
            double c = 33;
            int y = 2;
            x <<= 3; // agrega 0´s al lado contrario del bit = 0010 1000b = 40d
            Console.WriteLine("█");
            Console.WriteLine(x);
            Console.WriteLine(y == x); // equal to
            Console.WriteLine(Math.Max(x, y)); // mayor numero entre ""
            c = Math.Sqrt(c);// raiz cuadrada de c
            c = Math.Round(c);//redondeo; si es < de .5, va hacia el valor anterior y si es >, al siguiente
            Console.WriteLine(c);
            string txt = "Hola";
            string ja = "jaja";
            Console.WriteLine(txt.ToUpper()); 
            String saludo = $"Hey bro, {txt} {ja}"; // las llaves concatenan txt con variables str.
            Console.WriteLine(saludo);
            Console.WriteLine(txt[1]);// imprime el valor de la posicion [n]


            Console.ReadLine();
        }
    }
}