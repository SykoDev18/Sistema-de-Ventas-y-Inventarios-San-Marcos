// Forms/Inventario/FrmInventario.Designer.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    partial class FrmInventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlInventario = new System.Windows.Forms.TabControl();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.tabPageVehiculos = new System.Windows.Forms.TabPage();
            this.tabPageBuscar = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnLocalizarProducto = new System.Windows.Forms.Button();
            this.btnCompatibilidadVehiculo = new System.Windows.Forms.Button();

            this.tabPageProductos.SuspendLayout();
            this.tabPageStock.SuspendLayout();
            this.tabPageVehiculos.SuspendLayout();
            this.tabPageBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.tabControlInventario.SuspendLayout();
            this.SuspendLayout();

            // tabControlInventario
            this.tabControlInventario.Controls.Add(this.tabPageProductos);
            this.tabControlInventario.Controls.Add(this.tabPageStock);
            this.tabControlInventario.Controls.Add(this.tabPageVehiculos);
            this.tabControlInventario.Controls.Add(this.tabPageBuscar);
            this.tabControlInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInventario.Location = new System.Drawing.Point(0, 0);
            this.tabControlInventario.Name = "tabControlInventario";
            this.tabControlInventario.SelectedIndex = 0;
            this.tabControlInventario.Size = new System.Drawing.Size(800, 450);

            // tabPageProductos
            this.tabPageProductos.Controls.Add(this.dgvProductos);
            this.tabPageProductos.Controls.Add(this.btnAgregarProducto);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Size = new System.Drawing.Size(792, 424);
            this.tabPageProductos.Text = "Productos";

            // tabPageStock
            this.tabPageStock.Controls.Add(this.dgvMovimientos);
            this.tabPageStock.Controls.Add(this.btnRegistrarMovimiento);
            this.tabPageStock.Location = new System.Drawing.Point(4, 22);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Size = new System.Drawing.Size(792, 424);
            this.tabPageStock.Text = "Stock";

            // tabPageVehiculos
            this.tabPageVehiculos.Controls.Add(this.dgvVehiculos);
            this.tabPageVehiculos.Controls.Add(this.btnAgregarVehiculo);
            this.tabPageVehiculos.Location = new System.Drawing.Point(4, 22);
            this.tabPageVehiculos.Name = "tabPageVehiculos";
            this.tabPageVehiculos.Size = new System.Drawing.Size(792, 424);
            this.tabPageVehiculos.Text = "Vehículos";

            // tabPageBuscar
            this.tabPageBuscar.Controls.Add(this.btnBuscarProducto);
            this.tabPageBuscar.Controls.Add(this.btnLocalizarProducto);
            this.tabPageBuscar.Controls.Add(this.btnCompatibilidadVehiculo);
            this.tabPageBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscar.Name = "tabPageBuscar";
            this.tabPageBuscar.Size = new System.Drawing.Size(792, 424);
            this.tabPageBuscar.Text = "Búsqueda y Localización";

            // dgvProductos
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(792, 424);
            this.dgvProductos.ColumnCount = 5;
            this.dgvProductos.Columns[0].Name = "ID_Producto";
            this.dgvProductos.Columns[0].HeaderText = "ID Producto";
            this.dgvProductos.Columns[1].Name = "Nombre";
            this.dgvProductos.Columns[1].HeaderText = "Nombre";
            this.dgvProductos.Columns[2].Name = "Descripcion";
            this.dgvProductos.Columns[2].HeaderText = "Descripción";
            this.dgvProductos.Columns[3].Name = "Precio_Unitario";
            this.dgvProductos.Columns[3].HeaderText = "Precio Unitario";
            this.dgvProductos.Columns[4].Name = "Stock";
            this.dgvProductos.Columns[4].HeaderText = "Stock";

            // btnAgregarProducto
            this.btnAgregarProducto.Location = new System.Drawing.Point(10, 10);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);

            // dgvMovimientos
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 0);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.Size = new System.Drawing.Size(792, 424);
            this.dgvMovimientos.ColumnCount = 5;
            this.dgvMovimientos.Columns[0].Name = "ID_Movimiento";
            this.dgvMovimientos.Columns[0].HeaderText = "ID Movimiento";
            this.dgvMovimientos.Columns[1].Name = "ID_Producto";
            this.dgvMovimientos.Columns[1].HeaderText = "ID Producto";
            this.dgvMovimientos.Columns[2].Name = "Tipo_Movimiento";
            this.dgvMovimientos.Columns[2].HeaderText = "Tipo Movimiento";
            this.dgvMovimientos.Columns[3].Name = "Cantidad";
            this.dgvMovimientos.Columns[3].HeaderText = "Cantidad";
            this.dgvMovimientos.Columns[4].Name = "Fecha";
            this.dgvMovimientos.Columns[4].HeaderText = "Fecha";

            // btnRegistrarMovimiento
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(10, 10);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(120, 30);
            this.btnRegistrarMovimiento.Text = "Registrar Movimiento";
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.BtnRegistrarMovimiento_Click);

            // dgvVehiculos
            this.dgvVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiculos.Location = new System.Drawing.Point(0, 0);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(792, 424);
            this.dgvVehiculos.ColumnCount = 4;
            this.dgvVehiculos.Columns[0].Name = "ID_Vehiculo";
            this.dgvVehiculos.Columns[0].HeaderText = "ID Vehículo";
            this.dgvVehiculos.Columns[1].Name = "Marca";
            this.dgvVehiculos.Columns[1].HeaderText = "Marca";
            this.dgvVehiculos.Columns[2].Name = "Modelo";
            this.dgvVehiculos.Columns[2].HeaderText = "Modelo";
            this.dgvVehiculos.Columns[3].Name = "Ano";
            this.dgvVehiculos.Columns[3].HeaderText = "Año";

            // btnAgregarVehiculo
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(10, 10);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarVehiculo.Text = "Agregar Vehículo";
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.BtnAgregarVehiculo_Click);

            // btnBuscarProducto
            this.btnBuscarProducto.Location = new System.Drawing.Point(10, 10);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(120, 30);
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);

            // btnLocalizarProducto
            this.btnLocalizarProducto.Location = new System.Drawing.Point(150, 10);
            this.btnLocalizarProducto.Name = "btnLocalizarProducto";
            this.btnLocalizarProducto.Size = new System.Drawing.Size(120, 30);
            this.btnLocalizarProducto.Text = "Localizar Producto";
            this.btnLocalizarProducto.Click += new System.EventHandler(this.BtnLocalizarProducto_Click);

            // btnCompatibilidadVehiculo
            this.btnCompatibilidadVehiculo.Location = new System.Drawing.Point(290, 10);
            this.btnCompatibilidadVehiculo.Name = "btnCompatibilidadVehiculo";
            this.btnCompatibilidadVehiculo.Size = new System.Drawing.Size(150, 30);
            this.btnCompatibilidadVehiculo.Text = "Compatibilidad Vehículo";
            this.btnCompatibilidadVehiculo.Click += new System.EventHandler(this.BtnCompatibilidadVehiculo_Click);

            // FrmInventario
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlInventario);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.tabPageProductos.ResumeLayout(false);
            this.tabPageStock.ResumeLayout(false);
            this.tabPageVehiculos.ResumeLayout(false);
            this.tabPageBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.tabControlInventario.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControlInventario;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPageVehiculos;
        private System.Windows.Forms.TabPage tabPageBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnLocalizarProducto;
        private System.Windows.Forms.Button btnCompatibilidadVehiculo;
    }
}