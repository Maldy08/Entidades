using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Vehiculos
{
    public class VhRutas
    {
        public int IdRuta { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Secuencia { get; set; }
        public int IdDestino { get; set; }
        public string Desde { get; set; } = string.Empty;
        public string Hasta { get; set; } = string.Empty;
    }
}
