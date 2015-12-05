using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCS.AccesoDatos
{
    public class ListaClientes
    {
        public List<Cliente> getClientes()
        {
            List<Cliente> clientes = null;
            using (GSLAEntities ctx = new GSLAEntities())
            {
                clientes = (from c in ctx.Cliente.AsEnumerable()
                           select c).ToList();
            }
            return clientes;
        }
    }
}
