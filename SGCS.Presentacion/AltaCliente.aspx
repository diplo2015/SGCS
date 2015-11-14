<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="SGCS.Web.AltaCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 594px">
    
        ALTA DE CLIENTES<br />
        <br />
&nbsp;&nbsp; CodCli:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="CodCli" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; DNI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Txtdni" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Nombre:&nbsp;
        <asp:TextBox ID="Txtnombre" runat="server" Width="285px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Apellido:&nbsp;
        <asp:TextBox ID="Txtapellido" runat="server" Width="282px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Dirección:
        <asp:TextBox ID="Txtdireccion" runat="server" Width="280px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Teléfono:&nbsp;
        <asp:TextBox ID="Txttelefono" runat="server" Width="278px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp; Cuit:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Txtcuit" runat="server" Width="279px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Usuario:
        <asp:TextBox ID="Txtusuario" runat="server" Width="277px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; Pass:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Txtpass" runat="server" Width="276px"></asp:TextBox>
        <br />
        <br />
        <asp:Calendar ID="FechaAlta" runat="server" BackColor="White" 
            BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
            ForeColor="Black" Height="16px" NextPrevFormat="FullMonth" Width="360px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" 
            Width="133px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancelar" Width="136px" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
