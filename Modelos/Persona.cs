namespace AppGuiada1.Modelos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string EstadoCivil { get; set; }
        public string Curp { get; set; }

    }

    public class Usuario : Persona
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Activo { get; set; }

    }
}
