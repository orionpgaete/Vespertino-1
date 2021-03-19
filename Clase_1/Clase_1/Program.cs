using System;


namespace Clase_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("Ingrese nombre:");
            string nombre = Console.ReadLine();
            //Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su nomnbre es: {0} {1}", nombre, 2021);
            Console.ReadKey();
        }
    }
}

