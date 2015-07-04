<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SolicitarMaterial.aspx.cs" Inherits="UI.WEB.SolicitarMaterial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style2
    {
        font-size: large;
    }
    .style3
    {
        width: 100%;
    }
    .style4
    {
        width: 60px;
    }
    .style5
    {
        width: 128px;
    }
    .style7
    {
        width: 60px;
        font-size: medium;
    }
    .style8
    {
        width: 44px;
        font-size: medium;
    }
    .style10
    {
        width: 97px;
        font-size: medium;
    }
        .style14
        {
            font-size: medium;
        }
        .style15
        {
            width: 76px;
        }
        .style18
        {
            width: 97px;
        }
        .style19
        {
            width: 44px;
        }
        .style20
        {
            width: 124px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p class="style2">
    <strong>Solicitar Material</strong></p>
    <table class="style3">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td class="style19">
                &nbsp;</td>
            <td class="style20">
                &nbsp;</td>
            <td class="style18">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                <strong>IdSolicitud</strong></td>
            <td class="style15">
                <asp:TextBox ID="txtSolicId" runat="server" Width="40px">0</asp:TextBox>
            </td>
            <td class="style8">
                <strong style="text-align: right">Fecha</strong></td>
            <td class="style20">
                <asp:TextBox ID="txtSolicFecha" runat="server" Height="22px" Width="95px">03/07/2015</asp:TextBox>
            </td>
            <td class="style10">
                <strong>Estacion</strong></td>
            <td class="style5">
                <asp:DropDownList ID="ddlEstaciones" runat="server" style="margin-left: 0px" 
                    Width="237px" DataSourceID="odsLeerTodasLasEstaciones" 
                    DataTextField="estacion_nombre" DataValueField="estacion_id">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="odsLeerTodasLasEstaciones" runat="server" 
                    SelectMethod="LeerTodasLasEstaciones" TypeName="CSCInventarios.BL.EstacionBL">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td class="style19">
                &nbsp;</td>
            <td class="style20">
                &nbsp;</td>
            <td class="style18">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
</table>
    <!--DETALLE--> 
     &nbsp;<!--DETALLE--><br />
    <table class="style3">
        <tr>
            <td>
                -<fieldset>
        <legend>Materiales</legend>

                    <span class="style14"><strong>
         Nombre</strong></span>
         <asp:TextBox ID="txtMatNom" runat="server"></asp:TextBox>
&nbsp; <span class="style14"><strong>Marca</strong></span>
         <asp:TextBox ID="txtMatMarca" runat="server"></asp:TextBox>
&nbsp; <strong><span class="style14">Modelo</span></strong>
         <asp:TextBox ID="txtMatModel" runat="server"></asp:TextBox>
&nbsp; <strong><span class="style14">Cantidad</span><asp:TextBox ID="txtMatCantidad" 
             runat="server"></asp:TextBox>
         </strong>
         <br />
         <strong><span class="style14">Observacion </span>
         <asp:TextBox ID="txtMatObsevac" runat="server" Width="478px"></asp:TextBox>
         </strong>
         <br />
         <asp:Button ID="btnAgregarMaterial"  Text="Agrear" runat="server" 
            onclick="btnAgregar_Click" />


     </fieldset></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>

       
    <asp:Panel ID="pnlMateriales" runat="server" CssClass="CajaDialogo" >
        <fieldset>
            <legend>Buscar Material:</legend>
        <b>Criterio:</b><asp:TextBox ID="txtCriterioMaterial" runat="server" 
                Width="292px" /> 
        <asp:Button ID="btnBuscMaterial" Text="Buscar" runat="server" 
                onclick="btnBuscMaterial_Click" />
            <br />
            <asp:GridView ID="gvMateriales" runat="server" AllowPaging="True" 
                AutoGenerateColumns="False" DataSourceID="odsLeerMaterialPorCritero" 
                onselectedindexchanged="gvMateriales_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="material_id" HeaderText="material_id" 
                        SortExpression="material_id" />
                    <asp:BoundField DataField="material_nombre" HeaderText="material_nombre" 
                        SortExpression="material_nombre" />
                    <asp:BoundField DataField="material_modelo" HeaderText="material_modelo" 
                        SortExpression="material_modelo" />
                    <asp:BoundField DataField="material_marca" HeaderText="material_marca" 
                        SortExpression="material_marca" />
                    <asp:BoundField DataField="material_cantidad" HeaderText="material_cantidad" 
                        SortExpression="material_cantidad" />
                    <asp:BoundField DataField="material_observacion" 
                        HeaderText="material_observacion" SortExpression="material_observacion" />
                    <asp:CheckBoxField DataField="material_eliminado" 
                        HeaderText="material_eliminado" SortExpression="material_eliminado" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="odsLeerMaterialPorCritero" runat="server" 
                SelectMethod="LeerMaterialPorCriterio" TypeName="CSCInventarios.BL.MaterialBL">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtCriterioMaterial" DefaultValue="%" 
                        Name="criterio" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </fieldset>

                       
        <br />
    </asp:Panel>
  
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>

       
    <asp:Panel ID="pnlDetalleSolictud" runat="server" CssClass="CajaDialogo" >
        <fieldset>
            <legend>Detalle de Solicitud:</legend>
            <asp:GridView ID="gvDetalleSolicitud" runat="server">
            </asp:GridView>
        </fieldset>

                       
        <br />
         <asp:Button ID="btnRegistrarSolicitud" runat="server" 
            Text="Registrar Solicitud" />
         <br />  
    </asp:Panel>
  
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    </asp:Content>
