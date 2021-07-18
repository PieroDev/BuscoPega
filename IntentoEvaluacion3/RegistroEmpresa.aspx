<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroEmpresa.aspx.cs" Inherits="IntentoEvaluacion3.RegistroEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_registroEmpresa.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <div class="form-wrapper">
            <h1 style="text-align:center; color:#E5E5E5;">Ingresa tus datos</h1>
            <p>Username</p>
            <asp:TextBox ID="txt_usernameEmpresa" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
            <p>Contraseña</p>
            <asp:TextBox ID="txt_claveEmpresa" runat="server" TextMode="Password" placeholder="Una contraseña que recuerdes fácilmente" CssClass="textcontra"></asp:TextBox>
            <p>Confirmar contraseña</p>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" placeholder="Repite tu contraseña" CssClass="confiContra"></asp:TextBox>
            <p class="msjError">
                <asp:Label ID="lbl_msjError" runat="server" Text="" CssClass="lbl-msj"></asp:Label>
            </p>
            <p>Nombre empresa</p>
            <asp:TextBox ID="txt_nombreEmpresa" runat="server" placeholder="Ejm: Empresa Imaginaria SPA"></asp:TextBox>
            <p>Rut empresa</p>
            <asp:TextBox ID="txt_rutEmpresa" runat="server" placeholder="Ejm: 53987291-1"></asp:TextBox>
            <p>Email empresa</p>
            <asp:TextBox ID="txt_emailEmpresa" runat="server" placeholder="ejemplo@mail.cl"></asp:TextBox>
            <p>Teléfono corporativo</p>
            <asp:TextBox ID="txt_telefonoEmpresa" runat="server" placeholder="977542297"></asp:TextBox>
            <p>Descripción empresa</p>
            <asp:TextBox ID="txt_descripcionEmpresa" runat="server" placeholder="Somos una empresa..." CssClass="descripcionEmpresa" Rows="20" TextMode="MultiLine" MaxLength="300"></asp:TextBox>
            <br/>
            <asp:Button ID="btn_registrarme" runat="server" Text="Registrarme" CssClass="btnRegistrarme" />
        </div>
    </div>
</asp:Content>
