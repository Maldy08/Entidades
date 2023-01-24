namespace Entidades.Vehiculos
{
    public class VhDestinos
    {
        public int IdDestino { get; set; }
        public string Desde { get; set; } = string.Empty;
        public string Hasta { get; set; } = string.Empty;
        public int Kms { get; set; }
        public int Tiempo { get; set; }
        public int Prioridad { get; set; }


    }
}