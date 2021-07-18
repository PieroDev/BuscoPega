<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="IntentoEvaluacion3.WebForm2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_perfil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Este es tu perfil!</h2>
    <div class="perfil-container">
        <div class="perfil-wrapper">
            <div class="perfil-item">
                <div class="img-container">
                   <img src="img/fotoPerfil.jpg" alt="" />
                </div>
            </div>
            <div class="perfil-item">
                <div>
                    <h2>
                    Buena <asp:Label ID="lbl_perfilNombre" runat="server" Text=""></asp:Label>!
                    </h2>
                    <p>
                    <asp:Label ID="lbl_perfilProfesion" runat="server" Text=""></asp:Label>
                    </p>
                </div>
                
                <div>
                    <p>Rut: </p>
                    <asp:Label ID="lbl_perfilRut" runat="server" Text=""></asp:Label>
                    <p>Telefono:</p>
                    <asp:Label ID="lbl_perfilTelefono" runat="server" Text=""></asp:Label>
                    <p>Email:</p>
                    <asp:Label ID="lbl_perfilEmail" runat="server" Text=""></asp:Label>
                </div>
            </div>

        </div>
    </div>







</asp:Content>


