using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGCS.AccesoDatos;

namespace SGCS.Web
{
    public partial class Baja_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ConsultaLogin clogin = new ConsultaLogin();
            if (clogin.Eliminar(CodCli.Text))
            {
                Label1.Text = "Cliente Eliminado";
            }
            else
            {
                Label1.Text = "No Se encontro el cliente";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}