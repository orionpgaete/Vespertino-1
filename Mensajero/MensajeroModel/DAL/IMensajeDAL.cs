using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    public interface IMensajeDAL
    {
        void AgregarMensaje(Mensaje mensaje);
        List<Mensaje> ObtenerMensajes();
    }
}
