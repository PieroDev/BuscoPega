<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Empleo.aspx.cs" Inherits="IntentoEvaluacion3.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_empleo.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="id" style="display:none">
        <asp:Label ID="lbl_prueba" runat="server" Text=""></asp:Label>
        <asp:Label ID="empresaIdLabel" runat="server" Text='<%# Eval("empresaId") %>' />
        <asp:Label ID="empleoIdLabel" runat="server" Text='<%# Eval("empleoId") %>' />
    </div>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="empresaId,empleoId">
        <EmptyDataTemplate>
                <table style="" runat="server">
                    <tr>
                        <td></td>
                    </tr>
                </table>
            </EmptyDataTemplate>

            <ItemTemplate>
                <div class="empleo-container">
                    <h1>
                        <asp:Label ID="empleoNombreLabel" runat="server" Text='<%# Eval("empleoNombre") %>' />
                    </h1>
                    <h3>
                        Empresa: <asp:HyperLink ID="hyperlinkEmpresa" runat="server" NavigateUrl='<%#"Empresa.aspx?empresaId=" + Eval("empresaId") %>'><%# Eval("nombre")%></asp:HyperLink>
                    </h3>
                    
                    <div>
                        <div>
                            <asp:Label ID="cargoLabel" runat="server" Text='<%# Eval("cargo") %>' />
                        </div>
                        <div>
                            <asp:Label ID="contratoLabel" runat="server" Text='<%# Eval("contrato") %>' />
                        </div>
                        <div>
                            $ <asp:Label ID="sueldoLabel" runat="server" Text='<%# Eval("sueldo") %>' />
                        </div>
                    </div>
                    <p>
                        <asp:Label ID="descripcionLabel" runat="server" Text='<%# Eval("descripcion") %>' />
                    </p>
                    <asp:Button ID="btn_postular" runat="server" Text="Postular" CssClass="btnPostular" />
                </div>
            </ItemTemplate>
        
    </asp:ListView>
                    

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MiPegaConnectionString %>" SelectCommand="SELECT Empresa.empresaId, Empresa.nombre, Empleo.empleoId, Empleo.nombre AS empleoNombre, Empleo.cargo, Empleo.contrato, Empleo.sueldo, Empleo.descripcion FROM Empresa INNER JOIN Empleo ON Empresa.empresaId = Empleo.empresaId WHERE (Empleo.empleoId = @empleoId)">
        <SelectParameters>
            <asp:ControlParameter ControlID="lbl_prueba" Name="empleoId" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>





</asp:Content>
