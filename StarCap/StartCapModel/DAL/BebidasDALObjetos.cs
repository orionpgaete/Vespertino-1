using StarCapModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartCapModel.DAL
{
    public class BebidasDALObjetos : IBebidasDAL
    {
        public List<Bebida> ObtenerBebidas()
        {
            return new List<Bebida>()
            {
                new Bebida()
                {
                    Nombre = "Frapuccino",
                    Codigo = "FP-001"
                },
                new Bebida()
                {
                    Nombre = "Té Chai",
                    Codigo = "TE-001"
                },
                new Bebida()
                {
                    Nombre = "Cafe del dia",
                    Codigo = "CA-001"
                }
            };
        }

    }
}
