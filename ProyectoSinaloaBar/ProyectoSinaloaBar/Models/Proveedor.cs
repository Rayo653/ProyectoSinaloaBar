using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class Proveedor
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdProveedor { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdPersona { get; set; }


        public Persona Persona { get; set; }

    }
}
