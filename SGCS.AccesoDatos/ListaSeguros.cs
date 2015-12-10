using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCS.AccesoDatos
{
    public class ListaSeguros
    {
        public List<Seguros> getLista()
        {
            List<Seguros> seguros = null;
            using (GSLAEntities ctx = new GSLAEntities())
            { 
                seguros = (from s in ctx.Seguros.AsEnumerable()
                           where s.Habilitado == true
                           select s).ToList();
            }
            return seguros;
        }
    }
}
