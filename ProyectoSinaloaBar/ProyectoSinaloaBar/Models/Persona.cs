using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoSinaloaBar.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }

        [Required(ErrorMessage = "El tipo de documento es obligatorio.")]
        public int FkTdoc { get; set; }

        [Required(ErrorMessage = "El número de documento es obligatorio.")]
        public int NumDocumento { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Contrasena { get; set; }

        [Required(ErrorMessage = "El primer nombre es obligatorio.")]
        public string PNombre  { get; set; }
        public string SNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio.")]
        public string PApellido  { get; set; }
        public string SApellido { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio.")]
        public int FkRol { get; set; }


        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El sexo es obligatorio.")]
        public string Sexo { get; set; }


        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        public string Correo { get; set; }

        [DefaultValue(false)]
        public bool Estado { get; set; }


        // Relaciones
        public TipoDocumento TipoDocumento { get; set; }
        public Rol Rol { get; set; }
    }
}
