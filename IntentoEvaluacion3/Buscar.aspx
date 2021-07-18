<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="IntentoEvaluacion3.Buscar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Busca lo que necesites</h3>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Buscar" />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Volver al inicio</asp:HyperLink>
</asp:Content>
