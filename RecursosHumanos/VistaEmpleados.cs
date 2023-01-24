using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RecursosHumanos
{
    public class VistaEmpleados
    {
        public string Activo { get; set; } = string.Empty;
        public int Empleado { get; set; }
        public string Paterno { get; set; } = string.Empty;
        public string Materno { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int IdPue { get; set; }
        public string DescripcionPuesto { get; set; } = string.Empty;
        public int Deptoue { get; set; }
        public string? DescripcionDepto { get; set; } = string.Empty;
        public int Deptocomi { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public int Municipio { get; set; }
        public int Oficina { get; set; }
        public int Nivel { get; set; }
    }
}

