
namespace Veterinaria3._0_1._0
{
    partial class FrmMercancia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMercancia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBuscarNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAgregarPrecioProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgregarCantidadProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgregarNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnActivarDesactivar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercancia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.dgvMercancia);
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 451);
            this.panel2.TabIndex = 8;
            // 
            // dgvMercancia
            // 
            this.dgvMercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercancia.Location = new System.Drawing.Point(3, 3);
            this.dgvMercancia.Name = "dgvMercancia";
            this.dgvMercancia.RowTemplate.Height = 25;
            this.dgvMercancia.Size = new System.Drawing.Size(449, 445);
            this.dgvMercancia.TabIndex = 0;
            this.dgvMercancia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMercancia_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR PRODUCTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtBuscarNombreProducto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 134);
            this.panel1.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(158, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtBuscarNombreProducto
            // 
            this.txtBuscarNombreProducto.Location = new System.Drawing.Point(4, 65);
            this.txtBuscarNombreProducto.Name = "txtBuscarNombreProducto";
            this.txtBuscarNombreProducto.Size = new System.Drawing.Size(158, 23);
            this.txtBuscarNombreProducto.TabIndex = 12;
            this.txtBuscarNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Producto:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(4, 275);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(160, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.txtAgregarPrecioProducto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtAgregarCantidadProducto);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtAgregarNombreProducto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(634, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 222);
            this.panel3.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(3, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAgregarPrecioProducto
            // 
            this.txtAgregarPrecioProducto.Location = new System.Drawing.Point(3, 156);
            this.txtAgregarPrecioProducto.Name = "txtAgregarPrecioProducto";
            this.txtAgregarPrecioProducto.Size = new System.Drawing.Size(160, 23);
            this.txtAgregarPrecioProducto.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Precio Producto:";
            // 
            // txtAgregarCantidadProducto
            // 
            this.txtAgregarCantidadProducto.Location = new System.Drawing.Point(3, 111);
            this.txtAgregarCantidadProducto.Name = "txtAgregarCantidadProducto";
            this.txtAgregarCantidadProducto.Size = new System.Drawing.Size(160, 23);
            this.txtAgregarCantidadProducto.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cantidad Producto:";
            // 
            // txtAgregarNombreProducto
            // 
            this.txtAgregarNombreProducto.Location = new System.Drawing.Point(3, 66);
            this.txtAgregarNombreProducto.Name = "txtAgregarNombreProducto";
            this.txtAgregarNombreProducto.Size = new System.Drawing.Size(160, 23);
            this.txtAgregarNombreProducto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "AGREGAR PRODUCTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "el producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Selecciona en la tabla";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(4, 71);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "el producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "MODIFICAR PRODUCTO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Selecciona en la tabla";
            // 
            // btnActivarDesactivar
            // 
            this.btnActivarDesactivar.BackColor = System.Drawing.Color.White;
            this.btnActivarDesactivar.Location = new System.Drawing.Point(4, 75);
            this.btnActivarDesactivar.Name = "btnActivarDesactivar";
            this.btnActivarDesactivar.Size = new System.Drawing.Size(160, 23);
            this.btnActivarDesactivar.TabIndex = 11;
            this.btnActivarDesactivar.Text = "Activar / Desactivar";
            this.btnActivarDesactivar.UseVisualStyleBackColor = false;
            this.btnActivarDesactivar.Click += new System.EventHandler(this.btnActivarDesactivar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Controls.Add(this.btnRegresar);
            this.panel5.Location = new System.Drawing.Point(0, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 311);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btnModificar);
            this.panel4.Location = new System.Drawing.Point(634, 228);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 106);
            this.panel4.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btnActivarDesactivar);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(634, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 111);
            this.panel6.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(45, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "ACTIVAR / DESACTIVAR";
            // 
            // FrmMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmMercancia";
            this.Text = "Mercancia";
            this.Load += new System.EventHandler(this.FrmMercancia_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercancia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvMercancia;
        private System.Windows.Forms.TextBox txtBuscarNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAgregarCantidadProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgregarNombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgregarPrecioProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActivarDesactivar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
    }
}