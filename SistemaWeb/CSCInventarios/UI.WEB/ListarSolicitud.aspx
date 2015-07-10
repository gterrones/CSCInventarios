<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarSolicitud.aspx.cs" Inherits="UI.WEB.ListarSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 48px;
        }
        .style4
        {
            width: 48px;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="style2">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <strong>Estacion</strong></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    DataSourceID="odsLeerTodasLasEstaciones" DataTextField="estacion_nombre" 
                    DataValueField="estacion_id" Height="22px" style="margin-left: 15px" 
                    Width="252px">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="odsLeerTodasLasEstaciones" runat="server" 
                    onobjectcreating="odsLeerTodasLasEstaciones_ObjectCreating" 
                    SelectMethod="LeerTodasLasEstaciones" TypeName="CSCInventarios.BL.EstacionBL">
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
    <table class="style2">
        <tr>
            <td>
                <asp:Button ID="btnNuevaSolicitud" runat="server" 
                    onclick="btnNuevaSolicitud_Click" Text="Nueva Solicitud" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
