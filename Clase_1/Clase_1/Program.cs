using System;


namespace Clase_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("Ingrese nombre:");
            string nombre = Console.ReadLine().Trim();
            //"    hola " .TrimStart(); hola "
            //"  hola    " .TrimEnd();
            //Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Ingrese la edad: ");
            string edadTx = Console.ReadLine();
            int edad = -1;
            bool esValido = Int32.TryParse(edadTx, out edad);

            if(!esValido)
                {
                    Console.WriteLine("Ingrese bien la edad");
                }
            else
                {
                    Console.WriteLine("Su nomnbre es: {0} y la que tiene es: {1}", nombre, edadTx);
                }
            
            Console.ReadKey();
        }
    }
}

