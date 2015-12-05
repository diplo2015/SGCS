<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panel_usuario.aspx.cs" Inherits="SGCS.Web.panel_usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvListaSeguros" runat="server" AutoGenerateColumns="False" Width="886px" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="CodSeguro" DataField="CodSeguro" Visible="False" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Precio" DataFormatString="{0:c}" DataField="Precio" />
                <asp:CheckBoxField HeaderText="Habilitado" DataField="Habilitado" Visible="False" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lblContinuar" runat="server" Text="Ha seleccionado {0}. Haga click en Siguiente para continuar." Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnContinuar" runat="server" Text="Siguiente" Visible="False" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
