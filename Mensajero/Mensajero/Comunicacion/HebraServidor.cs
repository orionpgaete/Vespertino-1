using MensajeroModel;
using MensajeroModel.DAL;
using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mensajero.Comunicacion
{
    public class HebraServidor
    {
        private static IMensajeDAL mensajeDAL = MensajeDALArchivos.GetInstacia();
        public void Ejecutar()
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            ServerSocket servidor = new ServerSocket(puerto);
            Console.WriteLine("Iniciando servidor en puerto {0}", puerto);
            if (servidor.Iniciar())
            {
                while (true)
                {
                    Console.WriteLine("Esperando a Cliente...");
                    Socket cliente = servidor.ObtenerCliente();
                    Console.WriteLine("Cliente recibido");

                    ClienteCom clienteCom = new ClienteCom(cliente);

                    HebraCliente clienteThread = new HebraCliente(clienteCom);
                    Thread t = new Thread(new ThreadStart(clienteThread.Ejecutar));
                    t.IsBackground = true;
                    t.Start();

                }
            }
            else
            {
                Console.WriteLine("Error, no se puede iniciar Servidor en puerto {0}", puerto);
            }
        }
    }
}
