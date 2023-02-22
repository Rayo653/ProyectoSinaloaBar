namespace ProyectoSinaloaBar.Models
{
    public class Factura
    {
        public int NFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public float SubTotal { get; set; }
        public float Iva { get; set; }
        public float TotalFactura { get; set; }

    }
}
