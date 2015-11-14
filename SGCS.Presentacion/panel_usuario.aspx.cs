using SGCS.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGCS.Web
{
    public partial class panel_usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente c1 = (Cliente)Session["cli"];
            lblUsuario.Text = "Loggeado: " + c1.Nombre + " " + c1.Apellido;
        }
    }
}