using System;
namespace random
{
    class numbers
    {
        static void Main(String[] args) 
        {
            Random x = new Random(); //crea una variable que muestre un numero aleatorio
            /*for(int i=0; i<6; i++) 
            {
                //int aleatorio = x.Next(); numero aleatorio sin rango
                int aleatorio = x.Next(50, 100);
                Console.WriteLine("Numero aleatorio "+ aleatorio);
            }*/
            int aleatorio = x.Next(1, 11);// crear numero aleatorio
            // pedirle al usuario un numero
            int usuario;
            int intentos = 6;
            do
            {
                intentos--;
                Console.WriteLine("Dame un numero del 1 al 10\tTienes "+intentos+ " intentos.");
                usuario=int.Parse(Console.ReadLine());
                if(aleatorio!=usuario && intentos!=1) //el numero ingresado no es el aleatorio
                {
                    Console.WriteLine("Ingresa otro numero, no son el mismo numero");
                    if(usuario>aleatorio)
                    {
                        Console.WriteLine("Ingresa un numero mas chico.");
                    }
                    if (usuario<aleatorio)
                    { Console.WriteLine("Ingresa un numero mas grande."); }
                }
                if (intentos == 1) //No le atino al numero, todo tonto jaja
                {
                    usuario = aleatorio;
                    Console.WriteLine("Perdiste =(\nEl numero era " + aleatorio);
                }
            } while (aleatorio != usuario);
            Console.WriteLine("Le atinaste al numero aleatorio =)");
        }
    }
}
