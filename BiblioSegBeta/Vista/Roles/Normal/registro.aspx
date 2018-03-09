<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Normal/MasterNormal.master" AutoEventWireup="true" CodeFile="~/Logica/Normal/registro.aspx.cs" Inherits="Vista_Roles_Normal_registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 18px;
        }
        .auto-style3 {
            height: 18px;
            text-align: center;
        }
        .auto-style4 {
            width: 155px;
        }
        .auto-style5 {
            height: 18px;
            width: 155px;
        }
        .auto-style6 {
        }
        .auto-style7 {
            height: 18px;
            width: 193px;
        }
        .auto-style8 {
            width: 155px;
            height: 25px;
        }
        .auto-style9 {
            width: 193px;
            height: 25px;
        }
        .auto-style10 {
            text-align: center;
            height: 25px;
        }
        .auto-style11 {
            height: 25px;
        }
        .auto-style12 {
            width: 155px;
            height: 40px;
        }
        .auto-style13 {
            width: 193px;
            height: 40px;
        }
        .auto-style14 {
            height: 40px;
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

