<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/ReporteCategorias.aspx.cs" Inherits="Vista_Roles_Admin_ReporteCategorias" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <br />
    <CR:CrystalReportViewer ID="CRV_Categorias" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" ReportSourceID="CRS_Categorias" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="1104px" />
    <CR:CrystalReportSource ID="CRS_Categorias" runat="server">
        <Report FileName="C:\Users\wilme\Desktop\SEXTO SEMESTRE\ING DE SOFTWARE\PROYECTO DEFINITIVO\nelson\BiblioSegBeta\Vista\Reportes\ReporteCat.rpt">
        </Report>
    </CR:CrystalReportSource>
<br />
<p>
</p>
</asp:Content>

