<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/BuscarHerramienta.aspx.cs" Inherits="Vista_Roles_Moderador_BuscarHerramienta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 18px;
    }
    .auto-style3 {
        width: 198px;
    }
    .auto-style4 {
        height: 18px;
        width: 198px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">
                <asp:TextBox ID="Txt_Buscar" runat="server"></asp:TextBox>
                <asp:Button ID="bt_buscar" runat="server" OnClick="bt_buscar_Click" Text="Buscar" />
            </td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:GridView ID="Gv_busqueda" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_BuscarHerramienta">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_BuscarHerramienta" runat="server" SelectMethod="busca" TypeName="Logica.Moderador.L_BuscarHerramienta">
                    <SelectParameters>
                        <asp:Parameter Name="buscar" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

