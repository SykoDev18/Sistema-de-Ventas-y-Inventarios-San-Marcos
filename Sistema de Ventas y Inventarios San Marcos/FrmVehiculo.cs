// Forms/Inventario/FrmVehiculo.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models; // Agrega esta línea

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    public partial class FrmVehiculo : Form
    {
        private readonly VehiculoRepository vehiculoRepository = new VehiculoRepository();
        private readonly ProductoRepository productoRepository = new ProductoRepository();

        public FrmVehiculo()
        {
            InitializeComponent();
            LoadCombos();
        }

        private void LoadCombos()
        {
            var birlos = productoRepository.GetBySubcategoria(3); // Suponiendo que 3 es el ID de la subcategoría "Birlos"
            comboBoxBirlo.DataSource = birlos;
            comboBoxBirlo.DisplayMember = "Nombre";
            comboBoxBirlo.ValueMember = "ID_Producto";

            var tuercas = productoRepository.GetBySubcategoria(4); // Suponiendo que 4 es el ID de la subcategoría "Tuercas"
            comboBoxTuerca.DataSource = tuercas;
            comboBoxTuerca.DisplayMember = "Nombre";
            comboBoxTuerca.ValueMember = "ID_Producto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var vehiculo = new Vehiculo
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Ano = int.Parse(txtAno.Text),
                ID_Birlo = comboBoxBirlo.SelectedValue != null ? (int?)comboBoxBirlo.SelectedValue : null,
                ID_Tuerca = comboBoxTuerca.SelectedValue != null ? (int?)comboBoxTuerca.SelectedValue : null
            };
            vehiculoRepository.Insert(vehiculo);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}