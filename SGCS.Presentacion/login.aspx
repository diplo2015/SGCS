<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SGCS.Web.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table>
            <tr>
                <td align="right">Usuario:</td><td><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right">Contraseña:</td><td><asp:TextBox ID="txtContraseña" runat="server" ></asp:TextBox></td>
            </tr>
            <tr>
                <td></td><td></td>
            </tr>
            <tr>
                <td>&nbsp;</td><td><asp:Button ID="btnAceptar"  Text="Aceptar" runat="server" OnClick="btnAceptar_Click"/><asp:Button runat="server" Text="Cancelar" ID="btnCancelar"/></td>
            </tr>
            <tr>
                <td></td><td></td>
            </tr>
            <tr>
                <td colspan="2" ><asp:Label Text="" ID="lblError" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
