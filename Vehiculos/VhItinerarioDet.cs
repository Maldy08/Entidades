using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Vehiculos
{
    public class VhItinerarioDet
    {
        public int IdItinerario { get; set; }
        public int Registro { get; set; }
        public string Desde { get; set; } = string.Empty;
        public string Hasta { get; set; } = string.Empty;
        public int Kms { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Tiempo { get; set; }
    }
}
