// Models/Tornillo.cs
namespace FerreteriaSanMarco.Models
{
    public class Tornillo
    {
        public int ID_Tornillo { get; set; }
        public int ID_Producto { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public string Cuerda { get; set; }
        public string Tipo_Cabeza { get; set; }
        public string Material { get; set; }
        public string Grado_Dureza { get; set; }
    }
}