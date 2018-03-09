<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Moderador/MasterModerador.master" AutoEventWireup="true" CodeFile="~/logica/Moderador/biblioteca.aspx.cs" Inherits="Vista_Roles_Moderador_biblioteca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>BIBLIOTECA</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 215px;
            height: 162px;
            text-align: center;
            display:block;
            margin:auto;
        }
        .auto-style3 {
            width: 189px;
            height: 191px;
            text-align: center;
            display:block;
            margin:auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table align="center" class="auto-style1">
        <tr>
            <td class="txt-center">GNU/LINUX</td>
            <td class="txt-center">WINDOWS</td>
        </tr>
        <tr>
            <td aling="center">
                <a href="linux.aspx"><img class="auto-style2" src="/Vista/images/GNULinux.png" /></a></td>
            <td>
                <a href="windows.aspx"><img class="auto-style3" src="/Vista/images/Windows.png" /></a></td>
        </tr>
    </table>

</asp:Content>
