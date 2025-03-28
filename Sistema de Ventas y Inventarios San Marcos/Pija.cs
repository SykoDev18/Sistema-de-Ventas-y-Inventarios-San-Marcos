// Models/Pija.cs
namespace FerreteriaSanMarco.Models
{
    public class Pija
    {
        public int ID_Pija { get; set; }
        public int ID_Producto { get; set; }
        public double Largo { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
    }
}