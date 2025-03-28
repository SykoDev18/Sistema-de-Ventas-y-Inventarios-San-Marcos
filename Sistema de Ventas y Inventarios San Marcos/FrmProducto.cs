// Forms/Inventario/FrmProducto.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;
using FerreteriaSanMarco.Models;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    public partial class FrmProducto : Form
    {
        private readonly ProductoRepository productoRepository = new ProductoRepository();
        private readonly CategoriaRepository categoriaRepository = new CategoriaRepository();
        private readonly SubcategoriaRepository subcategoriaRepository = new SubcategoriaRepository();
        private readonly UbicacionRepository ubicacionRepository = new UbicacionRepository();

        public FrmProducto()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            // Cargar categorías
            var categorias = categoriaRepository.GetAll();
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.DisplayMember = "Nombre";
            comboBoxCategoria.ValueMember = "ID_Categoria";

            // Cargar ubicaciones
            var ubicaciones = ubicacionRepository.GetAll();
            comboBoxUbicacion.DataSource = ubicaciones;
            comboBoxUbicacion.DisplayMember = "Descripcion";
            comboBoxUbicacion.ValueMember = "ID_Ubicacion";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                ID_Subcategoria = (int)comboBoxSubcategoria.SelectedValue,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio_Unitario = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                ID_Ubicacion = (int)comboBoxUbicacion.SelectedValue
            };

            productoRepository.Insert(producto);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}