// Forms/Inventario/FrmVehiculo.Designer.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    partial class FrmVehiculo
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
            this.labelMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.labelBirlo = new System.Windows.Forms.Label();
            this.comboBoxBirlo = new System.Windows.Forms.ComboBox();
            this.labelTuerca = new System.Windows.Forms.Label();
            this.comboBoxTuerca = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelMarca
            this.labelMarca.Location = new System.Drawing.Point(10, 10);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(100, 20);
            this.labelMarca.Text = "Marca:";

            // txtMarca
            this.txtMarca.Location = new System.Drawing.Point(120, 10);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 20);

            // labelModelo
            this.labelModelo.Location = new System.Drawing.Point(10, 40);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(100, 20);
            this.labelModelo.Text = "Modelo:";

            // txtModelo
            this.txtModelo.Location = new System.Drawing.Point(120, 40);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 20);

            // labelAno
            this.labelAno.Location = new System.Drawing.Point(10, 70);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(100, 20);
            this.labelAno.Text = "Año:";

            // txtAno
            this.txtAno.Location = new System.Drawing.Point(120, 70);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(200, 20);

            // labelBirlo
            this.labelBirlo.Location = new System.Drawing.Point(10, 100);
            this.labelBirlo.Name = "labelBirlo";
            this.labelBirlo.Size = new System.Drawing.Size(100, 20);
            this.labelBirlo.Text = "Birlo:";

            // comboBoxBirlo
            this.comboBoxBirlo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBirlo.Location = new System.Drawing.Point(120, 100);
            this.comboBoxBirlo.Name = "comboBoxBirlo";
            this.comboBoxBirlo.Size = new System.Drawing.Size(200, 21);

            // labelTuerca
            this.labelTuerca.Location = new System.Drawing.Point(10, 130);
            this.labelTuerca.Name = "labelTuerca";
            this.labelTuerca.Size = new System.Drawing.Size(100, 20);
            this.labelTuerca.Text = "Tuerca:";

            // comboBoxTuerca
            this.comboBoxTuerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTuerca.Location = new System.Drawing.Point(120, 130);
            this.comboBoxTuerca.Name = "comboBoxTuerca";
            this.comboBoxTuerca.Size = new System.Drawing.Size(200, 21);

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(120, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FrmVehiculo
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 210);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.labelBirlo);
            this.Controls.Add(this.comboBoxBirlo);
            this.Controls.Add(this.labelTuerca);
            this.Controls.Add(this.comboBoxTuerca);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmVehiculo";
            this.Text = "Registrar Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label labelBirlo;
        private System.Windows.Forms.ComboBox comboBoxBirlo;
        private System.Windows.Forms.Label labelTuerca;
        private System.Windows.Forms.ComboBox comboBoxTuerca;
        private System.Windows.Forms.Button btnGuardar;
    }
}