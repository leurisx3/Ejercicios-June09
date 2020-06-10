using System;
using System.Runtime.InteropServices;

namespace Ejercicio_2__june_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int num1 = 0;
            int num2 = 0;

            Console.Write("Introduzca un numero: ");
            dato = Console.ReadLine();
            num1 = Convert.ToInt32(dato);

            Console.Write("Introduzca segundo numero: ");
            dato = Console.ReadLine();
            num2 = Convert.ToInt32(dato);

            if (num1 > num2)
            {
                Console.WriteLine("El numero menor es: " + num2);
            }
            if(num2 > num1)
            {
                Console.WriteLine("El numero menor es: " + num1);
            }
        }
    }
}
