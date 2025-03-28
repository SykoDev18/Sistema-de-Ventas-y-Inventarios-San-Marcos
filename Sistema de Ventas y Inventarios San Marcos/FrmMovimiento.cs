// Forms/Inventario/FrmMovimiento.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models; // Agrega esta línea

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    public partial class FrmMovimiento : Form
    {
        private readonly MovimientoRepository movimientoRepository = new MovimientoRepository();

        public FrmMovimiento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var movimiento = new Movimiento
            {
                ID_Producto = int.Parse(txtIdProducto.Text),
                Tipo_Movimiento = comboBoxTipoMovimiento.SelectedItem.ToString(),
                Cantidad = int.Parse(txtCantidad.Text),
                Fecha = dateTimePickerFecha.Value
            };
            movimientoRepository.Insert(movimiento);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}