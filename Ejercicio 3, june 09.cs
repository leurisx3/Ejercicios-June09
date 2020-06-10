using System;

namespace Ejercicio_3__june_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determina si es signo de puntuacion

            string dato;
            char tecla;           

            Console.Write("Introduzca un signo de puntuacion: ");
            dato = Console.ReadLine();
            tecla = Convert.ToChar(dato);

            var resultado = Char.IsPunctuation(tecla);
            
            if (resultado == true)
            {
                Console.WriteLine("Si es un signo de puntuacion");
            }
            else
            {
                Console.WriteLine("No es un signo de puntuacion");
            }

            //Determine si es un numero
            
            char num;

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

            //Si es otro caracter. En este caso una letra.

            char letra;

            Console.Write("Escriba una letra: ");
            dato = Console.ReadLine();
            letra = Convert.ToChar(dato);

            var result2 = Char.IsLetter(letra);

            if (result == true)
            {
                Console.WriteLine("Si es una letra");
            }
            else
            {
                Console.WriteLine("No es una letra");
            }
        }   
    }
}
