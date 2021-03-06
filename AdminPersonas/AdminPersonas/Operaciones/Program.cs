using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPersonas
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu()) ;
        }

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1": IngresarPersona();
                    break;
                case "2":
                    MostrarPersona();
                    break;
                case "3":
                    BuscarPersona();
                    break;
                case "0":
                    IngresarPersona();
                    break;
                default: Console.WriteLine("Selecciones una opcion");
                    break;  
            }
            return continuar;

        }
    }
}
