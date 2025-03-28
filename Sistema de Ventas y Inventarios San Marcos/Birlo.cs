// Models/Birlo.cs
namespace FerreteriaSanMarco.Models
{
    public class Birlo
    {
        public int ID_Birlo { get; set; }
        public int ID_Producto { get; set; }
        public string Medida { get; set; }
        public string Tipo_Rosca { get; set; }
        public string Compatibilidad_Vehiculo { get; set; }
    }
}