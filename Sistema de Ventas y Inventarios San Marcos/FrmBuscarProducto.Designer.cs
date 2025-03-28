// Forms/Inventario/FrmBuscarProducto.Designer.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    partial class FrmBuscarProducto
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelSubcategoria = new System.Windows.Forms.Label();
            this.comboBoxSubcategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();

            // labelNombre
            this.labelNombre.Location = new System.Drawing.Point(10, 10);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 20);
            this.labelNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);

            // labelCategoria
            this.labelCategoria.Location = new System.Drawing.Point(10, 40);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(100, 20);
            this.labelCategoria.Text = "Categoría:";

            // comboBoxCategoria
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.Location = new System.Drawing.Point(120, 40);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);

            // labelSubcategoria
            this.labelSubcategoria.Location = new System.Drawing.Point(10, 70);
            this.labelSubcategoria.Name = "labelSubcategoria";
            this.labelSubcategoria.Size = new System.Drawing.Size(100, 20);
            this.labelSubcategoria.Text = "Subcategoría:";

            // comboBoxSubcategoria
            this.comboBoxSubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubcategoria.Location = new System.Drawing.Point(120, 70);
            this.comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            this.comboBoxSubcategoria.Size = new System.Drawing.Size(200, 21);

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(120, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // dgvResultados
            this.dgvResultados.Location = new System.Drawing.Point(10, 140);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(600, 200);
            this.dgvResultados.ColumnCount = 5;
            this.dgvResultados.Columns[0].Name = "ID_Producto";
            this.dgvResultados.Columns[0].HeaderText = "ID Producto";
            this.dgvResultados.Columns[1].Name = "Nombre";
            this.dgvResultados.Columns[1].HeaderText = "Nombre";
            this.dgvResultados.Columns[2].Name = "Descripcion";
            this.dgvResultados.Columns[2].HeaderText = "Descripción";
            this.dgvResultados.Columns[3].Name = "Precio_Unitario";
            this.dgvResultados.Columns[3].HeaderText = "Precio Unitario";
            this.dgvResultados.Columns[4].Name = "Stock";
            this.dgvResultados.Columns[4].HeaderText = "Stock";

            // FrmBuscarProducto
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.labelSubcategoria);
            this.Controls.Add(this.comboBoxSubcategoria);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvResultados);
            this.Name = "FrmBuscarProducto";
            this.Text = "Buscar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelSubcategoria;
        private System.Windows.Forms.ComboBox comboBoxSubcategoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}