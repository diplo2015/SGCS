using SGCS.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Globalization;
using System.Data;

namespace SGCS.Web
{
    public partial class panel_usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListaSeguros listaSeguros = new ListaSeguros();
            Cliente c1 = null;

            gvListaSeguros.DataSource = listaSeguros.getLista();
            gvListaSeguros.DataBind();


            c1 = (Cliente)Session["cli"];
            if (c1 == null)
            {
                Response.Redirect(Page.ResolveClientUrl("/login.aspx"));
            }

            lblUsuario.Text = "Bienvenido: " + c1.Nombre + " " + c1.Apellido;

            if (IsPostBack)
            {
                if (Request.Form["__EVENTTARGET"] == "gvListaSeguros")
                {
                    int seleccionado = int.Parse(Request.Form["__EVENTARGUMENT"].Split('$')[1]);
                    gvListaSeguros.SelectedIndex = seleccionado;
                    gvListaSeguros.SelectedRowStyle.BackColor = Color.LightGray;
                    Seguros s1 = new Seguros();
                    s1.CodSeguro = gvListaSeguros.SelectedRow.Cells[0].Text;
                    s1.Nombre = gvListaSeguros.SelectedRow.Cells[1].Text;
                    s1.Descripcion = gvListaSeguros.SelectedRow.Cells[2].Text;
                    s1.Precio = float.Parse(gvListaSeguros.SelectedRow.Cells[3].Text);
                    s1.Habilitado = ((CheckBox)gvListaSeguros.SelectedRow.Cells[4].Controls[0]).Checked;
                    Session["se"] = s1;
                }
            }

        }
    }
}