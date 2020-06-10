using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DETERMINE SI ES UN VOCAL

            string vowel = "";

            Console.Write("Escriba una vocal: ");
            vowel = Console.ReadLine();

            if (vowel == "a" || vowel == "e" || vowel == "i" || vowel == "o" || vowel == "u")
            {
                Console.WriteLine("Si es una vocal");
            }
            else
            {
                Console.WriteLine("No es una vocal");
            }

            //DETERMIE SI ES UN NUMERO

            char num;
            string dato;

            Console.Write("Escriba un numero: ");
            dato = Console.ReadLine();
            num = Convert.ToChar(dato);

            var result = Char.IsNumber(num);

            if (result == true)
            {
                Console.WriteLine("Si es un numero");
            }
            else
            {
                Console.WriteLine("No es un nuemero");
            }

            //DETERMINE SI ES UNA CONSTANTE

            const double pi = 3.14;
            double pi2;

            Console.Write("Escriba el valor de pi: ");
            dato = Console.ReadLine();
            pi2 = Convert.ToDouble(dato);

            if (pi2 == 3.14)
            {
                Console.WriteLine("Si es una constante");
            }
            else
            {
                Console.WriteLine("No es una constante");
            }

        }    
    }
}
