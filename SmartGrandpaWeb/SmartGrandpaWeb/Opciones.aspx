<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Opciones.aspx.cs" Inherits="SmartGrandpaWeb.Opciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container margin-top">
        <!-- lleva a los tutoriales escritos -->
        <div class="card text-center" style="width: 18rem;">
            <img class="card-img-top" src="imagenes/TutorialMano.jpg" alt="Card image cap" height="250" width="260" />
            <div class="card-body">
                <h5 class="card-title">TUTORIAL ESCRITO</h5>
            </div>
            <div class="card-footer">
                <asp:Button runat="server" ID="EscritoBtn" CssClass="btn btn-dark" Text="Comenzar" OnClick="EscritoBtn_Click" />
            </div>
        </div>
        <!-- lleva a los tutoriales de video -->
        <div class="card text-center" style="width: 18rem;">
            <img class="card-img-top" src="imagenes/VideoTutorial.png" alt="Card image cap" height="250" width="260" />
            <div class="card-body">
                <h5 class="card-title">VIDEO TUTORIAL</h5>
            </div>
            <div class="card-footer">
                <asp:Button runat="server" ID="VideoBtn" CssClass="btn btn-dark" Text="Comenzar" OnClick="VideoBtn_Click" />
            </div>
        </div>
        <!-- lleva a los tutoriales didacticos -->
        <div class="card text-center" style="width: 18rem;">
            <img class="card-img-top" src="imagenes/diseño-interactivo1.gif" alt="Card image cap" height="250" width="260" />
            <div class="card-body">
                <h5 class="card-title">TUTORIAL DIDACTICO</h5>
            </div>
            <div class="card-footer">
               <h5 class="card-title">PROXIMAMENTE</h5>
            </div>
        </div>
    </div>

</asp:Content>
