using ServidorSocketUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSocket
{
    class Program
    {
       
        //Inicia una conversacion con un cliente hasta que algun extremo
        //de la comunicacion se despida, con un chaooo

        //en mi caso hare un metodo generar comunicacion, osea toda comunicacion del cliente pasara por el metodo.
        static void GenerarComunicacion(ClienteCom clienteCom)
        {
            bool terminar = false;
            while (!terminar)
            {
                string mensaje = clienteCom.Leer();
                if (mensaje != null)
                {
                    Console.WriteLine("Cliente : {0}", mensaje);
                    if (mensaje.ToLower() == "chao")
                    {
                        terminar = true;
                    }
                    else
                    {
                        Console.Write("Ingrese respuesta: ");
                        mensaje = Console.ReadLine().Trim();
                        clienteCom.Escribir(mensaje);
                        if(mensaje.ToLower () == "chao")
                        {
                            terminar = true;
                        }
                    }
                }else
                {
                    clienteCom.Desconectar();
                }
            }
        }
        static void Main(string[] args)
        {
            int puerto = Convert.ToInt32(ConfigurationManager.AppSettings["puerto"]);
            Console.WriteLine("Levantando servidor en puerto {0}", puerto);
            ServerSocket serverSocket = new ServerSocket(puerto);

            if (serverSocket.Iniciar())
            {
                while (true)
                {
                    //luego de iniciar el servidor queda esperando....
                    Console.WriteLine("Esperando clientes...");
                    Socket socket = serverSocket.ObtenerCliente();
                    Console.WriteLine("Cliente recibido");
                    // comunicarse con el cliente
                    ClienteCom clienteCom = new ClienteCom(socket);
                    GenerarComunicacion(clienteCom);
                }
            }
            else
            {
                Console.WriteLine("Error al tomar posesion del puerto{0}", puerto);
            }

        }
  
     }
}
