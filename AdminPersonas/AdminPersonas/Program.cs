using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminPersonas
{
    public partial class Program
    {
      

        static void MostrarPersona()
        {
            List<Persona> personas = new PersonasDAL().ObtenerPersonas();
            for (int i=0; i < personas.Count(); i++)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0}: Nombre:{1} Peso:{2}", i, actual.Nombre, actual.Peso);

            }
        }

        static void BuscarPersona()
        {

        }


        static void IngresarPersona()
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;

            Console.WriteLine("Bienvenido, al programa del calculo IMC");

            //ctrl+k+d reordena el codigo

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

            Persona p = new Persona() 
                { 
                    Nombre = nombre,
                    Estatura = estatura,
                    Telefono = telefono,
                    Peso = peso
                };

            new List<Persona>() { new Persona() { }, new Persona() };


            //FORMA 1
            //p.Nombre = nombre;
            //p.Estatura = estatura;
            //p.Peso = peso;
            //p.Telefono = telefono;

            //FORMA 1
            new PersonasDAL().AgregarPersona(p);

            //FORMA 2
            //PersonasDAL pDAL = new PersonasDAL();
            //pDAL.AgregarPersona(p);


            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Telefono: {0}", p.Telefono);
            Console.WriteLine("Peso: {0}", p.Peso);
            Console.WriteLine("Estatura: {0}", p.Estatura);
            Console.WriteLine("IMC: {0}", peso / (estatura * estatura));
            Console.ReadKey();

        }
    }
}
