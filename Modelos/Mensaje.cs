namespace AppGuiada1.Modelos
{
    public class Mensaje
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Mensaje(string NombreIn, int EdadIn)
        {
            Nombre = NombreIn;
            Edad = EdadIn;
        }
    }
}
