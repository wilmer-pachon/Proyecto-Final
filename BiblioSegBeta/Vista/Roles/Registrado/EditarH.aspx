<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" AutoEventWireup="true" CodeFile="~/logica/Registrado/EditarH.aspx.cs" Inherits="Vista_Roles_Registrado_EditarH" %>

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
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CssClass="auto-style12" DataKeyNames="id_herramienta" DataSourceID="carga_herramienta" ForeColor="Black" GridLines="Vertical" Height="16px" Width="581px" OnRowUpdating="GridView1_RowUpdating">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
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
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="Gray" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="carga_herramienta" runat="server" DeleteMethod="eliminaHerramienta" SelectMethod="muestraHerramienta" TypeName="DAOHerramienta" UpdateMethod="editarHerramienta">
                        <DeleteParameters>
                            <asp:Parameter Name="id_herramienta" Type="Int32" />
                        </DeleteParameters>
                        <SelectParameters>
                            <asp:Parameter Name="user" Type="Object" />
                        </SelectParameters>
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

