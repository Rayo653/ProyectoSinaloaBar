using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class EncargadoBarra
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdEncargado { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdPersona { get; set; }

        public Persona Persona { get; set; }
    }
}
