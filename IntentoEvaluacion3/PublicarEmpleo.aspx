<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PublicarEmpleo.aspx.cs" Inherits="IntentoEvaluacion3.PublicarEmpleo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_publicarEmpleo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <div class="form-wrapper">
            <h1 style="text-align:center; color:#E5E5E5;">Ingresa los datos del empleo</h1>
            <p>Titulo Empleo</p>
            <asp:TextBox ID="txt_nombreEmpleo" runat="server" placeholder="Titulo empleo"></asp:TextBox>
            <p>Cargo</p>
            <asp:DropDownList runat="server" ID="dd_cargo" css="dd-publicar" Width="100%">
                <asp:ListItem>Selecciona</asp:ListItem>
                <asp:ListItem>Trainee</asp:ListItem>
                <asp:ListItem>Junior</asp:ListItem>
                <asp:ListItem>Semi-Senior</asp:ListItem>
                <asp:ListItem>Senior</asp:ListItem>
            </asp:DropDownList>
            <p>Contrato</p>
            <asp:DropDownList runat="server" ID="dd_contrato" css="dd-publicar" Width="100%">
                <asp:ListItem>Selecciona</asp:ListItem>
                <asp:ListItem>Part-Time</asp:ListItem>
                <asp:ListItem>Full-Time</asp:ListItem>
            </asp:DropDownList>
            <p>Sueldo</p>
            <asp:TextBox ID="txt_sueldoEmpleo" runat="server" placeholder="Ejm: 750000"></asp:TextBox>
            <p>Descripcion Empleo</p>
            <asp:TextBox ID="txt_descripcionEmpleo" runat="server" placeholder="En esta empresa buscamos a..." CssClass="descripcionEmpresa" Rows="20" TextMode="MultiLine" MaxLength="3000"></asp:TextBox>
            <br/>
            <asp:Button ID="btn_publicarEmpleo" runat="server" Text="Publicar" CssClass="btnPublicarEmpleo" OnClick="btn_publicarEmpleo_Click"/>
            <asp:Label ID="lbl_msjErrorForm" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
