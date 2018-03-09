<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" AutoEventWireup="true" CodeFile="~/logica/Registrado/BuscarH.aspx.cs" Inherits="Vista_Roles_Registrado_BuscarH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 684px;
    }
    .auto-style3 {
        width: 209px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:TextBox ID="Txt_Buscar" runat="server"></asp:TextBox>
                <asp:Button ID="bt_buscar" runat="server" OnClick="bt_buscar_Click" Text="Buscar" />
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
                <asp:GridView ID="Gv_busqueda" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_BuscarH">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_BuscarH" runat="server" SelectMethod="busca" TypeName="Logica.Registrado.L_BuscarH">
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
</table>
</asp:Content>

