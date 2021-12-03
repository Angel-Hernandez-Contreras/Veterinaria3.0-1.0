
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
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chbCitasAnteriores = new System.Windows.Forms.CheckBox();
            this.brnRegresar = new System.Windows.Forms.Button();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(16, 93);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(190, 23);
            this.txtBuscarNombre.TabIndex = 1;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.chbCitasAnteriores.Location = new System.Drawing.Point(16, 44);
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
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(16, 142);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(190, 23);
            this.txtBuscarApellido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar por Apellido:";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(16, 194);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(190, 23);
            this.txtBuscarId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar por Id:";
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscarApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brnRegresar);
            this.Controls.Add(this.chbCitasAnteriores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarNombre);
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
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chbCitasAnteriores;
        private System.Windows.Forms.Button brnRegresar;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Label label4;
    }
}