using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SGCS.AccesoDatos
{
    public class ConsultaLogin
    {
        //private IQueryable<Cliente> cliente;
        public Cliente consulta(string u, string p)
        {


            GSLAEntities clienteContext = new GSLAEntities();


            List<Cliente> cliente = (from cli in clienteContext.Cliente
                               where cli.Usuario.Equals(u,StringComparison.InvariantCulture)  && 
                                     cli.Pass.Equals(p,StringComparison.InvariantCulture)
                               select cli).ToList<Cliente>();


            if (cliente.Count == 1) {
                return cliente.First<Cliente>();
            }
            else
            {
                return null;
            }
      
        }
    }
}