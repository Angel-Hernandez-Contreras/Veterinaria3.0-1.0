
namespace Veterinaria3._0_1._0
{
    partial class FrmCajero
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarCantidad2 = new System.Windows.Forms.Button();
            this.btnEliminarCantidad5 = new System.Windows.Forms.Button();
            this.btnEliminarCantidad50 = new System.Windows.Forms.Button();
            this.btnEliminarCantidad10 = new System.Windows.Forms.Button();
            this.btnEliminarCantidad1 = new System.Windows.Forms.Button();
            this.btnAgregarCantidad2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.btnAgregarCantidad5 = new System.Windows.Forms.Button();
            this.btnAgregarCantidad50 = new System.Windows.Forms.Button();
            this.btnAgregarCantidad10 = new System.Windows.Forms.Button();
            this.btnAgregarCantidad1 = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTerminarProceso = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificarCantidad = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvTicket);
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 452);
            this.panel2.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Location = new System.Drawing.Point(232, 421);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 23);
            this.panel6.TabIndex = 32;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(3, 4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "TICKET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total: ------------------------------------->";
            // 
            // dgvTicket
            // 
            this.dgvTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.dgvTicket.Location = new System.Drawing.Point(3, 25);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowTemplate.Height = 25;
            this.dgvTicket.Size = new System.Drawing.Size(433, 390);
            this.dgvTicket.TabIndex = 0;
            this.dgvTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellContentClick);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.dgvProducto);
            this.panel3.Controls.Add(this.lblResultado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnEliminarCantidad2);
            this.panel3.Controls.Add(this.btnEliminarCantidad5);
            this.panel3.Controls.Add(this.btnEliminarCantidad50);
            this.panel3.Controls.Add(this.btnEliminarCantidad10);
            this.panel3.Controls.Add(this.btnEliminarCantidad1);
            this.panel3.Controls.Add(this.btnAgregarCantidad2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.btnAgregarCantidad5);
            this.panel3.Controls.Add(this.btnAgregarCantidad50);
            this.panel3.Controls.Add(this.btnAgregarCantidad10);
            this.panel3.Controls.Add(this.btnAgregarCantidad1);
            this.panel3.Controls.Add(this.btnAgregarProducto);
            this.panel3.Controls.Add(this.txtNombreProducto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(85, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 280);
            this.panel3.TabIndex = 9;
            // 
            // dgvProducto
            // 
            this.dgvProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(4, 56);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowTemplate.Height = 25;
            this.dgvProducto.Size = new System.Drawing.Size(261, 78);
            this.dgvProducto.TabIndex = 38;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(5, 259);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad Producto";
            // 
            // btnEliminarCantidad2
            // 
            this.btnEliminarCantidad2.BackColor = System.Drawing.Color.White;
            this.btnEliminarCantidad2.Location = new System.Drawing.Point(113, 204);
            this.btnEliminarCantidad2.Name = "btnEliminarCantidad2";
            this.btnEliminarCantidad2.Size = new System.Drawing.Size(30, 23);
            this.btnEliminarCantidad2.TabIndex = 37;
            this.btnEliminarCantidad2.Text = "-2";
            this.btnEliminarCantidad2.UseVisualStyleBackColor = false;
            this.btnEliminarCantidad2.Click += new System.EventHandler(this.btnEliminarCantidad2_Click);
            // 
            // btnEliminarCantidad5
            // 
            this.btnEliminarCantidad5.BackColor = System.Drawing.Color.White;
            this.btnEliminarCantidad5.Location = new System.Drawing.Point(149, 204);
            this.btnEliminarCantidad5.Name = "btnEliminarCantidad5";
            this.btnEliminarCantidad5.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarCantidad5.TabIndex = 36;
            this.btnEliminarCantidad5.Text = "-5";
            this.btnEliminarCantidad5.UseVisualStyleBackColor = false;
            this.btnEliminarCantidad5.Click += new System.EventHandler(this.btnEliminarCantidad5_Click);
            // 
            // btnEliminarCantidad50
            // 
            this.btnEliminarCantidad50.BackColor = System.Drawing.Color.White;
            this.btnEliminarCantidad50.Location = new System.Drawing.Point(231, 204);
            this.btnEliminarCantidad50.Name = "btnEliminarCantidad50";
            this.btnEliminarCantidad50.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarCantidad50.TabIndex = 35;
            this.btnEliminarCantidad50.Text = "-50";
            this.btnEliminarCantidad50.UseVisualStyleBackColor = false;
            this.btnEliminarCantidad50.Click += new System.EventHandler(this.btnEliminarCantidad50_Click);
            // 
            // btnEliminarCantidad10
            // 
            this.btnEliminarCantidad10.BackColor = System.Drawing.Color.White;
            this.btnEliminarCantidad10.Location = new System.Drawing.Point(190, 204);
            this.btnEliminarCantidad10.Name = "btnEliminarCantidad10";
            this.btnEliminarCantidad10.Size = new System.Drawing.Size(35, 23);
            this.btnEliminarCantidad10.TabIndex = 34;
            this.btnEliminarCantidad10.Text = "-10";
            this.btnEliminarCantidad10.UseVisualStyleBackColor = false;
            this.btnEliminarCantidad10.Click += new System.EventHandler(this.btnEliminarCantidad10_Click);
            // 
            // btnEliminarCantidad1
            // 
            this.btnEliminarCantidad1.BackColor = System.Drawing.Color.White;
            this.btnEliminarCantidad1.Location = new System.Drawing.Point(77, 204);
            this.btnEliminarCantidad1.Name = "btnEliminarCantidad1";
            this.btnEliminarCantidad1.Size = new System.Drawing.Size(30, 23);
            this.btnEliminarCantidad1.TabIndex = 33;
            this.btnEliminarCantidad1.Text = "-1";
            this.btnEliminarCantidad1.UseVisualStyleBackColor = false;
            this.btnEliminarCantidad1.Click += new System.EventHandler(this.btnEliminarCantidad1_Click);
            // 
            // btnAgregarCantidad2
            // 
            this.btnAgregarCantidad2.BackColor = System.Drawing.Color.White;
            this.btnAgregarCantidad2.Location = new System.Drawing.Point(113, 172);
            this.btnAgregarCantidad2.Name = "btnAgregarCantidad2";
            this.btnAgregarCantidad2.Size = new System.Drawing.Size(30, 23);
            this.btnAgregarCantidad2.TabIndex = 32;
            this.btnAgregarCantidad2.Text = "+2";
            this.btnAgregarCantidad2.UseVisualStyleBackColor = false;
            this.btnAgregarCantidad2.Click += new System.EventHandler(this.btnAgregarCantidad2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblCantidadProducto);
            this.panel8.Location = new System.Drawing.Point(123, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(144, 23);
            this.panel8.TabIndex = 31;
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
            // btnAgregarCantidad5
            // 
            this.btnAgregarCantidad5.BackColor = System.Drawing.Color.White;
            this.btnAgregarCantidad5.Location = new System.Drawing.Point(149, 172);
            this.btnAgregarCantidad5.Name = "btnAgregarCantidad5";
            this.btnAgregarCantidad5.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarCantidad5.TabIndex = 30;
            this.btnAgregarCantidad5.Text = "+5";
            this.btnAgregarCantidad5.UseVisualStyleBackColor = false;
            this.btnAgregarCantidad5.Click += new System.EventHandler(this.btnAgregarCantidad5_Click);
            // 
            // btnAgregarCantidad50
            // 
            this.btnAgregarCantidad50.BackColor = System.Drawing.Color.White;
            this.btnAgregarCantidad50.Location = new System.Drawing.Point(231, 172);
            this.btnAgregarCantidad50.Name = "btnAgregarCantidad50";
            this.btnAgregarCantidad50.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarCantidad50.TabIndex = 29;
            this.btnAgregarCantidad50.Text = "+50";
            this.btnAgregarCantidad50.UseVisualStyleBackColor = false;
            this.btnAgregarCantidad50.Click += new System.EventHandler(this.btnAgregarCantidad50_Click);
            // 
            // btnAgregarCantidad10
            // 
            this.btnAgregarCantidad10.BackColor = System.Drawing.Color.White;
            this.btnAgregarCantidad10.Location = new System.Drawing.Point(190, 172);
            this.btnAgregarCantidad10.Name = "btnAgregarCantidad10";
            this.btnAgregarCantidad10.Size = new System.Drawing.Size(35, 23);
            this.btnAgregarCantidad10.TabIndex = 28;
            this.btnAgregarCantidad10.Text = "+10";
            this.btnAgregarCantidad10.UseVisualStyleBackColor = false;
            this.btnAgregarCantidad10.Click += new System.EventHandler(this.btnAgregarCantidad10_Click);
            // 
            // btnAgregarCantidad1
            // 
            this.btnAgregarCantidad1.BackColor = System.Drawing.Color.White;
            this.btnAgregarCantidad1.Location = new System.Drawing.Point(77, 172);
            this.btnAgregarCantidad1.Name = "btnAgregarCantidad1";
            this.btnAgregarCantidad1.Size = new System.Drawing.Size(30, 23);
            this.btnAgregarCantidad1.TabIndex = 27;
            this.btnAgregarCantidad1.Text = "+1";
            this.btnAgregarCantidad1.UseVisualStyleBackColor = false;
            this.btnAgregarCantidad1.Click += new System.EventHandler(this.btnAgregarCantidad1_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(4, 233);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(263, 23);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(123, 27);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(143, 23);
            this.txtNombreProducto.TabIndex = 8;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "CAJERO";
            // 
            // btnTerminarProceso
            // 
            this.btnTerminarProceso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTerminarProceso.Location = new System.Drawing.Point(3, 8);
            this.btnTerminarProceso.Name = "btnTerminarProceso";
            this.btnTerminarProceso.Size = new System.Drawing.Size(263, 23);
            this.btnTerminarProceso.TabIndex = 2;
            this.btnTerminarProceso.Text = "Terminar Proceso";
            this.btnTerminarProceso.UseVisualStyleBackColor = false;
            this.btnTerminarProceso.Click += new System.EventHandler(this.btnTerminarProceso_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarProducto.Location = new System.Drawing.Point(4, 47);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(263, 23);
            this.btnEliminarProducto.TabIndex = 1;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 452);
            this.panel1.TabIndex = 10;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(4, 418);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(72, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.btnLimpiar);
            this.panel4.Controls.Add(this.btnModificarCantidad);
            this.panel4.Controls.Add(this.btnEliminarProducto);
            this.panel4.Location = new System.Drawing.Point(85, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 118);
            this.panel4.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLimpiar.Location = new System.Drawing.Point(4, 76);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(263, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarCantidad.Location = new System.Drawing.Point(5, 18);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.Size = new System.Drawing.Size(262, 23);
            this.btnModificarCantidad.TabIndex = 3;
            this.btnModificarCantidad.Text = "Modificar Cantidad";
            this.btnModificarCantidad.UseVisualStyleBackColor = false;
            this.btnModificarCantidad.Click += new System.EventHandler(this.btnModificarCantidad_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Controls.Add(this.btnTerminarProceso);
            this.panel5.Location = new System.Drawing.Point(85, 410);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 42);
            this.panel5.TabIndex = 12;
            // 
            // FrmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCajero";
            this.Text = "Cajero";
            this.Load += new System.EventHandler(this.FrmCajero_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTerminarProceso;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnModificarCantidad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminarCantidad2;
        private System.Windows.Forms.Button btnEliminarCantidad5;
        private System.Windows.Forms.Button btnEliminarCantidad50;
        private System.Windows.Forms.Button btnEliminarCantidad10;
        private System.Windows.Forms.Button btnEliminarCantidad1;
        private System.Windows.Forms.Button btnAgregarCantidad2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Button btnAgregarCantidad5;
        private System.Windows.Forms.Button btnAgregarCantidad50;
        private System.Windows.Forms.Button btnAgregarCantidad10;
        private System.Windows.Forms.Button btnAgregarCantidad1;
        private System.Windows.Forms.DataGridView dgvProducto;
    }
}