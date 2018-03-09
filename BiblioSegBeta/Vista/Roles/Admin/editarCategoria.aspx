<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="/logica/Admin/editarCategoria.aspx.cs" Inherits="Vista_Roles_Admin_editarCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="muestraCategorias" DataKeyNames="id_cat">
    <Columns>
        <asp:BoundField DataField="nombre" HeaderText="Nombre Categoria" />
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="muestraCategorias" runat="server" SelectMethod="mostrar_categorias" TypeName="DAOAdmin" DeleteMethod="eliminar_categoria" UpdateMethod="editar_categoria">
    <DeleteParameters>
        <asp:Parameter Name="id_cat" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="nombre" Type="String" />
        <asp:Parameter Name="id_cat" Type="Int32" />
    </UpdateParameters>
    </asp:ObjectDataSource>
    
</asp:Content>

