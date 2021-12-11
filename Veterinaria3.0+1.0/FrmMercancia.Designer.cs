
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtAgregarPrecioProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgregarNombreProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.btnCantidad5 = new System.Windows.Forms.Button();
            this.btnCantidad50 = new System.Windows.Forms.Button();
            this.btnCantidad10 = new System.Windows.Forms.Button();
            this.btnCantidad1 = new System.Windows.Forms.Button();
            this.btnAgregarExistencias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercancia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.dgvMercancia.BackgroundColor = System.Drawing.Color.White;
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
            this.btnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
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
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(4, 158);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(160, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.btnAgregarProducto);
            this.panel3.Controls.Add(this.txtAgregarPrecioProducto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtAgregarNombreProducto);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(634, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 193);
            this.panel3.TabIndex = 13;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(3, 151);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(160, 23);
            this.btnAgregarProducto.TabIndex = 10;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAgregarPrecioProducto
            // 
            this.txtAgregarPrecioProducto.Location = new System.Drawing.Point(3, 120);
            this.txtAgregarPrecioProducto.Name = "txtAgregarPrecioProducto";
            this.txtAgregarPrecioProducto.Size = new System.Drawing.Size(161, 23);
            this.txtAgregarPrecioProducto.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Precio Producto:";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "AGRAGAR EXISTENCIAS";
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
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(3, 70);
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
            this.btnActivarDesactivar.BackColor = System.Drawing.Color.LightCoral;
            this.btnActivarDesactivar.Location = new System.Drawing.Point(2, 75);
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
            this.panel5.Location = new System.Drawing.Point(0, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 194);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btnModificar);
            this.panel4.Location = new System.Drawing.Point(634, 345);
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
            this.panel6.Location = new System.Drawing.Point(0, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 111);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnCantidad5);
            this.panel7.Controls.Add(this.btnCantidad50);
            this.panel7.Controls.Add(this.btnCantidad10);
            this.panel7.Controls.Add(this.btnCantidad1);
            this.panel7.Controls.Add(this.btnAgregarExistencias);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(634, 199);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 140);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblCantidadProducto);
            this.panel8.Location = new System.Drawing.Point(4, 59);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 23);
            this.panel8.TabIndex = 26;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(3, 4);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(13, 15);
            this.lblCantidadProducto.TabIndex = 0;
            this.lblCantidadProducto.Text = "0";
            // 
            // btnCantidad5
            // 
            this.btnCantidad5.BackColor = System.Drawing.Color.White;
            this.btnCantidad5.Location = new System.Drawing.Point(46, 88);
            this.btnCantidad5.Name = "btnCantidad5";
            this.btnCantidad5.Size = new System.Drawing.Size(35, 23);
            this.btnCantidad5.TabIndex = 25;
            this.btnCantidad5.Text = "+5";
            this.btnCantidad5.UseVisualStyleBackColor = false;
            this.btnCantidad5.Click += new System.EventHandler(this.btnCantidad5_Click_1);
            // 
            // btnCantidad50
            // 
            this.btnCantidad50.BackColor = System.Drawing.Color.White;
            this.btnCantidad50.Location = new System.Drawing.Point(128, 88);
            this.btnCantidad50.Name = "btnCantidad50";
            this.btnCantidad50.Size = new System.Drawing.Size(35, 23);
            this.btnCantidad50.TabIndex = 24;
            this.btnCantidad50.Text = "+50";
            this.btnCantidad50.UseVisualStyleBackColor = false;
            this.btnCantidad50.Click += new System.EventHandler(this.btnCantidad50_Click_1);
            // 
            // btnCantidad10
            // 
            this.btnCantidad10.BackColor = System.Drawing.Color.White;
            this.btnCantidad10.Location = new System.Drawing.Point(87, 88);
            this.btnCantidad10.Name = "btnCantidad10";
            this.btnCantidad10.Size = new System.Drawing.Size(35, 23);
            this.btnCantidad10.TabIndex = 23;
            this.btnCantidad10.Text = "+10";
            this.btnCantidad10.UseVisualStyleBackColor = false;
            this.btnCantidad10.Click += new System.EventHandler(this.btnCantidad10_Click_1);
            // 
            // btnCantidad1
            // 
            this.btnCantidad1.BackColor = System.Drawing.Color.White;
            this.btnCantidad1.Location = new System.Drawing.Point(10, 88);
            this.btnCantidad1.Name = "btnCantidad1";
            this.btnCantidad1.Size = new System.Drawing.Size(30, 23);
            this.btnCantidad1.TabIndex = 22;
            this.btnCantidad1.Text = "+1";
            this.btnCantidad1.UseVisualStyleBackColor = false;
            this.btnCantidad1.Click += new System.EventHandler(this.btnCantidad1_Click_1);
            // 
            // btnAgregarExistencias
            // 
            this.btnAgregarExistencias.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarExistencias.Location = new System.Drawing.Point(4, 114);
            this.btnAgregarExistencias.Name = "btnAgregarExistencias";
            this.btnAgregarExistencias.Size = new System.Drawing.Size(160, 23);
            this.btnAgregarExistencias.TabIndex = 11;
            this.btnAgregarExistencias.Text = "Agregar Existencias";
            this.btnAgregarExistencias.UseVisualStyleBackColor = false;
            this.btnAgregarExistencias.Click += new System.EventHandler(this.btnAgregarExistencias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Selecciona en la tabla";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(4, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "el producto";
            // 
            // FrmMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel7);
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgregarNombreProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgregarPrecioProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregarProducto;
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCantidad5;
        private System.Windows.Forms.Button btnCantidad50;
        private System.Windows.Forms.Button btnCantidad10;
        private System.Windows.Forms.Button btnCantidad1;
        private System.Windows.Forms.Button btnAgregarExistencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCantidadProducto;
    }
}