<%@ Page Title="" EnableEventValidation="false"  Language="C#" MasterPageFile="~/Vista/Roles/Normal/MasterNormal.master" AutoEventWireup="true" CodeFile="/Logica/Normal/index.aspx.cs" Inherits="Vista_Roles_Normal_index" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            background-color: #0066FF;
        }
        .auto-style2 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table class="auto-style2">
        <tr>
            <td>
                <asp:TextBox ID="Txt_Buscar" runat="server"></asp:TextBox>
                <asp:Button ID="bt_buscar" runat="server" OnClick="bt_buscar_Click" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="Gv_busqueda" runat="server" AutoGenerateColumns="False" DataSourceID="mostrar_herramientas" Height="109px" Width="79px">
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />

    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataSourceID="mostrar_herramientas" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="id_herramienta" GridLines="Vertical" Height="427px" Width="717px" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" >
        <Columns>
            <asp:TemplateField HeaderText="Herramientas Destacadas">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server"  Text='<%# Bind("nombre") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1"  runat="server"  Text='<%# Bind("nombre") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Imagen">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1"  runat="server" Text='<%# Eval("foto") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" width="70px" runat="server" ImageUrl='<%# Eval("foto") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ID" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" BorderColor="#3399FF" />
        <SelectedRowStyle BackColor="#006600" Font-Bold="True" ForeColor="#00CC99" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    <asp:ObjectDataSource ID="mostrar_herramientas" runat="server" SelectMethod="mostra_herramienta_index" TypeName="Logica.Normal.LogiIndex">
    </asp:ObjectDataSource>

    <br />
    <br />

    <br />
    <strong>
    <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="29px" OnClick="Button1_Click" Text="Crea tu POST!" Width="137px" />
    </strong>
    <br />

</asp:Content>




