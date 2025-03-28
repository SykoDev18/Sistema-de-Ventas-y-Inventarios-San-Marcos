// Models/Tuerca.cs
namespace FerreteriaSanMarco.Models
{
    public class Tuerca
    {
        public int ID_Tuerca { get; set; }
        public int ID_Producto { get; set; }
        public string Tipo { get; set; }
        public string Tamano { get; set; }
        public string Material { get; set; }
    }
}