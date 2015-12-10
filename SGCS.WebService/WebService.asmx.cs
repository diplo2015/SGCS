using SGCS.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SGCS.WebService
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://sgcs.fagdut/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Seguros> ListaSeguros()
        {
            AccesoDatos.ListaSeguros ls = new ListaSeguros();
            return ls.getLista();
        }

        
        [WebMethod]
        public List<Cliente> ListaClientes()
        {
            AccesoDatos.ListaClientes lc = new ListaClientes();
            return lc.getClientes();
        }
    }
}
