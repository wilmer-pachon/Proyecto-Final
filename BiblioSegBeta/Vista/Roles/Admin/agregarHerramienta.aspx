<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="/Logica/Admin/agregarHerramienta.aspx.cs" Inherits="Vista_Roles_Admin_agregarHerramienta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <center>
   <table align="center" cellpadding="2" cellspacing="3" class="auto-style2" style="background-color: #808080; border-style: solid; border-width: medium">
            <tr>
                <td colspan="5" style="text-align: center">Agregar Herramientas</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Nombre:</td>
                <td>
                    <asp:TextBox ID="txtnombre" runat="server" Height="22px" MaxLength="15"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RV_NombreH" runat="server" ControlToValidate="txtnombre" ErrorMessage="Completar Campo" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Sitio Web:</td>
                <td>
                    <asp:TextBox ID="txtsitio" runat="server" TextMode="Url"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RV_Sitio" runat="server" ControlToValidate="txtsitio" ErrorMessage="Completar Campo" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">Fecha de lanzamiento:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Vista/images/calendario.png"  Width="20px" />
                    <asp:RequiredFieldValidator ID="RV_Fecha" runat="server" ControlToValidate="txtfecha" ErrorMessage="Completar Campo" ForeColor="White"></asp:RequiredFieldValidator>
                    <asp:Calendar ID="fecha" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="fecha_SelectionChanged" style="text-align: left" VisibleDate="2017-10-04" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar> 
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Descripcion:</td>
                <td>
                    <asp:TextBox ID="txtdescripcion" runat="server" Columns="50" Rows="10" TextMode="MultiLine" Width="347px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RV_Descripcion" runat="server" ControlToValidate="txtdescripcion" ErrorMessage="Completar Campo" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">Categoria:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownCat" runat="server" AutoPostBack="True" DataSourceID="muestra_categoria" DataTextField="nombre" DataValueField="id_cat"  >
                        <asp:ListItem>     </asp:ListItem>
                        <asp:ListItem>Recopilación de información</asp:ListItem>
                        <asp:ListItem>Evaluación de la vulnerabilidad</asp:ListItem>
                        <asp:ListItem>Aplicaciones Web</asp:ListItem>
                        <asp:ListItem>Evaluación de base de datos</asp:ListItem>
                        <asp:ListItem> Ataque a contraseñas</asp:ListItem>
                        <asp:ListItem>Ataques inalámbricos</asp:ListItem>
                        <asp:ListItem>Herramientas de explotación</asp:ListItem>
                        <asp:ListItem>Sniffing y spoofing</asp:ListItem>
                        <asp:ListItem>Post-explotación</asp:ListItem>
                        <asp:ListItem>Ingeniería inversa</asp:ListItem>
                        <asp:ListItem>Prueba de estrés</asp:ListItem>
                        <asp:ListItem>Hardware de hacking</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RV_Cat" runat="server" ControlToValidate="DropDownCat" ErrorMessage="Hacer Eleccion" ForeColor="White"></asp:RequiredFieldValidator>
                    <asp:ObjectDataSource ID="muestra_categoria" runat="server" SelectMethod="muestraCategoria" TypeName="DAOHerramienta"></asp:ObjectDataSource>
                </td>
                <td class="auto-style1">
                    </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Lenguaje:</td>
                <td>
                    <asp:DropDownList ID="DropDownLen" runat="server" DataSourceID="muestra_lenguaje" DataTextField="nombre" DataValueField="id_len" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>JavaScript</asp:ListItem>
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>PHP</asp:ListItem>
                        <asp:ListItem>Python</asp:ListItem>
                        <asp:ListItem>C++</asp:ListItem>
                        <asp:ListItem>C#</asp:ListItem>
                        <asp:ListItem>Ruby</asp:ListItem>
                        <asp:ListItem>C</asp:ListItem>
                        <asp:ListItem>Perl</asp:ListItem>
                        <asp:ListItem>Shell</asp:ListItem>
                        <asp:ListItem>Visual Basic</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RV_Lenguaje" runat="server" ControlToValidate="DropDownLen" ErrorMessage="Hacer Eleccion" ForeColor="White"></asp:RequiredFieldValidator>
                    <asp:ObjectDataSource ID="muestra_lenguaje" runat="server" SelectMethod="muestraLenguaje" TypeName="DAOHerramienta"></asp:ObjectDataSource>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Sistema Operativo:</td>
                <td>
                    <asp:DropDownList ID="DropDownOS" runat="server" AutoPostBack="True">
                        <asp:ListItem>---Selecciones---</asp:ListItem>
                        <asp:ListItem>GNU/Linux</asp:ListItem>
                        <asp:ListItem>Windows</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RV_So" runat="server" ControlToValidate="DropDownOS" ErrorMessage="Hacer Eleccion" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>Logo/Imagen:</td>
                <td>
                    <asp:FileUpload ID="foto" runat="server" />
                    <asp:RequiredFieldValidator ID="RV_Imagen" runat="server" ControlToValidate="foto" ErrorMessage="Ingresar Imagen" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4" style="text-align: right">
                    <asp:Button ID="guardar" runat="server" Text="Enviar" OnClick="guardar_Click" style="margin-bottom: 2px" />
                </td>
                <td class="auto-style1">
                    </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4" style="text-align: right">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4" style="text-align: right">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4" style="text-align: right">
                    &nbsp;</td>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            </table></center>
</asp:Content>

