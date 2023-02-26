using System;
namespace random
{
    class numbers
    {
        static void Main(String[] args)
        {
            // random numbers guess game without hints
            Random x = new Random(); //crea una variable que muestre un numero aleatorio
            int random = x.Next(1, 11);// crear numero aleatorio
            int user;
            int trys = 6;
            do
            {
                trys--;
                Console.WriteLine("Dame un numero del 1 al 10\tTienes " + trys + " intentos.");
                user = int.Parse(Console.ReadLine());
                if (random != user && trys != 1) //el numero ingresado no es el aleatorio
                {
                    Console.WriteLine("Ingresa otro numero, no son el mismo numero");
                }
                if (random == user) { Console.WriteLine("Le atinaste al numero aleatorio =)"); }
                if (trys == 1) //No le atino al numero, todo tonto jaja
                {
                    user = random; Console.WriteLine("Perdiste =(\nEl numero era " + random);
                }
            } while (random != user) ;
            // random numbers guess game with hints
            int aleatorio = x.Next(1, 11);// crear numero aleatorio
            int usuario;
            int intentos = 6;
            do
            {
                intentos--;
                Console.WriteLine("Dame un numero del 1 al 10\tTienes " + intentos + " intentos.");
                usuario = int.Parse(Console.ReadLine());
                if (aleatorio != usuario && intentos != 1) //el numero ingresado no es el aleatorio
                {
                    Console.WriteLine("Ingresa otro numero, no son el mismo numero");
                    if (usuario > aleatorio) { Console.WriteLine("Ingresa un numero mas chico."); }
                    if (usuario < aleatorio) { Console.WriteLine("Ingresa un numero mas grande."); }
                }
                if (intentos == 1) //No le atino al numero, todo tonto jaja
                {
                    usuario = aleatorio; Console.WriteLine("Perdiste =(\nEl numero era " + aleatorio);
                }
            } while (aleatorio != usuario);
            Console.WriteLine("Le atinaste al numero aleatorio =)");
        }
    }
}
