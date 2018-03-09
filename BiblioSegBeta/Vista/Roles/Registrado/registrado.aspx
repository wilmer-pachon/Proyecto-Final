<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" AutoEventWireup="true" CodeFile="~/logica/Registrado/registrado.aspx.cs" Inherits="Vista_Roles_Registrado_registrado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 223px;
    }
        .auto-style3 {
            width: 791px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
    <table class="auto-style1">
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="muestra_usuario" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" DataKeyNames="id">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="correo" HeaderText="Correo" />
                        <asp:BoundField DataField="clave" HeaderText="Clave" />
                        <asp:BoundField DataField="sweb" HeaderText="Sweb" />
                        <asp:TemplateField HeaderText="Foto Perfil" >
                            <EditItemTemplate>
                                <asp:FileUpload ID="foto" runat="server" />
                                <asp:Image width="50px" ID="Image1" runat="server" ImageUrl='<%#  Eval("foto") %>' />
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Image width="50px" ID="Image1" runat="server" ImageUrl='<%#  Eval("foto") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="id" HeaderText="ID" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="auto-style3">
                <asp:ObjectDataSource ID="muestra_usuario" runat="server" DeleteMethod="eliminausuario" SelectMethod="mostrarUsuarios" TypeName="insertusu" UpdateMethod="modificarUsuarios">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <SelectParameters>
                        <asp:Parameter DefaultValue="" Name="user" Type="Object" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="nombre" Type="String" />
                        <asp:Parameter Name="correo" Type="String" />
                        <asp:Parameter Name="clave" Type="String" />
                        <asp:Parameter Name="sweb" Type="String" />
                        <asp:Parameter Name="foto" Type="String" />
                        <asp:Parameter Name="id" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
    </table>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="json">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="json" HeaderText="JSON" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="json" runat="server" DeleteMethod="eliminarJson" SelectMethod="obtenerJson" TypeName="insertusu" UpdateMethod="modificarJson">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="id" Type="Int32" />
                <asp:Parameter Name="json" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    <br />
</p>
<p>
</p>
<p>
</p>
</asp:Content>

