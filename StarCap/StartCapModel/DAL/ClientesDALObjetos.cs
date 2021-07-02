﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarCapModel.DAL
{
    public class ClientesDALObjetos : IClientesDAL
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public void Agregar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void Eliminar(string rut)
        {
            Cliente eliminado = clientes.Find(c => c.Rut == rut);
            clientes.Remove(eliminado);
        }

        public List<Cliente> Obtener()
        {
            return clientes;
        }
    }
}