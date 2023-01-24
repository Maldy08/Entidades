using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Vehiculos
{
    public class VhItinerario
    {
        public int IdItinerario { get; set; }
        public int Vehiculo { get; set; }
        public int IdChofer { get; set; }
        public DateTime FechaIni { get; set; } = DateTime.Now;
        public DateTime FechaFin { get; set; } = DateTime.Now;
        public string Motivo { get; set; } = string.Empty;

        public int Clave { get; set; }

        public int Estatus { get; set; }
    }
}
