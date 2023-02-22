namespace ProyectoSinaloaBar.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public int FkTdoc { get; set; }
        public int NumDocumento { get; set; }
        public string Contrasena { get; set; }
        public string PNombre  { get; set; }
        public string SNombre { get; set; }
        public string PApellido  { get; set; }
        public string SApellido { get; set; }
        public int FkRol { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }


    }
}
