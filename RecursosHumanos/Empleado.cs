using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RecursosHumanos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Paterno { get; set; } = string.Empty;
        public string Materno { get; set; } = string.Empty;
        public int Nivel { get; set; }
        public int Depto { get; set; }
        public int Obra { get; set; }
        public int DeptoPpto { get; set; }
        public int DeptoComi { get; set; }
        public int Municipio { get; set; }
        public string Activo { get; set; } = string.Empty;



    }
}
