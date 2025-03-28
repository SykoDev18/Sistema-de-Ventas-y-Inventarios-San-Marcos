// Forms/Inventario/FrmBuscarProducto.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    public partial class FrmBuscarProducto : Form
    {
        private readonly ProductoRepository productoRepository = new ProductoRepository();
        private readonly CategoriaRepository categoriaRepository = new CategoriaRepository();
        private readonly SubcategoriaRepository subcategoriaRepository = new SubcategoriaRepository();

        public FrmBuscarProducto()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            var categorias = categoriaRepository.GetAll();
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "Nombre";
            comboBoxCategoria.ValueMember = "ID_Categoria";
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategoria.SelectedValue != null)
            {
                int idCategoria = (int)comboBoxCategoria.SelectedValue;
                var subcategorias = subcategoriaRepository.GetByCategoria(idCategoria);
                comboBoxSubcategoria.DataSource = subcategorias;
                comboBoxSubcategoria.DisplayMember = "Nombre";
                comboBoxSubcategoria.ValueMember = "ID_Subcategoria";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int? idCategoria = comboBoxCategoria.SelectedValue != null ? (int?)comboBoxCategoria.SelectedValue : null;
            int? idSubcategoria = comboBoxSubcategoria.SelectedValue != null ? (int?)comboBoxSubcategoria.SelectedValue : null;

            var productos = productoRepository.Search(nombre, idCategoria, idSubcategoria);
            dgvResultados.Rows.Clear();
            foreach (var producto in productos)
            {
                dgvResultados.Rows.Add(producto.ID_Producto, producto.Nombre, producto.Descripcion, producto.Precio_Unitario, producto.Stock);
            }

            if (productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con los criterios especificados.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}