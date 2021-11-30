
namespace Veterinaria3._0_1._0
{
    partial class frmHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbCitasAnteriores = new System.Windows.Forms.CheckBox();
            this.brnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar cita:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(16, 62);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(190, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Historial de citas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(576, 394);
            this.dataGridView1.TabIndex = 3;
            // 
            // chbCitasAnteriores
            // 
            this.chbCitasAnteriores.AutoSize = true;
            this.chbCitasAnteriores.Location = new System.Drawing.Point(16, 91);
            this.chbCitasAnteriores.Name = "chbCitasAnteriores";
            this.chbCitasAnteriores.Size = new System.Drawing.Size(131, 19);
            this.chbCitasAnteriores.TabIndex = 4;
            this.chbCitasAnteriores.Text = "Incluir citas pasadas";
            this.chbCitasAnteriores.UseVisualStyleBackColor = true;
            // 
            // brnRegresar
            // 
            this.brnRegresar.Location = new System.Drawing.Point(16, 415);
            this.brnRegresar.Name = "brnRegresar";
            this.brnRegresar.Size = new System.Drawing.Size(75, 23);
            this.brnRegresar.TabIndex = 5;
            this.brnRegresar.Text = "Regresar";
            this.brnRegresar.UseVisualStyleBackColor = true;
            this.brnRegresar.Click += new System.EventHandler(this.brnRegresar_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brnRegresar);
            this.Controls.Add(this.chbCitasAnteriores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "frmHistorial";
            this.Text = "frmHistorial";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbCitasAnteriores;
        private System.Windows.Forms.Button brnRegresar;
    }
}