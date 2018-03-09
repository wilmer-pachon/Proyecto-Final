<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" AutoEventWireup="true" CodeFile="~/logica/Registrado/Muestrah_Linux.aspx.cs" Inherits="Vista_Roles_Registrado_Muestrah_Linux" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" Height="174px" Width="401px" AutoGenerateColumns="False" CellPadding="3" DataSourceID="muestra_H_linux" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" ForeColor="Black">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="HERRAMIENTA" />
                    <asp:BoundField DataField="fecha" HeaderText="FECHA" />
                    <asp:BoundField DataField="url_sitio" HeaderText="SITIO WEB" />
                    <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                    <asp:BoundField DataField="id_so" HeaderText="SISTEMA OPERATIVO" />
                    <asp:ImageField DataImageUrlField="foto" HeaderText="IMAGEN">
                    </asp:ImageField>
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
    <asp:ObjectDataSource ID="muestra_H_linux" runat="server" SelectMethod="muestra_linux" TypeName="DAOAdmin">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="id_cat" SessionField="id_cat" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

