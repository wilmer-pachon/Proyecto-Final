<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/linux.aspx.cs" Inherits="Vista_Roles_Moderador_linux" %>

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
    <title>GNU/Linux</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="muestraCategorias">
    <Columns>
        <asp:BoundField DataField="nombre" HeaderText="Nombre Categoria" />
    </Columns>
</asp:GridView>
<asp:ObjectDataSource ID="muestraCategorias" runat="server" SelectMethod="mostrar_categorias" TypeName="DAOAdmin"></asp:ObjectDataSource>
    
</asp:Content>
