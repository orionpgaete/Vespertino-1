using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public class RegionesDALDB : IRegionDAL
    {
        private Evento_1DBEntities eventosDB = new Evento_1DBEntities();
        public List<Region> ObtenerRegiones()
        {
            return this.eventosDB.Regions.ToList();
        }
    }
}
