// Models/Producto.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Models
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public int ID_Subcategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_Unitario { get; set; }
        public int Stock { get; set; }
        public int ID_Ubicacion { get; set; }
    }
}