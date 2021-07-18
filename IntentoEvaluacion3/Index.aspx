<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IntentoEvaluacion3.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style_index.css" rel="stylesheet" />
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="index-content-container">
        <h1 >Busca tu pega ideal</h1>
        <asp:TextBox ID="txt_buscar" runat="server" CssClass="txt-buscar"></asp:TextBox>
        <br/>
        <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="btn-buscar" OnClick="btn_buscar_Click" />
    </div>
    <div class="resultados-container">
        <asp:ListView ID="listaEmpleos" runat="server" DataSourceID="SqlDataSource2">
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
                    <div class="cargo-wrapper">
                        <asp:Label ID="lbl_cargoEmpleo" runat="server" Text='<%# Eval("cargo") %>'></asp:Label>
                    </div>
                    <div class="contrato-wrapper">
                        <asp:Label ID="lbl_contratoEmpleo" runat="server" Text='<%# Eval("contrato") %>'></asp:Label>
                    </div>
                    <div class="sueldo-wrapper">
                        $ <asp:Label ID="lbl_sueldo" runat="server" Text='<%# Eval("sueldo") %>'></asp:Label>
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

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MiPegaConnectionString %>" SelectCommand="SELECT [empleoId], [nombre], [cargo], [contrato], [sueldo], [descripcion] FROM [Empleo] WHERE ([nombre] LIKE '%' + @nombre + '%')">
            <SelectParameters>
                <asp:ControlParameter ControlID="txt_buscar" Name="nombre" PropertyName="Text" Type="String" />
            </SelectParameters>

        </asp:SqlDataSource>
    </div>
    

    


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BuscoPegaConnectionString %>" SelectCommand="SELECT [empresaId], [nombre], [rut], [email], [descripcion] FROM [Empresa] WHERE ([empresaId] > @empresaId)">
        <SelectParameters>
            <asp:ControlParameter ControlID="txt_buscar" Name="empresaId" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>

    


</asp:Content>
