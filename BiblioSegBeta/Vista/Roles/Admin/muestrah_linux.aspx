<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="/logica/Admin/muestrah_linux.aspx.cs" Inherits="logica_Admin_muestrah_linux" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" Height="174px" Width="401px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="muestra_H_linux" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="HERRAMIENTA" />
                    <asp:BoundField DataField="fecha" HeaderText="FECHA" />
                    <asp:BoundField DataField="url_sitio" HeaderText="SITIO WEB" />
                    <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                    <asp:BoundField DataField="id_so" HeaderText="SISTEMA OPERATIVO" />
                    <asp:ImageField DataImageUrlField="foto" HeaderText="IMAGEN">
                    </asp:ImageField>
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:ObjectDataSource ID="muestra_H_linux" runat="server" SelectMethod="muestra_linux" TypeName="DAOAdmin">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="id_cat" SessionField="id_cat" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

