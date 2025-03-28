// Forms/Inventario/FrmCompatibilidadVehiculo.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess; // Namespace corregido

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    public partial class FrmCompatibilidadVehiculo : Form
    {
        private readonly ProductoRepository productoRepository = new ProductoRepository();
        private readonly VehiculoRepository vehiculoRepository = new VehiculoRepository();

        public FrmCompatibilidadVehiculo()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            // Cargar birlos (considerados productos de la subcategoría "Birlos")
            var birlos = productoRepository.GetBySubcategoria(3); // Suponiendo que 3 es el ID de la subcategoría "Birlos"
            comboBoxBirlo.DataSource = birlos;
            comboBoxBirlo.DisplayMember = "Nombre";
            comboBoxBirlo.ValueMember = "ID_Producto";

            // Cargar tuercas (consideradas productos de la subcategoría "Tuercas")
            var tuercas = productoRepository.GetBySubcategoria(4); // Suponiendo que 4 es el ID de la subcategoría "Tuercas"
            comboBoxTuerca.DataSource = tuercas;
            comboBoxTuerca.DisplayMember = "Nombre";
            comboBoxTuerca.ValueMember = "ID_Producto";
        }

        private void btnVerCompatibilidadBirlo_Click(object sender, EventArgs e)
        {
            if (comboBoxBirlo.SelectedValue != null)
            {
                int idBirlo = (int)comboBoxBirlo.SelectedValue;
                var vehiculos = vehiculoRepository.GetByBirlo(idBirlo);
                dataGridViewResultados.Rows.Clear();
                foreach (var vehiculo in vehiculos)
                {
                    dataGridViewResultados.Rows.Add(vehiculo.ID_Vehiculo, vehiculo.Marca, vehiculo.Modelo, vehiculo.Ano);
                }
            }
        }

        private void btnVerCompatibilidadTuerca_Click(object sender, EventArgs e)
        {
            if (comboBoxTuerca.SelectedValue != null)
            {
                int idTuerca = (int)comboBoxTuerca.SelectedValue;
                var vehiculos = vehiculoRepository.GetByTuerca(idTuerca);
                dataGridViewResultados.Rows.Clear();
                foreach (var vehiculo in vehiculos)
                {
                    dataGridViewResultados.Rows.Add(vehiculo.ID_Vehiculo, vehiculo.Marca, vehiculo.Modelo, vehiculo.Ano);
                }
            }
        }
    }
}