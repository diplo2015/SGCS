using System;
using System.Collections.Generic;
using System.Text;

namespace SGCS.Common
{
    [Serializable]
    public class Cliente
    {
        public string codCliente { get; set; }
        public string dni { get; set; }
        public string cuit { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string fechaAlta { get; set; }
        public string fechaModificacion { get; set; }
        //public Seguro seguro { get; set; }
    }
}