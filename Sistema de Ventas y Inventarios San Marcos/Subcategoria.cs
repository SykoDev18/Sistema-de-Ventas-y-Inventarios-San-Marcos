// Models/Subcategoria.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Models
{
    public class Subcategoria
    {
        public int ID_Subcategoria { get; set; }
        public int ID_Categoria { get; set; }
        public string Nombre { get; set; }
    }
}