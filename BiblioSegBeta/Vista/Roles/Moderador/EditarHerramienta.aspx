<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/EditarHerramienta.aspx.cs" Inherits="Vista_Roles_Moderador_EditarHerramienta" %>

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
        <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style12" DataKeyNames="id_herramienta" DataSourceID="carga_herramienta" ForeColor="#333333" GridLines="None" Height="16px" Width="581px" OnRowUpdating="GridView1_RowUpdating">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="url_sitio" HeaderText="Sitio Web" />
                            <asp:TemplateField HeaderText="Fecha">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("fecha") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="id_cat" HeaderText="Categoria" />
                            <asp:BoundField DataField="id_lenguaje" HeaderText="Lenguaje" />
                            <asp:BoundField DataField="id_so" HeaderText="Sistema Operativo" />
                            <asp:TemplateField HeaderText="Imagen">
                                <EditItemTemplate>
                                    <asp:FileUpload ID="foto" runat="server" />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("foto") %>' Width="50px" />
                                </ItemTemplate>
                            </asp:TemplateField>
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
                    <asp:ObjectDataSource ID="carga_herramienta" runat="server" DeleteMethod="eliminaHerramienta" SelectMethod="muestra_herramientas_normal" TypeName="DAOHerramienta" UpdateMethod="editarHerramienta">
                        <DeleteParameters>
                            <asp:Parameter Name="id_herramienta" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="nombre" Type="String" />
                            <asp:Parameter Name="url_sitio" Type="String" />
                            <asp:Parameter Name="fecha" Type="DateTime" />
                            <asp:Parameter Name="descripcion" Type="String" />
                            <asp:Parameter Name="id_cat" Type="Int32" />
                            <asp:Parameter Name="id_lenguaje" Type="Int32" />
                            <asp:Parameter Name="id_so" Type="String" />
                            <asp:Parameter Name="foto" Type="String" />
                            <asp:Parameter Name="id_herramienta" Type="Int32" />
                        </UpdateParameters>
                    </asp:ObjectDataSource>
                    <br />
                    </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
                    <br />
                    <br />
                </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

