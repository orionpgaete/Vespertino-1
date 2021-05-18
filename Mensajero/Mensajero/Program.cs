using MensajeroModel;
using MensajeroModel.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajero
{
    class Program
    {
        private static IMensajeDAL mensajeDAL = MensajeDALArchivos.GetInstacia();
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("¿Que quiere hacer?");
            Console.WriteLine("1. Ingresar \n 2. Mostrar \n 0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1": Ingresar();
                    break;
                case "2": Mostrar();
                    break;
                case "0": continuar = false;
                    break;
                default: Console.WriteLine("Ingrese de nuevo");
                    break;
            }
            return continuar;
        }

        static void IniciarServidor()
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
        }
        static void Main(string[] args)
        {
            //1. Iniciar el Servidor Socket en el puerto 3000
            //2. el puerto tiene que ser configurable App.Config
            //3. cuando reciba un cliente, tiene que solicitar a ese cliente
            // el nombre y el texto, para agregar un nuevo mensaje con el tipo TCP

            while (Menu());
        }

        static void Ingresar()
        {
            Console.WriteLine("Ingrese nombre:");
            string nombre = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese texto:");
            string texto = Console.ReadLine().Trim();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "aplicacion"
            };
            mensajeDAL.AgregarMensaje(mensaje);
        }

        static void Mostrar()
        {
            List<Mensaje> mensajes = mensajeDAL.ObtenerMensajes();
            foreach (Mensaje mensaje in mensajes)
            {
                Console.WriteLine(mensaje);
            }

        }
    }    
}
