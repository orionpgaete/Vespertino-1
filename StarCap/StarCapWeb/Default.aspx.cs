using StarCapModel;
using StarCapModel.DAL;
using StartCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clienteDAL = new  ClientesDALObjetos();
        private IBebidasDAL bebidasDAL = new BebidasDALObjetos();

        //Cuando es una peticion GET (!PostBack)
        //Cuando es una peticion POST (PostBack)
        protected void Page_Load(object sender, EventArgs e)
        {
            //Metodo que carga al form la lista de bebidas
            if (!IsPostBack) 
            {
                //aqui cargamos el dropdown
                List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
                this.bebidaDb1.DataSource = bebidas;
                this.bebidaDb1.DataTextField = "Nombre";
                this.bebidaDb1.DataValueField = "Codigo";
                this.bebidaDb1.DataBind();

            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            string bebidaValor = this.bebidaDb1.SelectedValue;
            string bebidoTexto = this.bebidaDb1.SelectedItem.Text;
            int nivel = Convert.ToInt32(this.nivelRb1.SelectedItem.Value);
            //2. Construir el objeto de tipo cliente

            List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDb1.SelectedItem.Value);

            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut = rut,
                Nivel = nivel,
                BebidaFavorita = bebida
            };

            //3. llamar al DAL
            clienteDAL.Agregar(cliente);

            //4. Mostrar mensaje de exito
            this.mensajesLbl.Text = "Cliente Ingresado";

            Response.Redirect("VerClientes.aspx");
        }
    }
}