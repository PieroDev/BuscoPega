<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="IntentoEvaluacion3.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_registro.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="btnRegistro-container">
        <asp:LinkButton ID="lnkbtn_regUsuario" runat="server" PostBackUrl="~/RegistroUsuario.aspx">Registro Usuario</asp:LinkButton>
        <asp:LinkButton ID="lnkbtn_regEmpresa" runat="server" PostBackUrl="~/RegistroEmpresa.aspx">Registro Empresa</asp:LinkButton>
    </div>
</asp:Content>
