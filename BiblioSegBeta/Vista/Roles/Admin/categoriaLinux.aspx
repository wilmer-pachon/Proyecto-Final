<%@ Page Title=""  EnableEventValidation="false" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master"  AutoEventWireup="true"   CodeFile="/logica/Admin/categoriaLinux.aspx.cs" Inherits="Vista_Roles_Admin_categoriaLinux" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataKeyNames="id_cat" DataSourceID="muestra_cat_linux" Height="234px" Width="417px" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
        <Columns>
            <asp:TemplateField>
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("foto") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("foto") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Imagen">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("foto") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("foto") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ID" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("id_cat") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_cat") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="muestra_cat_linux" runat="server" SelectMethod="muestra_linux" TypeName="DAOAdmin">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="id_cat" SessionField="id_cat" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

