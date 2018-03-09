<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/ReportesGraficas.aspx.cs" Inherits="Vista_Roles_Admin_ReportesGraficas" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <CR:CrystalReportViewer ID="CRV_Graficas" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" ReportSourceID="CRS_Graficas" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="1104px" />
    <CR:CrystalReportSource ID="CRS_Graficas" runat="server">
        <Report FileName="C:\Users\wilme\Desktop\SEXTO SEMESTRE\ING DE SOFTWARE\PROYECTO DEFINITIVO\nelson\BiblioSegBeta\Vista\Reportes\ReporteGraf.rpt">
        </Report>
    </CR:CrystalReportSource>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

