<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="IntentoEvaluacion3.LogIn1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_registro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="btnRegistro-container">
        <asp:LinkButton ID="lnkbtn_logEmpresa" runat="server" PostBackUrl="~/LogInEmpresa.aspx">Log in Empresa</asp:LinkButton>
        <asp:LinkButton ID="lnkbtn_logUsuario" runat="server" PostBackUrl="~/LogInTrabajador.aspx">Log in Trabajador</asp:LinkButton>
    </div>
</asp:Content>
