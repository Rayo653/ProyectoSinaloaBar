using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class TipoDocumento
    {
        
        public int IdTdoc { get; set; }
        public string Tdoc { get; set; }
        public string DescTdoc { get; set; }
        public bool Estado { get; set; }


    }
}
