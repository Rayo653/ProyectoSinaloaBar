using System.ComponentModel;

namespace ProyectoSinaloaBar.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int StockMax { get; set; }
        public int StockMin { get; set; }
        public string Nombre { get; set; }
        public int FkMarca { get; set; }
        public int FkTipoProducto { get; set; }
        public float PrecioUnitario { get; set; }

        [DefaultValue(false)]
        public bool Estado { get; set; }

    }
}
