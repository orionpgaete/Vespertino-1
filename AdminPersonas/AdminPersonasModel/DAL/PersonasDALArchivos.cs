using AdminPersonas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdminPersonasModel.DAL
{
    public class PersonasDALArchivos : IPersonasDAL
    {
        private static string archivo = "adminpersonas.txt";
        private static string ruta = Directory.GetCurrentDirectory() + "/" + archivo;
                                        /// C:/Users/orion/source/......../adminpersonas.txt
                              
        public void AgregarPersona(Persona persona)
        {
            //1. Crear el StreamWriter
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    //2. Agrear una linea al archivo
                    string texto = persona.Nombre + ";"       //CSV;  comma Separated values
                                 + persona.Estatura + ";"
                                 + persona.Telefono + ";"
                                 + persona.Peso + ";";
                    writer.WriteLine(texto);
                    // 3.Cerrar el StreamWriter osea confirmar la escritura
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en archivo" + ex.Message);
            }
        }

        public List<Persona> FiltrarPersonas(string nombre)
        {
            return ObtenerPersonas().FindAll(p => p.Nombre.ToLower() == nombre.ToLower());
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            using(StreamReader reader = new StreamReader(ruta))
            {
                string texto;
                do
                {
                    texto = reader.ReadLine(); //error NULL
                    if (texto != null)
                    {
                        string[] textoArr = texto.Trim().Split(';');
                        string nombre = textoArr[0];
                        double estatura = Convert.ToDouble(textoArr[1]);
                        uint telefono = Convert.ToUInt32(textoArr[2]);
                        double peso = Convert.ToDouble(textoArr[3]);
                        // crear una persona
                        Persona p = new Persona()
                        {
                            Nombre = nombre,
                            Estatura = estatura,
                            Telefono = telefono,
                            Peso = peso
                        };
                        p.calcularImc();
                        personas.Add(p);
                    }                   
                } while (texto != null);
            }
            return personas;
        }
    }
}
