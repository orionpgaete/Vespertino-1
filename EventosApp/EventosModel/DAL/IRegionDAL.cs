using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosModel.DAL
{
    public interface IRegionDAL
    {
        List<Region> ObtenerRegiones();
    }
}
