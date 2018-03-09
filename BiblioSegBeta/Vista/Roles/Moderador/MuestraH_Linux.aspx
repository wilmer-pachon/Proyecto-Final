<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/MuestraH_Linux.aspx.cs" Inherits="Vista_Roles_Moderador_MuestraH_Linux" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" Height="174px" Width="401px" AutoGenerateColumns="False" CellPadding="3" DataSourceID="muestra_H_linux" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="HERRAMIENTA" />
                    <asp:BoundField DataField="fecha" HeaderText="FECHA" />
                    <asp:BoundField DataField="url_sitio" HeaderText="SITIO WEB" />
                    <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                    <asp:BoundField DataField="id_so" HeaderText="SISTEMA OPERATIVO" />
                    <asp:ImageField DataImageUrlField="foto" HeaderText="IMAGEN">
                    </asp:ImageField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <asp:ObjectDataSource ID="muestra_H_linux" runat="server" SelectMethod="muestra_linux" TypeName="DAOAdmin">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="id_cat" SessionField="id_cat" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
