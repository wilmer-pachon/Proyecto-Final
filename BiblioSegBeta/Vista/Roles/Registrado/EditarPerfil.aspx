<%@ Page Title="" enableEventValidation="false" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" AutoEventWireup="true" CodeFile="~/logica/Registrado/EditarPerfil.aspx.cs" Inherits="Vista_Roles_Registrado_EditarPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 18px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2"></td>
        <td colspan="2" class="auto-style2">
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="EDITAR PERLFIL USUARIO"></asp:Label>
        </td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style2"></td>
        <td class="auto-style2">
        </td>
        <td class="auto-style2"></td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="id_user" DataSourceID="ObjectDataSource1" GridLines="Horizontal">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="inicia_perfil" TypeName="DAORegistrar" UpdateMethod="editar_usuario">
                <SelectParameters>
                    <asp:Parameter Name="id_user" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="id_user" Type="Int32" />
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="correo" Type="String" />
                    <asp:Parameter Name="sitio_web" Type="String" />
                    <asp:Parameter Name="nom_user" Type="String" />
                    <asp:Parameter Name="foto" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lb_id" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:GridView ID="gb_perfil" runat="server" OnRowEditing="gb_perfil_RowEditing" OnRowUpdating="gb_perfil_RowUpdating" AutoGenerateColumns="False" OnRowCancelingEdit="gb_perfil_RowCancelingEdit">
                <Columns>
                    <asp:CommandField EditText="Editar perfil" ShowEditButton="True" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="nom_user" HeaderText="Nombre Usuario" />
                    <asp:BoundField DataField="correo" HeaderText="Correo" />
                    <asp:BoundField DataField="sitio_web" HeaderText="Sitio Web" />
                    <asp:BoundField DataField="clave" HeaderText="Clave" />
                </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

