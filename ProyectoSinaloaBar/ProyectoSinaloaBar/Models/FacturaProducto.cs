namespace ProyectoSinaloaBar.Models
{
    public class FacturaProducto
    {
        public int IdFacturaProducto { get; set; }
        public int PkNFactura { get; set; }
        public int PkCodProducto { get; set; }
        public int CantidadProd { get; set; }
        public float ValorProdCant { get; set; }

    }
}
