// Forms/Inventario/FrmLocalizarProducto.Designer.cs
namespace FerreteriaSanMarco.Forms.Inventario
{
    partial class FrmLocalizarProducto
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
            this.labelProducto = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelProducto
            this.labelProducto.Location = new System.Drawing.Point(10, 10);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(100, 20);
            this.labelProducto.Text = "Producto:";

            // comboBoxProducto
            this.comboBoxProducto.Location = new System.Drawing.Point(120, 10);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(200, 21);

            // btnLocalizar
            this.btnLocalizar.Location = new System.Drawing.Point(120, 40);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(100, 30);
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);

            // FrmLocalizarProducto
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 100);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.btnLocalizar);
            this.Name = "FrmLocalizarProducto";
            this.Text = "Localizar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Button btnLocalizar;
    }
}