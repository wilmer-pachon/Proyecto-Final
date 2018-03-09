<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/Roles/Admin/MasterAdmin.master" AutoEventWireup="true" CodeFile="~/logica/Admin/muestra_win.aspx.cs" Inherits="Vista_Roles_Admin_muestra_win" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-right: 44;
        }
        .auto-style3 {
            margin-right: 69px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>    <asp:GridView ID="GridView1" runat="server" Height="208px" Width="409px" AutoGenerateColumns="False" CellPadding="4" DataSourceID="herramienta_normal" ForeColor="#333333" GridLines="None" >
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
                            <asp:Label ID="Label1" runat="server"  Text='<%# Bind("id_herramienta") %>'></asp:Label>
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
                            <table class="auto-style1">
                    <tr>
                        <td class="auto-style5">Dar Puntos</td>
                        <td class="auto-style6">
                            <asp:ImageButton ID="puntospositivos" runat="server" Height="21px" ImageUrl="~/Vista/images/positivo.png" Width="27px" OnClick="puntospositivos_Click1" />
                        </td>
                        <td class="auto-style2">
                            <asp:ImageButton ID="puntosnegativos" runat="server" Height="21px" ImageUrl="~/Vista/images/negativo.png" Width="27px" OnClick="puntosnegativos_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td class="auto-style6">
                            
                            <asp:Label ID="lb_puntos" runat="server" Visible="False"></asp:Label>
                            
                        </td>
                        <td class="auto-style2">
                            
                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="muetrapuntos">
                                <Columns>
                                    <asp:BoundField DataField="sum" HeaderText="Puntos" ShowHeader="False" />
                                </Columns>
                            </asp:GridView>
                            <asp:ObjectDataSource ID="muetrapuntos" runat="server" SelectMethod="traerPuntos" TypeName="DAOHerramienta">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="lb_puntos" Name="id_h" PropertyName="Text" Type="Int64" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            
                        </td>
                    </tr>
                </table>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <div id="L">
                    
               
                      <label for="textarea"></label>
                      <center>
                        <p>
                          <textarea ID="tarea" runat="server" cols="80" rows="5" TextMode="MultiLine">   </textarea>
                        </p>
                        <p>
                          <asp:Button ID="comentar" runat="server" CommandArgument="id_herramienta" CommandName="comentar" Text="Comentar" OnClick="comentar_Click" />
                        </p>
                      </center>

                            <br />
                      <asp:GridView ID="gridcomentarios" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="muestra_comentarios" GridLines="Horizontal" Height="177px"  Width="431px" CssClass="auto-style3" >
                          <Columns>
                              <asp:BoundField DataField="id_comenta" HeaderText="idcom" Visible="False" />
                              <asp:BoundField DataField="comenta" HeaderText="COMENTARIO" />
                              <asp:BoundField DataField="nom_user" HeaderText="Nombre de Usuario" Visible="False" />
                              <asp:TemplateField HeaderText="responder" ShowHeader="False">
                                  <ItemTemplate>
                                      &nbsp;&nbsp;&nbsp;<asp:ObjectDataSource ID="muestra_usu" runat="server" SelectMethod="muestra_usuarios" TypeName="DAOcomenta">
                                          <SelectParameters>
                                              <asp:Parameter Name="user" Type="Object" />
                                          </SelectParameters>
                                      </asp:ObjectDataSource>
                                      <br />
                                      <asp:TextBox ID="resp" runat="server" Height="102px" Width="337px">&nbsp;&nbsp;&nbsp;&nbsp;     </asp:TextBox>
                                      <br />
                                      <asp:Button ID="respuesta" CommandArgument="id_comenta" CommandName="respuesta" runat="server" OnClick="respuesta_Click" Text="Responder" />
                                      <br />
                                  </ItemTemplate>
                              </asp:TemplateField>
                              <asp:TemplateField HeaderText="Respuestas">
                                  <ItemTemplate>
                                      <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="id_user" GridLines="Horizontal" Height="139px" Width="179px" DataSourceID="ver_respuesta">
                                          <Columns>
                                              <asp:BoundField DataField="respuestas" HeaderText="Respuesta Comentario" />
                                          </Columns>
                                          <FooterStyle BackColor="White" ForeColor="#333333" />
                                          <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                                          <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                                          <RowStyle BackColor="White" ForeColor="#333333" />
                                          <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                                          <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                          <SortedAscendingHeaderStyle BackColor="#487575" />
                                          <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                          <SortedDescendingHeaderStyle BackColor="#275353" />
                                      </asp:GridView>
                                      <asp:ObjectDataSource ID="ver_respuesta" runat="server" SelectMethod="muestra_respuestas" TypeName="DAOcomenta">
                                          <SelectParameters>
                                              <asp:SessionParameter Name="id_comenta" SessionField="idcomen" Type="Int32" />
                                          </SelectParameters>
                                      </asp:ObjectDataSource>
                                      <asp:ObjectDataSource ID="muestra_user" runat="server" SelectMethod="muestra_usuarios" TypeName="DAOcomenta">
                                          <SelectParameters>
                                              <asp:Parameter Name="user" Type="Object" />
                                          </SelectParameters>
                                      </asp:ObjectDataSource>
                                  </ItemTemplate>
                              </asp:TemplateField>
                              <asp:TemplateField HeaderText="ID" Visible="False">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id_comenta") %>'></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:Label ID="Label1" runat="server" Text='<%# Bind("id_comenta") %>'></asp:Label>
                                  </ItemTemplate>
                              </asp:TemplateField>
                          </Columns>
                          <FooterStyle BackColor="White" ForeColor="#333333" />
                          <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                          <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                          <RowStyle BackColor="White" ForeColor="#333333" />
                          <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                          <SortedAscendingCellStyle BackColor="#F7F7F7" />
                          <SortedAscendingHeaderStyle BackColor="#487575" />
                          <SortedDescendingCellStyle BackColor="#E5E5E5" />
                          <SortedDescendingHeaderStyle BackColor="#275353" />
                      </asp:GridView>
                      <asp:ObjectDataSource ID="muestra_comentarios" runat="server" SelectMethod="extrae_comentario" TypeName="DAOcomenta">
                          <SelectParameters>
                              <asp:SessionParameter Name="id_herramienta" SessionField="id_herramienta" Type="Int32" DefaultValue="" />
                          </SelectParameters>
                      </asp:ObjectDataSource>
                      <br />
                      <br />

                            <br />
                    
                </div>
                                          
                
                                            


                <br />
                	
                <br />
               
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="herramienta_normal"  runat="server" SelectMethod="muestra_herramienta_normal" TypeName="DAOHerramienta">
        <SelectParameters>
            <asp:SessionParameter Name="id_herramienta" SessionField="id_herramienta" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
