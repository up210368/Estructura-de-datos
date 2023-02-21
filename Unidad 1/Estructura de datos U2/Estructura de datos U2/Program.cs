using System;
using System.IO;
namespace Dividirstring
{
    class Separarstr
    {
        static void Main(string[] args)
        {
            // vamos a usar una forma de apertura de archivos que se van a leer renglon por renglon
            // hata que el archivo ya no contenga mas renglones
            //usaremos csv files y ruta mas facil para encontrarla
            // C: 
            string linea = "";
            try
            {
                // Pass the file path and file name to the streamreader constructor
                StreamWriter sr = new StreamWriter("C:\\Users\\Jona_\\OneDrive\\Escritorio\\isaitonto\\Prueva.csv");
                // continue to read until you reach end of file
                while (leer != null) 
                {
                    linea = sr.WriteLine(); // read the next line
                }
                sr.Close(); // close the file
            }
            finally
            {
                Console.WriteLine("archivo creado");
            }
            // escribir textos archivos de texto plano CSV o TXT. Crear o reemplazar archivos
            Console.ReadLine();
        }
        static bool leer()
        {
            try
            {
                string linea;
                using (StreamReader reader = new StreamReader("C:\\Users\\Jona_\\OneDrive\\Escritorio\\isaitonto\\Alumnos.txt"))
                {
                    linea = reader.ReadLine();
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
/*Console.WriteLine("Dame un texto que cumpla con la forma");
            Console.WriteLine("Jorge,Isai,Lopez,Hernandez,20,Aguascalientes,Macho,No disponible");
            string texto = Console.ReadLine();
            string[] textoseparado = texto.Split(',');
            Console.WriteLine("");
            Console.WriteLine("La separacion de variables es");
            foreach (string palabra in textoseparado) 
            {
                Console.WriteLine(palabra);
            }
            foreach (string s in textoseparado)
            {
                try
                {
                    int numero = Convert.ToInt32(s);
                    Console.WriteLine("La variable es numerica");
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                finally
                {
                    Console.WriteLine("Fin.");
                }
            }*/