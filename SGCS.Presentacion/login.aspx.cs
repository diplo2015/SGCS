using SGCS.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGCS.Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            ConsultaLogin con = new ConsultaLogin();
            Cliente c1 = con.consulta(txtUsuario.Text, txtContraseña.Text);

            if (c1 != null) 
            { 
                Session["cli"] = c1;
                Response.Redirect(Page.ResolveClientUrl("/panel_usuario.aspx"));
            } 
            else 
            { 
                lblError.Text = "Usuario o contraseña no valido"; 
            }

        }
    }
}