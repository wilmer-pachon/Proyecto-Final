<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/moderarH.aspx.cs" Inherits="Vista_Roles_Moderador_moderarH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>MODERAR CONTENIDO</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="APROBACION DE CONTENIDO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="id_herramienta" DataSourceID="carga_herramienta" Height="16px" Width="45px" OnRowCommand="GridView1_RowCommand1" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:TemplateField HeaderText="id">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="url_sitio" HeaderText="Sitio Web" />
                        <asp:TemplateField HeaderText="Fecha">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("fecha") %>'></asp:TextBox>
                                <br />
                                <asp:Calendar ID="fecha" runat="server"></asp:Calendar>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("fecha") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="id_cat" HeaderText="Categoria" />
                        <asp:BoundField DataField="id_lenguaje" HeaderText="Leguaje" />
                        <asp:BoundField DataField="id_so" HeaderText="Sistema Operativo" />
                        <asp:TemplateField HeaderText="Imagen">
                            <EditItemTemplate>
                                <asp:FileUpload ID="foto" runat="server" />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("foto") %>' Width="50px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Aprobado" ShowHeader="False">
                            <ItemTemplate>
                                <asp:Button ID="aprobar" CommandArgument=  '<%# Bind("id_herramienta") %>'    runat="server" Text="Aprobado" Height="25px" Width="89px" CommandName="aprobar"  />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="No aprobado">
                            <ItemTemplate>
                                <asp:Button ID="desaprobar"   CommandArgument=  '<%# Bind("id_herramienta") %>' runat  ="server" CausesValidation="false" CommandName="desaprobar" Text="No Aprobado"  />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle ForeColor="#4A3C8C" BackColor="#E7E7FF" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                </asp:GridView>
                <asp:ObjectDataSource ID="carga_herramienta" runat="server" DeleteMethod="eliminaHerramienta" SelectMethod="pendientes" TypeName="DAOHerramienta" UpdateMethod="aprobada">
                    <DeleteParameters>
                        <asp:Parameter Name="id_herramienta" Type="Int32" />
                    </DeleteParameters>
                    <SelectParameters>
                        <asp:Parameter Name="user" Type="Object" DefaultValue="" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="id_herramienta" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:ObjectDataSource ID="obtener_herramienta" runat="server" SelectMethod="pendientes" TypeName="DAOHerramienta">
                    <SelectParameters>
                        <asp:Parameter Name="user" Type="Object" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
&nbsp;
</asp:Content>

