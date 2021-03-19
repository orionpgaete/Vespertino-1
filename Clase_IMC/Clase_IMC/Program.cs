using System;

namespace Clase_IMC
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;

            Console.WriteLine("Bienvenido, al programa del calculo IMC");

            do
            {
                Console.WriteLine("Ingrese Nombre");
                nombre = Console.ReadLine().Trim();
            } //while (nombre.Equals(""));
              while (nombre == string.Empty);

            bool esValido;

            do
            {
                Console.WriteLine("Ingrese telefono");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese peso");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese estatura");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);
            } while (!esValido);


            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Telefono: {0}", telefono);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("Estatura: {0}", estatura);
            Console.WriteLine("IMC: {0}", peso/(estatura*estatura));
            Console.ReadKey();







        }
    }
}
