namespace SenaFotology.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Clave { get; set; }

        public class RegistroUsuarioViewModel
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Contrasena { get; set; }
        }

        public class RegistroFotografoViewModel
        {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Direccion { get; set; }
            public string Contrasena { get; set; }
        }

    }
}