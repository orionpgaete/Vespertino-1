using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SaludarBtn_Click(object sender, EventArgs e)
        {
            string nombre = this.nombretxt.Text.Trim();
            this.mensajeH1.InnerText = "Hola "+nombre+ " ¡¡, para de flojear¡¡¡¡";
        }
    }
}