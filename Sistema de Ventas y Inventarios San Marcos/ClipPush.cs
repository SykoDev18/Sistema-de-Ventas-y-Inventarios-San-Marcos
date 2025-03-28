// Models/ClipPush.cs
namespace FerreteriaSanMarco.Models
{
    public class ClipPush
    {
        public int ID_Clip_Push { get; set; }
        public int ID_Producto { get; set; }
        public string Tipo { get; set; }
        public double Diametro_Cabeza { get; set; }
        public double Longitud_Tallo { get; set; }
        public double Tamano_Agujero { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
    }
}