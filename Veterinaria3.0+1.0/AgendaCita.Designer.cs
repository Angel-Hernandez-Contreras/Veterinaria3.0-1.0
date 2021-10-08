
namespace Veterinaria3._0_1._0
{
    partial class AgendaCita
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInformacionClientes = new System.Windows.Forms.Button();
            this.btnCajero = new System.Windows.Forms.Button();
            this.btnMercancia = new System.Windows.Forms.Button();
            this.btnAgendaCita = new System.Windows.Forms.Button();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInformacionClientes);
            this.panel1.Controls.Add(this.btnCajero);
            this.panel1.Controls.Add(this.btnMercancia);
            this.panel1.Controls.Add(this.btnAgendaCita);
            this.panel1.Controls.Add(this.btnNuevaCita);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 448);
            this.panel1.TabIndex = 7;
            // 
            // btnInformacionClientes
            // 
            this.btnInformacionClientes.Location = new System.Drawing.Point(3, 75);
            this.btnInformacionClientes.Name = "btnInformacionClientes";
            this.btnInformacionClientes.Size = new System.Drawing.Size(128, 23);
            this.btnInformacionClientes.TabIndex = 31;
            this.btnInformacionClientes.Text = "Informacion Clientes";
            this.btnInformacionClientes.UseVisualStyleBackColor = true;
            this.btnInformacionClientes.Click += new System.EventHandler(this.btnInformacionClientes_Click);
            // 
            // btnCajero
            // 
            this.btnCajero.Location = new System.Drawing.Point(3, 104);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(128, 23);
            this.btnCajero.TabIndex = 29;
            this.btnCajero.Text = "Cajero";
            this.btnCajero.UseVisualStyleBackColor = true;
            // 
            // btnMercancia
            // 
            this.btnMercancia.Location = new System.Drawing.Point(3, 133);
            this.btnMercancia.Name = "btnMercancia";
            this.btnMercancia.Size = new System.Drawing.Size(128, 23);
            this.btnMercancia.TabIndex = 28;
            this.btnMercancia.Text = "Mercancia";
            this.btnMercancia.UseVisualStyleBackColor = true;
            this.btnMercancia.Click += new System.EventHandler(this.btnMercancia_Click);
            // 
            // btnAgendaCita
            // 
            this.btnAgendaCita.Location = new System.Drawing.Point(3, 46);
            this.btnAgendaCita.Name = "btnAgendaCita";
            this.btnAgendaCita.Size = new System.Drawing.Size(128, 23);
            this.btnAgendaCita.TabIndex = 27;
            this.btnAgendaCita.Text = "Agenda Citas";
            this.btnAgendaCita.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Location = new System.Drawing.Point(3, 20);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(128, 23);
            this.btnNuevaCita.TabIndex = 12;
            this.btnNuevaCita.Text = "Nueva Cita";
            this.btnNuevaCita.UseVisualStyleBackColor = true;
            this.btnNuevaCita.Click += new System.EventHandler(this.btnNuevaCita_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(143, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 401);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.FechaCita,
            this.HoraCita,
            this.Veterinario});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(638, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // FechaCita
            // 
            this.FechaCita.HeaderText = "fecha Cita";
            this.FechaCita.Name = "FechaCita";
            // 
            // HoraCita
            // 
            this.HoraCita.HeaderText = "Hra Cita";
            this.HoraCita.Name = "HoraCita";
            // 
            // Veterinario
            // 
            this.Veterinario.HeaderText = "Veterinario";
            this.Veterinario.Name = "Veterinario";
            // 
            // AgendaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AgendaCita";
            this.Text = "AgendaCita";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCajero;
        private System.Windows.Forms.Button btnMercancia;
        private System.Windows.Forms.Button btnAgendaCita;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veterinario;
        private System.Windows.Forms.Button btnInformacionClientes;
    }
}