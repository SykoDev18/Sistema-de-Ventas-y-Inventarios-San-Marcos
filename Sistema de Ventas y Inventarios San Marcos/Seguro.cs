// Models/Seguro.cs
namespace FerreteriaSanMarco.Models
{
    public class Seguro
    {
        public int ID_Seguro { get; set; }
        public int ID_Producto { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
        public double Diametro { get; set; }
        public double Longitud { get; set; }
    }
}