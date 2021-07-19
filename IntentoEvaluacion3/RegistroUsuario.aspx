<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="IntentoEvaluacion3.RegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_registroUsuario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <div class="form-wrapper">
            <h1 style="text-align:center; color:#E5E5E5;">Ingresa tus datos</h1>
            <p>Username</p>
            <asp:TextBox ID="txt_usernameTrabajador" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
            <p>Contraseña</p>
            <asp:TextBox ID="txt_claveTrabajador" runat="server" TextMode="Password" placeholder="Una contraseña que recuerdes fácilmente" CssClass="textcontra"></asp:TextBox>
            <p>Confirmar contraseña</p>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" placeholder="Repite tu contraseña" CssClass="confiContra"></asp:TextBox>
            <p class="msjError">
                <asp:Label ID="lbl_msjError" runat="server" Text="" CssClass="lbl-msj"></asp:Label>
            </p>
            <p>Nombre y apellido</p>
            <asp:TextBox ID="txt_nombreTrabajador" runat="server" placeholder="Nombre y dos apellidos"></asp:TextBox>
            <p>Rut</p>
            <asp:TextBox ID="txt_rutTrabajador" runat="server" placeholder="Ejm: 19005603-1"></asp:TextBox>
            <p>Email</p>
            <asp:TextBox ID="txt_emailTrabajador" runat="server" placeholder="ejemplo@mail.cl"></asp:TextBox>
            <p>Telefono</p>
            <asp:TextBox ID="txt_telefonoTrabajador" runat="server" placeholder="977542297"></asp:TextBox>
            <p>Profesion</p>
            <asp:TextBox ID="txt_profesionTrabajador" runat="server" placeholder="Ejm: Analista Programador"></asp:TextBox>
            <p>Curriculum vitae (Link)</p>
            <asp:TextBox ID="txt_curriculumTrabajador" runat="server" placeholder="Recuerda subir tu cv a drive y mandarnos el link"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_msjErrorForm" runat="server" Text=""></asp:Label>
            <asp:Button ID="btn_registrarme" runat="server" Text="Registrarme" CssClass="btnRegistrarme" OnClick="btn_registrarme_Click" />
        </div>
        
    </div>



</asp:Content>
