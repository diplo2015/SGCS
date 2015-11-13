<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaCliente.aspx.cs" Inherits="SGCS.Web.AltaCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 363px">
    
        ALTA DE CLIENTES<br />
        <br />
&nbsp;&nbsp; DNI:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Nombre:&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="285px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Apellido:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="282px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Dirección:
        <asp:TextBox ID="TextBox4" runat="server" Width="280px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp; Teléfono:&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="278px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Aceptar" Width="133px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancelar" Width="136px" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
