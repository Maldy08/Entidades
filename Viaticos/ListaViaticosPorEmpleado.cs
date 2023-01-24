using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Viaticos
{
    public class ListaViaticosPorEmpleado
    {
        public int Viatico { get; set; }
        public DateTime Fecha { get; set; }
        public string Origen { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public string Movito { get; set; } = string.Empty;
        public DateTime Salida { get; set; } = DateTime.Now;
        public DateTime Regreso { get; set; } = DateTime.Now;
        public string Estatus { get; set; } = string.Empty;
    }
}
