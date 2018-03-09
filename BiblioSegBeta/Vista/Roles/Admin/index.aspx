<%@ Page Title=""  enableEventValidation="false" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/index.aspx.cs" Inherits="Vista_Roles_Admin_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="obtener_herramienta" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="698px" Width="786px" OnRowCommand="GridView2_RowCommand" OnRowDataBound="GridView2_RowDataBound">
                    <Columns>
                        <asp:CommandField />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="url_sitio" HeaderText="Sitio Web" />
                        <asp:TemplateField HeaderText="Fecha" Visible="False">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("fecha") %>'></asp:TextBox>
                                <asp:Calendar ID="fecha" runat="server"></asp:Calendar>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="id_cat" HeaderText="Categoria" Visible="False" />
                        <asp:BoundField DataField="id_lenguaje" HeaderText="Lenguaje" Visible="False" />
                        <asp:BoundField DataField="id_so" HeaderText="Sistema Operativo" />
                        <asp:TemplateField HeaderText="Imagen">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("foto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("foto") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID" Visible="False">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="obtener_herramienta" runat="server" SelectMethod="aprobadas" TypeName="DAOHerramienta">
                    <SelectParameters>
                        <asp:Parameter Name="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
