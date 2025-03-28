// Forms/Inventario/FrmInventario.cs
using System;
using System.Windows.Forms;
using FerreteriaSanMarco.Forms.Inventario;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.DataAccess;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Models;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    public partial class FrmInventario : Form
    {
        private readonly ProductoRepository productoRepository = new ProductoRepository();
        private readonly VehiculoRepository vehiculoRepository = new VehiculoRepository();
        private readonly MovimientoRepository movimientoRepository = new MovimientoRepository();

        public FrmInventario()
        {
            InitializeComponent();
            LoadProductos();
            LoadVehiculos();
            LoadMovimientos();
        }

        private void LoadProductos()
        {
            var productos = productoRepository.GetAll();
            dgvProductos.Rows.Clear();
            foreach (var producto in productos)
            {
                dgvProductos.Rows.Add(producto.ID_Producto, producto.Nombre, producto.Descripcion, producto.Precio_Unitario, producto.Stock);
            }
        }

        private void LoadVehiculos()
        {
            var vehiculos = vehiculoRepository.GetAll();
            dgvVehiculos.Rows.Clear();
            foreach (var vehiculo in vehiculos)
            {
                dgvVehiculos.Rows.Add(vehiculo.ID_Vehiculo, vehiculo.Marca, vehiculo.Modelo, vehiculo.Ano);
            }
        }

        private void LoadMovimientos()
        {
            var movimientos = movimientoRepository.GetAll();
            dgvMovimientos.Rows.Clear();
            foreach (var movimiento in movimientos)
            {
                dgvMovimientos.Rows.Add(movimiento.ID_Movimiento, movimiento.ID_Producto, movimiento.Tipo_Movimiento, movimiento.Cantidad, movimiento.Fecha);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            var frmProducto = new FrmProducto();
            if (frmProducto.ShowDialog() == DialogResult.OK)
            {
                LoadProductos();
            }
        }

        private void BtnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            var frmVehiculo = new FrmVehiculo();
            if (frmVehiculo.ShowDialog() == DialogResult.OK)
            {
                LoadVehiculos();
            }
        }

        private void BtnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            var frmMovimiento = new FrmMovimiento();
            if (frmMovimiento.ShowDialog() == DialogResult.OK)
            {
                LoadMovimientos();
            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            var frmBuscarProducto = new FrmBuscarProducto();
            frmBuscarProducto.ShowDialog();
        }

        private void BtnLocalizarProducto_Click(object sender, EventArgs e)
        {
            var frmLocalizarProducto = new FrmLocalizarProducto();
            frmLocalizarProducto.ShowDialog();
        }

        private void BtnCompatibilidadVehiculo_Click(object sender, EventArgs e)
        {
            var frmCompatibilidadVehiculo = new FrmCompatibilidadVehiculo();
            frmCompatibilidadVehiculo.ShowDialog();
        }
    }
}