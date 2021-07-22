<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tutoriales.aspx.cs" Inherits="SmartGrandpaWeb.Tutoriales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="barra margin-top">
    <asp:TextBox runat="server" class="form-control mr-sm-2" id="filtroTxt" type="search" placeholder="¿Qué Desea Aprender Hoy?" aria-label="Buscar"/>
    <asp:Button class="btn btn-outline-success my-2 my-sm-0" ID="BtnFiltrar" runat="server" OnClick="BtnFiltrar_Click" type="submit" text="Buscar"></asp:Button>
        
       </div>




    <div class="container margin-top">
        <asp:Repeater ID="Repetidor" runat="server">
            <ItemTemplate>
                <div class="card" style="width: 18rem;">
                        <img class="card-img-top" src="<%# DataBinder.Eval(Container.DataItem, "UrlImagen") %>" alt="Card image cap" height="250" width="260"></a>
                    <div class="card-body text-center">
                        <p class="card-title">"<%# DataBinder.Eval(Container.DataItem, "NombreTema") %>"</p>
                        <h5 class="card-text">"<%# DataBinder.Eval(Container.DataItem, "Descripcion") %>"</h5>
                    </div>
                    <div class="card-footer text-center">
                      <a href="Opciones.aspx?Id=<%# DataBinder.Eval(Container.DataItem, "Id")%>" class="btn btn-primary text-white">¡APRENDER!</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
</asp:Content>
