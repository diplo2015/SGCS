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
        public bool consulta(string u, string p)
        {


            GSLAEntities clienteContext = new GSLAEntities();


            List<Cliente> cliente = (from cli in clienteContext.Cliente
                                     where cli.Usuario == u && cli.Pass == p
                                     select cli).ToList<Cliente>();


            if (cliente.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool alta(Cliente cli1)
        {


            GSLAEntities clienteContext = new GSLAEntities();

            clienteContext.Cliente.Add(cli1);
            clienteContext.SaveChanges();
            return true;

        }


    }
}
