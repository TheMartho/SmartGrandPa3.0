<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="exito.aspx.cs" Inherits="SmartGrandpaWeb.exito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  card de envio exitoso de sugerencia -->
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white text-center">
                    <h1>¡Se envio con exito! :D</h1>
                </div>
                <!--  Boton de regreso al inicio -->
                <a href="Default.aspx" class="btn btn-primary text-white">Volver Al inicio</a>
            </div>
        </div>
    </div>
</asp:Content>
