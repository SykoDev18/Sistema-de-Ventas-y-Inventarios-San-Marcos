// Forms/Inventario/FrmMovimiento.Designer.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    partial class FrmMovimiento
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
            this.labelIdProducto = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.labelTipoMovimiento = new System.Windows.Forms.Label();
            this.comboBoxTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelIdProducto
            this.labelIdProducto.Location = new System.Drawing.Point(10, 10);
            this.labelIdProducto.Name = "labelIdProducto";
            this.labelIdProducto.Size = new System.Drawing.Size(100, 20);
            this.labelIdProducto.Text = "ID Producto:";

            // txtIdProducto
            this.txtIdProducto.Location = new System.Drawing.Point(120, 10);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(200, 20);

            // labelTipoMovimiento
            this.labelTipoMovimiento.Location = new System.Drawing.Point(10, 40);
            this.labelTipoMovimiento.Name = "labelTipoMovimiento";
            this.labelTipoMovimiento.Size = new System.Drawing.Size(100, 20);
            this.labelTipoMovimiento.Text = "Tipo Movimiento:";

            // comboBoxTipoMovimiento
            this.comboBoxTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMovimiento.Items.AddRange(new object[] { "Entrada", "Salida" });
            this.comboBoxTipoMovimiento.Location = new System.Drawing.Point(120, 40);
            this.comboBoxTipoMovimiento.Name = "comboBoxTipoMovimiento";
            this.comboBoxTipoMovimiento.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipoMovimiento.SelectedIndex = 0;

            // labelCantidad
            this.labelCantidad.Location = new System.Drawing.Point(10, 70);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(100, 20);
            this.labelCantidad.Text = "Cantidad:";

            // txtCantidad
            this.txtCantidad.Location = new System.Drawing.Point(120, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);

            // labelFecha
            this.labelFecha.Location = new System.Drawing.Point(10, 100);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(100, 20);
            this.labelFecha.Text = "Fecha:";

            // dateTimePickerFecha
            this.dateTimePickerFecha.Location = new System.Drawing.Point(120, 100);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(120, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FrmMovimiento
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.labelIdProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.labelTipoMovimiento);
            this.Controls.Add(this.comboBoxTipoMovimiento);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmMovimiento";
            this.Text = "Registrar Movimiento";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label labelTipoMovimiento;
        private System.Windows.Forms.ComboBox comboBoxTipoMovimiento;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Button btnGuardar;
    }
}