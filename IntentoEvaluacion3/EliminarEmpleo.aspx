<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EliminarEmpleo.aspx.cs" Inherits="IntentoEvaluacion3.EliminarEmpleo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_registro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="btnRegistro-container">
        <h1 style="text-align:center;">¿Seguro que quiere eliminar el empleo?</h1>
        <asp:Button CssClass="btnConfirmar" ID="btnSi" runat="server" Text="Si" OnClick="btnSi_Click" />
        <asp:Button CssClass="btnConfirmar" ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
    </div>




</asp:Content>
