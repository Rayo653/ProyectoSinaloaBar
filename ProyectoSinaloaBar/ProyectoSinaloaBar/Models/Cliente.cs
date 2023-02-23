using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdPersona { get; set; }

        public Persona Persona { get; set; }
    }
}
