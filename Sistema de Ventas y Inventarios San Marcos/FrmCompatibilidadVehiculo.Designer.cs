// Forms/Inventario/FrmCompatibilidadVehiculo.Designer.cs
namespace Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms.Inventario
{
    partial class FrmCompatibilidadVehiculo
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
            this.labelBirlo = new System.Windows.Forms.Label();
            this.comboBoxBirlo = new System.Windows.Forms.ComboBox();
            this.btnVerCompatibilidadBirlo = new System.Windows.Forms.Button();
            this.labelTuerca = new System.Windows.Forms.Label();
            this.comboBoxTuerca = new System.Windows.Forms.ComboBox();
            this.btnVerCompatibilidadTuerca = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // labelBirlo
            this.labelBirlo.Location = new System.Drawing.Point(10, 10);
            this.labelBirlo.Name = "labelBirlo";
            this.labelBirlo.Size = new System.Drawing.Size(100, 20);
            this.labelBirlo.Text = "Birlo:";

            // comboBoxBirlo
            this.comboBoxBirlo.Location = new System.Drawing.Point(120, 10);
            this.comboBoxBirlo.Name = "comboBoxBirlo";
            this.comboBoxBirlo.Size = new System.Drawing.Size(200, 21);

            // btnVerCompatibilidadBirlo
            this.btnVerCompatibilidadBirlo.Location = new System.Drawing.Point(330, 10);
            this.btnVerCompatibilidadBirlo.Name = "btnVerCompatibilidadBirlo";
            this.btnVerCompatibilidadBirlo.Size = new System.Drawing.Size(150, 30);
            this.btnVerCompatibilidadBirlo.Text = "Ver Compatibilidad";
            this.btnVerCompatibilidadBirlo.Click += new System.EventHandler(this.btnVerCompatibilidadBirlo_Click);

            // labelTuerca
            this.labelTuerca.Location = new System.Drawing.Point(10, 50);
            this.labelTuerca.Name = "labelTuerca";
            this.labelTuerca.Size = new System.Drawing.Size(100, 20);
            this.labelTuerca.Text = "Tuerca:";

            // comboBoxTuerca
            this.comboBoxTuerca.Location = new System.Drawing.Point(120, 50);
            this.comboBoxTuerca.Name = "comboBoxTuerca";
            this.comboBoxTuerca.Size = new System.Drawing.Size(200, 21);

            // btnVerCompatibilidadTuerca
            this.btnVerCompatibilidadTuerca.Location = new System.Drawing.Point(330, 50);
            this.btnVerCompatibilidadTuerca.Name = "btnVerCompatibilidadTuerca";
            this.btnVerCompatibilidadTuerca.Size = new System.Drawing.Size(150, 30);
            this.btnVerCompatibilidadTuerca.Text = "Ver Compatibilidad";
            this.btnVerCompatibilidadTuerca.Click += new System.EventHandler(this.btnVerCompatibilidadTuerca_Click);

            // dataGridViewResultados
            this.dataGridViewResultados.Location = new System.Drawing.Point(10, 90);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(510, 200);
            this.dataGridViewResultados.ColumnCount = 4;
            this.dataGridViewResultados.Columns[0].Name = "ID_Vehiculo";
            this.dataGridViewResultados.Columns[0].HeaderText = "ID Vehículo";
            this.dataGridViewResultados.Columns[1].Name = "Marca";
            this.dataGridViewResultados.Columns[1].HeaderText = "Marca";
            this.dataGridViewResultados.Columns[2].Name = "Modelo";
            this.dataGridViewResultados.Columns[2].HeaderText = "Modelo";
            this.dataGridViewResultados.Columns[3].Name = "Ano";
            this.dataGridViewResultados.Columns[3].HeaderText = "Año";

            // FrmCompatibilidadVehiculo
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 300);
            this.Controls.Add(this.labelBirlo);
            this.Controls.Add(this.comboBoxBirlo);
            this.Controls.Add(this.btnVerCompatibilidadBirlo);
            this.Controls.Add(this.labelTuerca);
            this.Controls.Add(this.comboBoxTuerca);
            this.Controls.Add(this.btnVerCompatibilidadTuerca);
            this.Controls.Add(this.dataGridViewResultados);
            this.Name = "FrmCompatibilidadVehiculo";
            this.Text = "Compatibilidad con Vehículos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelBirlo;
        private System.Windows.Forms.ComboBox comboBoxBirlo;
        private System.Windows.Forms.Button btnVerCompatibilidadBirlo;
        private System.Windows.Forms.Label labelTuerca;
        private System.Windows.Forms.ComboBox comboBoxTuerca;
        private System.Windows.Forms.Button btnVerCompatibilidadTuerca;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
    }
}