using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidEats.Entities
{
    internal class Proveedor : Usuario
    {
        public string ProveedorName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
}
