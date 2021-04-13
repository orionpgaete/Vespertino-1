using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HolaSocket.Comunicacion
{
    public class ServerSocket
    {
        private int puerto;
        private Socket servidor;
        public ServerSocket(int puerto)
        {
            this.puerto = puerto;

           
        }
        //iniciar la conexion del servidor, tomando posesion del puerto
        public bool Iniciar()
        {
            try
            {
                this.servidor = new Socket(AddressFamily.InterNetwork, 
                                           SocketType.Stream, ProtocolType.Tcp);
                //tomar posesion del puerto
                this.servidor.Bind(new IPEndPoint(IPAddress.Any, this.puerto));
                //definir cola de espera
                this.servidor.Listen(10);
                return true;
            }catch(SocketException ex)
            {
                return false;
            }
        }
        public Socket ObtenerCliente()
        {
            return this.servidor.Accept();
        }
        public void Cerrar()
        {
            try
            {
                this.servidor.Close();
            }catch(Exception ex)
            {

            }
        }
    }
}
