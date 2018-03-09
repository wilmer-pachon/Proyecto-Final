<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/ReporteUsuarios.aspx.cs" Inherits="Vista_Roles_Admin_ReporteUsuarios" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <CR:CrystalReportViewer ID="CRV_Herramienta" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_Herramienta" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
    <CR:CrystalReportSource ID="CRS_Herramienta" runat="server">
        <Report FileName="C:\Users\wilme\Desktop\SEXTO SEMESTRE\ING DE SOFTWARE\PROYECTO DEFINITIVO\nelson\BiblioSegBeta\Vista\Reportes\ReporteH.rpt">
        </Report>
    </CR:CrystalReportSource>
<br />
<br />
<br />
</asp:Content>

