﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPersonas
{
    public class Persona
    {
        private string nombre ;
        private uint telefono;
        private double estatura;
        private double peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public uint Telefono { get => telefono; set => telefono = value; }
        public double Estatura { get => estatura; set => estatura = value; }
        public double Peso { get => peso; set => peso = value; }
    }
}
