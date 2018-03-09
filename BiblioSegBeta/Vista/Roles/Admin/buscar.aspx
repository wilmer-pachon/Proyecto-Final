<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="/logica/Admin/buscar.aspx.cs" Inherits="Vista_Roles_Admin_buscar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:TextBox ID="Txt_Buscar" runat="server"></asp:TextBox>
                <asp:Button ID="bt_buscar" runat="server" OnClick="bt_buscar_Click" Text="Buscar" />
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="Gv_busqueda" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Buscar">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Buscar" runat="server" SelectMethod="busca" TypeName="Logica.Admin.L_Busca">
                    <SelectParameters>
                        <asp:Parameter Name="buscar" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>        
    </table>
</asp:Content>

