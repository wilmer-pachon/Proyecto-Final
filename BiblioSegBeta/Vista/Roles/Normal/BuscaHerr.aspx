<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Normal/MasterNormal.master" AutoEventWireup="true" CodeFile="~/logica/Normal/BuscaHerr.aspx.cs" Inherits="Vista_Roles_Normal_BuscaHerr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:TextBox ID="Txt_Buscar" runat="server"></asp:TextBox>
                <asp:Button ID="bt_buscar" runat="server" OnClick="bt_buscar_Click" Text="Buscar" />
            <br />
                <asp:GridView ID="Gv_busqueda" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_BuscarHerr">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    </Columns>
                </asp:GridView>
            <asp:ObjectDataSource ID="ODS_BuscarHerr" runat="server" SelectMethod="busca" TypeName="Logica.Normal.L_BuscaHerr">
                <SelectParameters>
                    <asp:Parameter Name="buscar" Type="String" />
                </SelectParameters>
    </asp:ObjectDataSource>
            <br />
    <br />
    <br />
    <br />
</asp:Content>

