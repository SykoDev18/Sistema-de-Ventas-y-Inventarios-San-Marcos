// Models/Movimiento.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Models
{
    public class Movimiento
    {
        public int ID_Movimiento { get; set; }
        public int ID_Producto { get; set; }
        public string Tipo_Movimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}