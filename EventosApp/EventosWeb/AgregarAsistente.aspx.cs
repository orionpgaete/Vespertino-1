﻿using EventosModel;
using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWeb
{
    public partial class AgregarAsistente : System.Web.UI.Page
    {
        private IRegionDAL regionesDAL = new RegionesDALDB();
        private IAsistenteDAL asisrentesDAL = new AsistentesDALDB();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.regionDDL.DataSource = this.regionesDAL.ObtenerRegiones();
                this.regionDDL.DataTextField = "Nombre";
                this.regionDDL.DataValueField = "Id";
                this.regionDDL.DataBind();
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Asistente asistente = new Asistente();
            asistente.Rut = this.rutTxt.Text.Trim();
            asistente.Nombre = this.nombreTxt.Text.Trim();
            asistente.Apellido = this.apellidoTxt.Text.Trim();
            asistente.Edad = Convert.ToInt32(this.edadTxt.Text.Trim());
            asistente.Estado = this.estadoRb1.SelectedItem.Value;
            asistente.Empresa = this.empresaTxt.Text.Trim();
            asistente.IdRegion = Convert.ToInt32(this.regionDDL.SelectedItem.Value);
            this.asisrentesDAL.AgregarAsistente(asistente);

            Response.Redirect("MostrarAsistentes.aspx");



        }
    }
}