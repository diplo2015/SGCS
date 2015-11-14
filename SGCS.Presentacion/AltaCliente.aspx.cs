using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGCS.AccesoDatos;
namespace SGCS.Web
{
    public partial class AltaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConsultaLogin clogin = new ConsultaLogin();
            Cliente cl1 = new Cliente();
           
            cl1.Dni = Txtdni.Text;
            cl1.Apellido = Txtapellido.Text;
            cl1.Nombre = Txtnombre.Text;
            cl1.Direccion = Txtdireccion.Text;
            cl1.Telefono = Txttelefono.Text;
            cl1.Cuit = Txtcuit.Text;
            cl1.Usuario = Txtusuario.Text;
            cl1.Pass = Txtpass.Text;
            cl1.CodCliente = CodCli.Text;
            cl1.FechaAlta = this.FechaAlta.SelectedDate.ToShortDateString();
            cl1.FechaModificacion = this.FechaAlta.SelectedDate.ToShortDateString();
            clogin.alta(cl1);
            
        }
    }
}