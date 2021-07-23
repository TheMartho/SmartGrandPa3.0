<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="SmartGrandpaWeb.Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- formulario -->
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white text-center">
                    <h1>Enviar Sugerencia o Opinion</h1>
                </div>
                <div class="card-body">
                    <!--  Ingreso de nombre -->
                    <div class="form-group">
                        <label for="nombreTxt">Ingrese su Nombre (Opcional)</label>
                        <asp:TextBox runat="server" class="form-control" ID="nombreTxt" placeholder="Ingrese su Nombre" />
                    </div>
                    <!--  Ingreso de celular -->
                    <div class="form-group margin-top">
                        <label for="celularTxt">Ingrese su Celular (Opcional)</label>
                        <asp:TextBox runat="server" class="form-control" ID="celularTxt" placeholder="Ingrese su numero telefonico" />
                    </div>
                    <!--  Ingreso de correo -->
                    <div class="form-group margin-top">
                        <label for="correoTxt">Ingrese su Correo Electronico (Opcional)</label>
                        <asp:TextBox runat="server" type="email" class="form-control" ID="correoTxt" placeholder="Ingrese su correo electronico" />
                    </div>
                    <!--  Ingreso de sugerencia o consulta -->
                    <div class="form-group margin-top">
                        <label for="contenidoTxt">Ingrese su Sugerencia o Consulta</label>
                        <asp:TextBox runat="server" TextMode="MultiLine" Columns="50" Rows="8" class="form-control" ID="contenidoTxt" placeholder="¿Qué tiene que decirnos?" />
                    </div> 
                </div>
                <!--  Boton para enviar -->
                <div class="card-footer text-center">
                    <asp:Button class="btn btn-primary text-white" Text="Enviar" OnClick="BtnEnviar_Click" runat="server"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
