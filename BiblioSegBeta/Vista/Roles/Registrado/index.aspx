<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Registrado/MasterRegistrado.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="/logica/Registrado/index.aspx.cs" Inherits="Vista_Roles_Registrado_index" %>


<script runat="server">

    
</script>


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
            <td>    <asp:GridView ID="GridView1" runat="server" Height="208px" Width="409px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="herramienta_normal" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand" DataKeyNames="id_herramienta">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="nombre" HeaderText="HERRAMIENTA" />
                    <asp:BoundField DataField="fecha" HeaderText="FECHA" />
                    <asp:BoundField DataField="url_sitio" HeaderText="SITIO WEB" />
                    <asp:BoundField DataField="descripcion" HeaderText="DESCRIPCION" />
                    <asp:BoundField DataField="id_so" HeaderText="SISTEMA OPERATIVO" />
                    <asp:ImageField DataImageUrlField="foto" HeaderText="IMAGEN">
                    </asp:ImageField>
                    <asp:TemplateField HeaderText="ID" Visible="False">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_herramienta") %>'></asp:Label>
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
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
               
                <br />
                	
                <br />
               
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="herramienta_normal"  runat="server" SelectMethod="aprobadas" TypeName="DAOHerramienta">
        <SelectParameters>
            <asp:Parameter Name="user" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
