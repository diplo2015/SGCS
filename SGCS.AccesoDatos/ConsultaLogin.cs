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
        public bool alta(Cliente cli1)
        {


            GSLAEntities clienteContext = new GSLAEntities();

            clienteContext.Cliente.Add(cli1);
            clienteContext.SaveChanges();
            return true;

        }
        public Cliente consulta(Cliente cli1, string cod)
        {


            GSLAEntities clienteContext = new GSLAEntities();


            List<Cliente> cliente = (from cli in clienteContext.Cliente
                                     where cli.CodCliente.Equals(cod, StringComparison.InvariantCulture) 
                                     select cli).ToList<Cliente>();


            if (cliente.Count == 1)
            {
               return cliente.First<Cliente>();
            }
            else
            {
                return null;
            }                   

        }

        public bool mod(Cliente cli1)
        {
      

            GSLAEntities clienteContext = new GSLAEntities();

            clienteContext.Cliente.Find(cli1.CodCliente).Apellido = cli1.Apellido;
            clienteContext.Cliente.Find(cli1.CodCliente).Nombre = cli1.Nombre;
            clienteContext.Cliente.Find(cli1.CodCliente).FechaAlta = cli1.FechaAlta;
            clienteContext.Cliente.Find(cli1.CodCliente).Direccion = cli1.Direccion;
            clienteContext.Cliente.Find(cli1.CodCliente).Cuit = cli1.Cuit;
            clienteContext.Cliente.Find(cli1.CodCliente).Dni = cli1.Dni;
            clienteContext.Cliente.Find(cli1.CodCliente).FechaModificacion = cli1.FechaModificacion;
            clienteContext.Cliente.Find(cli1.CodCliente).Pass = cli1.Pass;
            clienteContext.Cliente.Find(cli1.CodCliente).Telefono = cli1.Telefono;
            clienteContext.Cliente.Find(cli1.CodCliente).Usuario = cli1.Usuario;
            

            clienteContext.SaveChanges();
            return true;

        }

    }
}
