﻿using AdminPersonas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPersonasModel.DAL
{
    public interface IPersonasDAL
    {
        public void AgregarPersona(Persona persona);

        List<Persona> ObtenerPersonas();

        List<Persona> FiltrarPersonas(string nombre);

    }
}
