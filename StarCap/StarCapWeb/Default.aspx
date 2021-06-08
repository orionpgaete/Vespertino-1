<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCapWeb.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Cliente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="bebidaDb1">Bebida Favorita</label>
                         <asp:DropDownList runat="server" ID="bebidaDb1" CssClass="form-control">
                            <asp:ListItem Text="Frapuccino" Value="FRAP-01" ></asp:ListItem>
                            <asp:ListItem Text="Café del día" Value="CAF-01"></asp:ListItem>
                            <asp:ListItem Text="Té del día" Value="TE-01" ></asp:ListItem>
                            <asp:ListItem Text="Té Chai" Value="TE-02" ></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="nivelRb1">Nivel de Cliente</label>
                        <asp:RadioButtonList runat="server" ID="nivelRb1">
                            <asp:ListItem Selected="True" Value="1" Text="Silver" ></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold" ></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum" ></asp:ListItem>
                        </asp:RadioButtonList>       
                    </div>

             
                </div>
            </div>
        </div>
    </div>
</asp:Content>
