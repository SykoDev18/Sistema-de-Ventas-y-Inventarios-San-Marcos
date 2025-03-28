// Models/Vehiculo.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Models
{
    public class Vehiculo
    {
        public int ID_Vehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int? ID_Birlo { get; set; }
        public int? ID_Tuerca { get; set; }
    }
}