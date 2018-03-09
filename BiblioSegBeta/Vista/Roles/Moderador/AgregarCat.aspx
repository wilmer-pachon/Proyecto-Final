<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/AgregarCat.aspx.cs" Inherits="Vista_Roles_Moderador_AgregarCat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table align="center" cellpadding="2" cellspacing="3" class="auto-style2" style="background-color: #808080; border-style: solid; border-width: medium">
            <tr>
                <td colspan="5" style="text-align: center">Agregar Categoria</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Nombre Categoria:</td>
                <td>
                    <asp:TextBox ID="txtnombre_cat" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RV_Categoria" runat="server" ControlToValidate="txtnombre_cat" ErrorMessage="Agregar" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
           
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4" style="text-align: right">
                    <asp:Button ID="guardar" runat="server" Text="Enviar" OnClick="guardar_Click" />
                </td>
                <td class="auto-style4">
                    </td>
                <td class="auto-style4"></td>
            </tr>
            </table></center>
</asp:Content>

