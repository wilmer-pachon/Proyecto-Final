<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/editarUsuario.aspx.cs" Inherits="Vista_Roles_Admin_editarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="EDITAR/ELIMINAR/BLOQUEAR USUARIOS"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_user" DataSourceID="Muestra_usuarios" OnRowCommand="GridView1_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar"></asp:LinkButton>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="id_user" HeaderText="id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="correo" HeaderText="correo" />
            <asp:BoundField DataField="nom_user" HeaderText="nom user" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:TemplateField HeaderText="Activo">
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandArgument='<%#Bind("id_user") %>' CommandName="activo" Text="Activo" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Bloqueados" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" CausesValidation="false" CommandArgument='<%#Bind("id_user") %>' CommandName="bloqueado" Text="Bloqueado" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
            <asp:ObjectDataSource ID="Muestra_usuarios" runat="server" SelectMethod="enviar_usuario" TypeName="DAORegistrar" UpdateMethod="editar_usuario" DeleteMethod="eliminaUsuario">
                <DeleteParameters>
                    <asp:Parameter Name="id_user" Type="Int32" />
                </DeleteParameters>
                <SelectParameters>
                    <asp:Parameter Name="user" Type="Object" />
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
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

