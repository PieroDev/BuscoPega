<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="IntentoEvaluacion3.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_empresa.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="id" style="display:none">
        <asp:Label ID="prueba" runat="server" Text="Probando" Enabled="False"></asp:Label>
    </div>
    
    <div class="info-empresa-container">
        <asp:DataList ID="DataList1" runat="server" DataKeyField="empresaId" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <div class="empresaInfo-container">
                    <div class="empresaInfo-wrapper">
                        <h1><asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' /></h1>
                        <h3>Informacion</h3>
                        <p>Email: <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' /></p>
                        <p>Rut: <asp:Label ID="rutLabel" runat="server" Text='<%# Eval("rut") %>' /></p>
                        <p>Descripción: <asp:Label ID="descripcionLabel" runat="server" Text='<%# Eval("descripcion") %>' /></p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MiPegaConnectionString %>" SelectCommand="SELECT [empresaId], [nombre], [rut], [email], [descripcion] FROM [Empresa] WHERE ([empresaId] = @empresaId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="prueba" Name="empresaId" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>

    </div>
    <hr />
    <h2 style="text-align:center;">Trabajos de esta empresa</h2>
    <div class="trabajos-container">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2">
            
            <EmptyDataTemplate>
                <table style="">
                    <tr>
                        <td></td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <ItemTemplate>
                <div runat="server" class="empleo-container">
                    <h3>
                        <asp:Label ID="lbl_nombreEmpleo" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                    </h3>
                    <div class="detalles-container">
                        <div class="cargo-wrapper">
                            <asp:Label ID="lbl_cargoEmpleo" runat="server" Text='<%# Eval("cargo") %>'></asp:Label>
                        </div>
                        <div class="contrato-wrapper">
                            <asp:Label ID="lbl_contratoEmpleo" runat="server" Text='<%# Eval("contrato") %>'></asp:Label>
                        </div>
                        <div class="sueldo-wrapper">
                            <asp:Label ID="lbl_sueldo" runat="server" Text='<%# Eval("sueldo") %>'></asp:Label>
                        </div>
                    </div>
                    <p class="descriEmpleo">
                        <asp:Label ID="lbl_descripcionEmpleo" runat="server" Text='<%# Eval("descripcion") %>'></asp:Label>
                    </p>
                    <p>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"Empleo.aspx?empleoId=" + Eval("empleoId") %>'>Ver Trabajo</asp:HyperLink>
                    </p>
                </div>

            </ItemTemplate>
        </asp:ListView>




        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MiPegaConnectionString %>" SelectCommand="SELECT Empleo.empleoId, Empleo.nombre, Empleo.cargo, Empleo.contrato, Empleo.sueldo, Empleo.descripcion, Empleo.empresaId FROM Empleo INNER JOIN Empresa ON Empleo.empresaId = Empresa.empresaId WHERE (Empresa.empresaId = @empresaId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="prueba" Name="empresaId" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>




    </div>
</asp:Content>
