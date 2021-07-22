<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="SmartGrandpaWeb.Contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div class="card">
                <div class="card-header bg-info text-white text-center">
                    <h1>Enviar Sugerencia o Opinion</h1>
                </div>
                <div class="card-body">

                    <div class="form-group">
                        <label for="nombreTxt">Ingrese su Nombre (Opcional)</label>
                        <asp:TextBox runat="server"  class="form-control" id="nombreTxt" placeholder="Ingrese su Nombre"/>
                    </div>
                   <div class="form-group margin-top">
                        <label for="celularTxt">Ingrese su Celular (Opcional)</label>
                        <asp:TextBox runat="server" class="form-control" id="celularTxt" placeholder="Ingrese su numero telefonico"/>
                    </div>
                   <div class="form-group margin-top">
                        <label for="correoTxt">Ingrese su Correo Electronico (Opcional)</label>
                        <asp:TextBox runat="server" type="email" class="form-control" id="correoTxt" placeholder="Ingrese su correo electronico"/>
                    </div>
                    <div class="form-group margin-top">
                        <label for="contenidoTxt">Ingrese su Sugerencia o Consulta</label>
                        <asp:TextBox runat="server" TextMode="MultiLine" Columns="50" Rows="8"  class="form-control" id="contenidoTxt" placeholder="¿Qué tiene que decirnos?"/>
                    </div>

                </div>
                <div class="card-footer text-center">
                    <asp:Button class="btn btn-primary text-white" Text="Enviar" OnClick="BtnEnviar_Click" runat="server"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
