// Forms/FrmPrincipal.cs
using System;
using System.Windows.Forms;
using FerreteriaSanMarco.Forms.Inventario;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.ShowDialog();
        }

        // Métodos para otras secciones (puedes agregarlos según necesites)
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí abrirías el formulario de Ventas (FrmVentas), cuando lo crees
            MessageBox.Show("Sección de Ventas aún no implementada.");
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí abrirías el formulario de Pedidos (FrmPedidos), cuando lo crees
            MessageBox.Show("Sección de Pedidos aún no implementada.");
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí abrirías el formulario de Reportes (FrmReportes), cuando lo crees
            MessageBox.Show("Sección de Reportes aún no implementada.");
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí abrirías el formulario de Administración (FrmAdministracion), cuando lo crees
            MessageBox.Show("Sección de Administración aún no implementada.");
        }
    }
}