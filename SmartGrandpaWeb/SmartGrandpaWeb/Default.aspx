<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SmartGrandpaWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container margin-top">
        <!-- Card numero 1 del inicio que lleva a Sobre nosotros -->
        <div class="card" style="width: 18rem;">
            <img class="card-img-top" src="imagenes\nosotros.png" alt="Card image cap" height="250" width="260" />
            <div class="card-body text-center">
                <p class="card-title">"Sobre nosotros"</p>
                <h5 class="card-text">"Aprende sobre nosotros y de que trata esta web"</h5>
            </div>
            <div class="card-footer text-center">
                <a href="blog.aspx" class="btn btn-primary text-white">¡SOBRE NOSOTROS!</a>
            </div>
        </div>
        <!-- Card numero 2 del inicio que lleva a tutoriales -->
        <div class="card" style="width: 18rem;">
            <img class="card-img-top" src="imagenes\tutoriales_web.jpg" alt="Card image cap" height="250" width="260" />
            <div class="card-body text-center">
                <p class="card-title">"Tutoriales"</p>
                <h5 class="card-text">"Aprende con nosotros sobre lo que necesites"</h5>
            </div>
            <div class="card-footer text-center">
                <a href="Tutoriales.aspx" class="btn btn-primary text-white">¡TURORIALES!</a>
            </div>
        </div>
    </div>
</asp:Content>