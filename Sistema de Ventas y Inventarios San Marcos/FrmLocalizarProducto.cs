// Forms/Inventario/FrmLocalizarProducto.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;

namespace FerreteriaSanMarco.Forms.Inventario
{
    public partial class FrmLocalizarProducto : Form
    {
        private readonly ProductoRepository productoRepository = new ProductoRepository();
        private readonly UbicacionRepository ubicacionRepository = new UbicacionRepository();

        public FrmLocalizarProducto()
        {
            InitializeComponent();
            LoadProductos();
        }

        private void LoadProductos()
        {
            var productos = productoRepository.GetAll();
            comboBoxProducto.DataSource = productos;
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "ID_Producto";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedValue != null)
            {
                int idProducto = (int)comboBoxProducto.SelectedValue;
                var producto = productoRepository.GetById(idProducto);
                var ubicacion = ubicacionRepository.GetAll().Find(u => u.ID_Ubicacion == producto.ID_Ubicacion);
                if (ubicacion != null)
                {
                    MessageBox.Show($"El producto '{producto.Nombre}' se encuentra en: {ubicacion.Descripcion}");
                }
                else
                {
                    MessageBox.Show("Ubicación no encontrada.");
                }
            }
        }
    }
}