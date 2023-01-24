using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Usuarios
    {
        public int Usuario { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Pass { get; set; } = string.Empty;
        public bool? Activo { get; set; }
        //public bool? Compras { get; set; }
        //public bool? ComprasNivel { get; set; }
        //public bool? Almacen { get; set; }
        //public bool? AlmacenNivel { get; set; }
        //public bool? Activos { get; set; }
        //public bool? ActivosNivel { get; set; }
        //public bool? Contabilidad { get; set; }
        //public bool? ContabilidadNivel { get; set; }
        //public bool? Presupuestos { get; set; }
        //public bool? PresupuestosNivel { get; set; }
        //public bool? Nominas { get; set; }
        //public bool? NominasNivel { get; set; }
        public int Depto { get; set; }
        public int NoEmpleado { get; set; }
        //public bool? Bd { get; set; }
        //public bool? Caja { get; set; }
        //public bool? CajaNivel { get; set; }
        //public string Polnom { get; set; } = string.Empty;
        public bool? Viaticos { get; set; }
        public int? ViaticosNivel { get; set; }
        //public bool? Vales { get; set; }
        //public bool? ValesNivel { get; set; }
        public string DeptoDescripcion { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public int IdPue { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int Municipio { get; set; }
        public int Oficina { get; set; }
    }
}
