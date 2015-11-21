using System;
using System.Collections.Generic;
using System.Text;

namespace SGCS.Common
{
    public class Seguro
    {
        public string codSeguro { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }

        public bool habilitado { get; set; }

    }
}
