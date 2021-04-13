﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace HolaSocket.Comunicacion
{
    public class ClienteCom
    {
        private Socket cliente;
        private StreamReader reader;
        private StreamWriter writer;

        public ClienteCom(Socket socket)
        {
            this.cliente = socket;
            Stream stream = new NetworkStream(this.cliente);
            this.reader = new StreamReader(stream);
        }

        public bool Escribir(string mensaje)
        {
            try
            {
                this.writer.WriteLine(mensaje);
                this.writer.Flush();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public String Leer()
        {
            try
            {
                return this.reader.ReadLine().Trim();
            }catch(Exception ex)
            {
                return null;
            }
        }
        public void Desconectar()
        {
            try
            {
                this.cliente.Close();
            }catch(Exception ex)
            {

            }
        }


    }
}
