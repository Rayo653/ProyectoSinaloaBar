using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class TipoDocumento
    {

        
    
        public int IdTdoc { get; set; }
      
        public string Tdoc { get; set; }
      
        public string DescTdoc { get; set; }


        [DefaultValue(false)]
        public bool Estado { get; set; }


    }
}
