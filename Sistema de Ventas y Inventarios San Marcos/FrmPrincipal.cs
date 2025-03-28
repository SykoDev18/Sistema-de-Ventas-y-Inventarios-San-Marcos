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

        // M�todos para otras secciones (puedes agregarlos seg�n necesites)
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aqu� abrir�as el formulario de Ventas (FrmVentas), cuando lo crees
            MessageBox.Show("Secci�n de Ventas a�n no implementada.");
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aqu� abrir�as el formulario de Pedidos (FrmPedidos), cuando lo crees
            MessageBox.Show("Secci�n de Pedidos a�n no implementada.");
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aqu� abrir�as el formulario de Reportes (FrmReportes), cuando lo crees
            MessageBox.Show("Secci�n de Reportes a�n no implementada.");
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aqu� abrir�as el formulario de Administraci�n (FrmAdministracion), cuando lo crees
            MessageBox.Show("Secci�n de Administraci�n a�n no implementada.");
        }
    }
}