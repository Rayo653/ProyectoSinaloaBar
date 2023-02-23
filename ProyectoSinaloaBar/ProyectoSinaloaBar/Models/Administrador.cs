using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class Administrador
    {


        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdAdministrador { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public int IdPersona { get; set; }

        public Persona Persona { get; set; }
    }
}
