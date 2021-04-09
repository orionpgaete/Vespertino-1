using AdminPersonas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALObjetos : IPersonasDAL
    {
        //1. Crear una lista para guardar personas
        private static List<Persona> personas = new List<Persona>();        
        
        //2. Crear las operaciones ingresar, mostrar y buscar

        public void AgregarPersona(Persona p)
        {
            personas.Add(p);
        }

        public List<Persona> ObtenerPersonas()
        {
            return personas;
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            //Forma 1
            //  List<Persona> filtrada = new List<Persona>();
            //// 1. for (int i=0; i < personas.Count(); ++i)
            //  foreach(Persona p in personas)
            //  {
            //      // 1. if (personas[i].Nombre == nombre)
            //      if (p.Nombre == nombre)
            //      {
            //          filtrada.Add(p);
            //      }
            //  }
            //  return filtrada;

            //forma 2
            return personas.FindAll(p => p.Nombre == nombre);

        }

    }
}
