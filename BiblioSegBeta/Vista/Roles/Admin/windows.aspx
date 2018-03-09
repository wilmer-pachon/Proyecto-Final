<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/windows.aspx.cs" Inherits="Vista_Roles_Admin_Windows" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
            width: 300px;
        }
        .auto-style3 {
            width: 300px;
        }
        .auto-style4 {
            width: 250px;
            height: 202px;
            text-align: center;
            display:block;
            margin:auto;
        }
        .auto-style5 {
            width: 250px;
            height: 202px;
            text-align: center;
            display:block;
            margin:auto;
        }
        .auto-style6 {
            width: 250px;
            height: 202px;
            text-align: center;
            display:block;
            margin:auto;
        }
    </style>
    <title>Windows</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="muestraCategorias" OnRowCommand="GridView1_RowCommand1" OnRowDataBound="GridView1_RowDataBound">
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
