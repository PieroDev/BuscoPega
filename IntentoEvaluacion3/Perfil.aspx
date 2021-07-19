<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="IntentoEvaluacion3.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_perfil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:none;">
        <asp:Label ID="lbl_trabajadorId" runat="server" Text=""></asp:Label>
    </div>
    <h1 style="text-align: center;">
        <asp:Label ID="lbl_mensajeNoSesion" runat="server" Text=""></asp:Label>
    </h1>
    <div id="perfil_container_handler" runat="server">
        <div id="perfil_container" class="perfil-container" runat="server">
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
    <div class="postulaciones-container">
        <h2 style="margin-right: 10px;color:#FCA311">Tus postulaciones</h2>
        <div class="postulaciones-wrapper">
            <div class="postulacion-item">
                <p>Fecha Postulacion</p>
            </div>
            <div class="postulacion-item">
                <p>Nombre Empleo</p>
            </div>
            <div class="postulacion-item">
                <p>Nombre Empresa</p>
            </div>
            <div class="postulacion-item">
                <p>Link</p>
            </div>
        </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <div class="postulaciones-wrapper">
                    <div class="postulacion-item">
                        <asp:Label ID="FechaPostulacionLabel" runat="server" Text='<%# Convert.ToDateTime(Eval("FechaPostulacion")).ToString("dd/MM/yyy") %>' />
                    </div>
                    <div class="postulacion-item">
                        <asp:Label ID="NombreEmpleoLabel" runat="server" Text='<%# Eval("NombreEmpleo") %>' />
                    </div>
                    <div class="postulacion-item">
                        <asp:Label ID="EmpresaNombreLabel" runat="server" Text='<%# Eval("EmpresaNombre") %>' />
                    </div>
                    <div class="postulacion-item">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"Empleo.aspx?empleoId=" + Eval("empleoId") %>'>Ver Empleo</asp:HyperLink>
                    </div>
                </div>
                
        </ItemTemplate>
        </asp:ListView>
        <asp:Label ID="lbl_probando" runat="server" Text=""></asp:Label>



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MiPegaConnectionString %>" SelectCommand="SELECT DISTINCT Postulacion.fechaPostulacion AS FechaPostulacion, Empleo.nombre AS NombreEmpleo, Empresa.nombre AS EmpresaNombre, Empleo.empleoId AS EmpleoId, Empresa.empresaId AS EmpresaId FROM Postulacion INNER JOIN Empleo ON Postulacion.empleoId = Empleo.empleoId INNER JOIN Empresa ON Empleo.empresaId = Empresa.empresaId WHERE (Postulacion.trabajadorId = @trabajadorId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="lbl_trabajadorId" Name="trabajadorId" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </div>
    






</asp:Content>


