// Forms/Inventario/FrmProducto.Designer.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    partial class FrmProducto
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
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelSubcategoria = new System.Windows.Forms.Label();
            this.comboBoxSubcategoria = new System.Windows.Forms.ComboBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelCategoria
            this.labelCategoria.Location = new System.Drawing.Point(10, 10);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(100, 20);
            this.labelCategoria.Text = "Categoría:";

            // comboBoxCategoria
            this.comboBoxCategoria.Location = new System.Drawing.Point(120, 10);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);

            // labelSubcategoria
            this.labelSubcategoria.Location = new System.Drawing.Point(10, 40);
            this.labelSubcategoria.Name = "labelSubcategoria";
            this.labelSubcategoria.Size = new System.Drawing.Size(100, 20);
            this.labelSubcategoria.Text = "Subcategoría:";

            // comboBoxSubcategoria
            this.comboBoxSubcategoria.Location = new System.Drawing.Point(120, 40);
            this.comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            this.comboBoxSubcategoria.Size = new System.Drawing.Size(200, 21);

            // labelNombre
            this.labelNombre.Location = new System.Drawing.Point(10, 70);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 20);
            this.labelNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);

            // labelDescripcion
            this.labelDescripcion.Location = new System.Drawing.Point(10, 100);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(100, 20);
            this.labelDescripcion.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(120, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 20);

            // labelPrecio
            this.labelPrecio.Location = new System.Drawing.Point(10, 130);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(100, 20);
            this.labelPrecio.Text = "Precio Unitario:";

            // txtPrecio
            this.txtPrecio.Location = new System.Drawing.Point(120, 130);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);

            // labelStock
            this.labelStock.Location = new System.Drawing.Point(10, 160);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(100, 20);
            this.labelStock.Text = "Stock:";

            // txtStock
            this.txtStock.Location = new System.Drawing.Point(120, 160);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(200, 20);

            // labelUbicacion
            this.labelUbicacion.Location = new System.Drawing.Point(10, 190);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(100, 20);
            this.labelUbicacion.Text = "Ubicación:";

            // comboBoxUbicacion
            this.comboBoxUbicacion.Location = new System.Drawing.Point(120, 190);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(200, 21);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(120, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FrmProducto
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelSubcategoria);
            this.Controls.Add(this.comboBoxSubcategoria);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.comboBoxUbicacion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmProducto";
            this.Text = "Agregar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelSubcategoria;
        private System.Windows.Forms.ComboBox comboBoxSubcategoria;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.ComboBox comboBoxUbicacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}