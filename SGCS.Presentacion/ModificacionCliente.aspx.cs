using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGCS.AccesoDatos;
namespace SGCS.Web
{
    public partial class ModificacionCliente : System.Web.UI.Page
    {
        Cliente cli;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConsultaLogin clogin = new ConsultaLogin();
            cli.Apellido = Txtapellido.Text;
            cli.Nombre = Txtnombre.Text;
            cli.Direccion = Txtdireccion.Text;
            clogin.mod(cli);
        }

        protected void Txtdni_TextChanged(object sender, EventArgs e)
        {
            ConsultaLogin clogin = new ConsultaLogin();
            cli = clogin.consulta(CodCli.Text);
        }
    }
}