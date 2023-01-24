using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Viaticos
{
    public class Viaticos
    {
        public int Oficina { get; set; }
        public int Ejercicio { get; set; }
        public int NoViat { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int NoEmp { get; set; }
        public int OrigenId { get; set; }
        public int DestinoId { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public DateTime FechaSal { get; set; } = DateTime.Now;
        public DateTime FechaReg { get; set; } = DateTime.Now;
        public int Dias { get; set; }
        public DateTime InforFecha { get; set; } = DateTime.Now;
        public string InforAct { get; set; } = string.Empty;
        public string Nota { get; set; } = string.Empty;
        public int Estatus { get; set; }
        public DateTime FechaMod { get; set; } = DateTime.Now;
        public int? Pol { get; set; } = 0;
        public int? PolMes { get; set; } = 0;
        public int? Caja { get; set; } = 0; 
        public int? CajaVale { get; set; } = 0;
        public int? CajaRepo { get; set; } = 0;
        public int NoEmpCrea { get; set; }
        public string InforResul { get; set; } = string.Empty;






    }
}
