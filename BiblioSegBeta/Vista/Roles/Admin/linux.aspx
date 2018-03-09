<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/linux.aspx.cs" Inherits="Vista_Roles_Admin_linux" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            width: 300px;
        }
        </style>
    <title>GNU/Linux</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="muestraCategorias" DataKeyNames="id_cat" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
    <Columns>
        <asp:BoundField DataField="nombre" HeaderText="Nombre Categoria" />
        <asp:TemplateField HeaderText="ID" Visible="False">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_cat") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_cat") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="muestraCategorias" runat="server" SelectMethod="mostrar_categorias" TypeName="DAOAdmin"></asp:ObjectDataSource>
    
</asp:Content>
