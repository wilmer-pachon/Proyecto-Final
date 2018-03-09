<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/Logica/Admin/agregarUsuario.aspx.cs" Inherits="Vista_Roles_Admin_agregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <title>Agregar Herramienteas</title>
     <style type="text/css">
         .auto-style1 {
             height: 25px;
         }
         .auto-style2 {
             text-align: center;
             height: 25px;
         }
     </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6" colspan="2">
                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="REGISTRARSE"></asp:Label>
                <br />
                <br />
                <br />
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">*Nombre</td>
            <td class="txt-center">
                <asp:TextBox ID="txt_nombre" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_nombre" runat="server" ControlToValidate="txt_nombre" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style7">* Nombre de usuario:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txt_nomuser" runat="server" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_nom_user" runat="server" ControlToValidate="txt_nomuser" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9">*Correo:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txt_correo" runat="server" TextMode="Email" MaxLength="30"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_email" runat="server" ControlToValidate="txt_correo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">*Sitio web:</td>
            <td class="txt-center">
                <asp:TextBox ID="txt_sitio" runat="server" TextMode="Url" MaxLength="100"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RV_Sitio" runat="server" ControlToValidate="txt_sitio" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">*Clave:</td>
            <td class="txt-center">
                <asp:TextBox ID="txt_clave" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_clave" runat="server" ControlToValidate="txt_clave" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">*Confirmar Clave:</td>
            <td class="txt-center">
                <asp:TextBox ID="txt_confirmar" runat="server" TextMode="Password" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RV_confirmar" runat="server" ControlToValidate="txt_confirmar" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">Imagen de perfil:</td>
            <td class="txt-center">
                <asp:FileUpload ID="fuPerfil" runat="server" />              
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">Seleccione Rol:</td>
            <td class="txt-center">
                <asp:DropDownList ID="DropDownRol" runat="server" DataSourceID="ObtenerRol" DataTextField="nom_rol">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObtenerRol" runat="server" SelectMethod="obtenerRol" TypeName="DAOUsuario">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="nom_rol" Name="nombre" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="txt-center">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="txt-center"><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Txt_Confirmar" ControlToValidate="Txt_Clave" ErrorMessage="CONTRASEÑA NO COINCIDE" ForeColor="Red"></asp:CompareValidator></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="txt-center">
                <br />
                <br />
                <br />
                <asp:Button ID="bt_registrarse" runat="server" Text="Registrarse" style="text-align: center; height: 26px;" OnClick="bt_registrarse_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style13"></td>
            <td class="auto-style14"></td>
            <td class="auto-style14"></td>
        </tr>
    </table>

</asp:Content>

