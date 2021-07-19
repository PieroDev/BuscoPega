<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PerfilEmpresa.aspx.cs" Inherits="IntentoEvaluacion3.PerfilEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_perfilEmpresa.css" rel="stylesheet" />
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
                        <asp:Label ID="lbl_perfilNombre" runat="server" Text=""></asp:Label>
                    </h2>
                </div>
                
                <div>
                    <p>Rut: </p>
                    <asp:Label ID="lbl_perfilRut" runat="server" Text=""></asp:Label>
                    <p>Telefono:</p>
                    <asp:Label ID="lbl_perfilTelefono" runat="server" Text=""></asp:Label>
                    <p>Email:</p>
                    <asp:Label ID="lbl_perfilEmail" runat="server" Text=""></asp:Label>
                    <p>Descripcion:</p>
                    <asp:Label ID="lbl_perfilDescripcion" runat="server" Text=""></asp:Label>
                    
                </div>
            </div>

        </div>
    </div>
        <div class="postulaciones-container">
            <div class="postulaciones-wrapper">
                <div class="postulacion-item">
                    <p>Nombre Empleo</p>
                </div>
                <div class="postulacion-item">
                    <p>Cargo</p>
                </div>
                <div class="postulacion-item">
                    <p>Contrato</p>
                </div>
                <div class="postulacion-item">
                    <p>Sueldo</p>
                </div>
                <div class="postulacion-item">
                    <p>Link</p>
                </div>
                <div class="postulacion-item">
                    <p style="text-align: center;">Acciones</p>
                </div>
            </div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <div class="postulaciones-wrapper">
                        <div class="postulacion-item">
                            <asp:Label ID="nombreEmpleoLabel" runat="server" Text='<%# (Eval("nombre")) %>' />
                        </div>
                        <div class="postulacion-item">
                            <asp:Label ID="cargoEmpleoLabel" runat="server" Text='<%# Eval("cargo") %>' />
                        </div>
                        <div class="postulacion-item">
                            <asp:Label ID="contratoEmpleo" runat="server" Text='<%# Eval("contrato") %>' />
                        </div>
                        <div class="postulacion-item">
                            $ <asp:Label ID="sueldo" runat="server" Text='<%#Convert.ToInt32(Eval("sueldo")) %>' />
                        </div>
                        <div class="postulacion-item">
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"Empleo.aspx?empleoId=" + Eval("empleoId") %>'>Ver Empleo</asp:HyperLink>
                        </div>
                        <div class="postulacion-item opciones-container">
                            <div class="opcion-item">
                                <asp:HyperLink ID="link_editarEmpleo" runat="server" NavigateUrl='<%#"EditarEmpleo.aspx?empleoId=" + Eval("empleoId") %>'><i class="fas fa-edit"></i></asp:HyperLink>
                                <p>Editar</p>
                            </div>
                            <div class="opcion-item">
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"EliminarEmpleo.aspx?empleoId=" + Eval("empleoId") %>'><i class="fas fa-trash"></i></asp:HyperLink>
                                <p>Eliminar</p>
                            </div>
                        </div>
                    </div>
                
                </ItemTemplate>
            </asp:ListView>
                


            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MiPegaConnectionString %>" SelectCommand="SELECT * FROM [Empleo] WHERE ([empresaId] = @empresaId)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="lbl_trabajadorId" Name="empresaId" PropertyName="Text" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>



        </div>


    </div>
</asp:Content>
