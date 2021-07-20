<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarAsistentes.aspx.cs" Inherits="EventosWeb.MostrarAsistentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6-mx-auto">
          <asp:DropDownList ID="estadoDDL" runat="server"></asp:DropDownList>
        </div>

    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaAsistentes"
            CssClass="table table-hover table-bordered"
            AutoGenerateColumns="false"
            ShowHeaderWhenEmpty ="true"
            EmptyDataText="No hay Regsitros"
            runat ="server"></asp:GridView>
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Empresa" DataField="Empresa" />
                <asp:BoundField HeaderText="Region" DataField="Region.Nombre" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" />


            </Columns>
    </div>


</asp:Content>
