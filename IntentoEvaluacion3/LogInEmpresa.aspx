<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogInEmpresa.aspx.cs" Inherits="IntentoEvaluacion3.LogInEmpresa" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <div class="form-wrapper">
            <h1 style="text-align:center; color:#E5E5E5;">Ingresa tus credenciales</h1>
            <p>Nombre de usuario</p>
            <asp:TextBox ID="txt_username" runat="server" placeholder="Username"></asp:TextBox>
            <p>Contraseña</p>
            <asp:TextBox ID="txt_pass" runat="server" placeholder="*****"></asp:TextBox>
            <asp:Label ID="lbl_msjLogIn" runat="server" Text="" CssClass="lbl-msjLogIn"></asp:Label>
            <asp:Button ID="btn_logIn" runat="server" Text="Log In" CssClass="btnLogIn" OnClick="btn_logIn_Click"/>
        </div>
    </div>
</asp:Content>
