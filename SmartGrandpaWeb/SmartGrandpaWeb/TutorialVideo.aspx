<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorialVideo.aspx.cs" Inherits="SmartGrandpaWeb.TutorialVideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- video turorial -->
    <div class="container">
        <iframe width="560" height="315" src="<%= Request.QueryString.Get("url")%>" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
    </div>
</asp:Content>
