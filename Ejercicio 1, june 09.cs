using System;

namespace Ejercicio_1__june_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int num = 0;

            Console.Write("Introduzca un numero: ");
            dato = Console.ReadLine();
            num = Convert.ToInt32(dato);

            if(num > 0)
            {
                Console.WriteLine("El numero es: " + num);
            }
            else
            {
                num = num * -1;
                Console.WriteLine("El numero era negativo y se transformo: " + num);
            }

        }
    }
}
