using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria3._0_1._0.Models;

namespace Veterinaria3._0_1._0
{
    public partial class FrmCajero : Form
    {
        public int id = 0;
        public int total = 0;
        public int posicion = 0;

        public FrmCajero()
        {
            InitializeComponent();
        }
//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Cajero)
        }

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

//*********************************************************************************************************
        private void btnAgregarProducto_Click(object sender, EventArgs e)//boton para agregar producto al ticket
        {
            if (txtNombreProducto.Text.Length != 0 && txtCantidadProducto.Text.Length != 0)
            {
                using (var context = new ApplicationDbContext())
                {
                    string nombre = txtNombreProducto.Text.ToUpper();
                    var mercancia = context.Mercancia.First(x => x.Nombre == nombre);
                    if (mercancia != null)
                    {
                        if (mercancia.Estado == "INACTIVO")
                        {
                            lblResultado.Text = "EL PRODUCTO NO ESTA ACTIVO";
                        }
                        else
                        {
                            int n = dgvTicket.Rows.Add();
                            dgvTicket.Rows[n].Cells[0].Value = mercancia.Nombre;
                            dgvTicket.Rows[n].Cells[1].Value = txtCantidadProducto.Text;
                            dgvTicket.Rows[n].Cells[2].Value = mercancia.Precio;
                            dgvTicket.Rows[n].Cells[3].Value = (Convert.ToInt32(txtCantidadProducto.Text) * mercancia.Precio);
                            //txtTotal.Text = "" + (Convert.ToDouble(txtTotal.Text) + (Convert.ToInt32(dgvTicket.Rows[n].Cells[1].Value) * Convert.ToDouble(dgvTicket.Rows[n].Cells[2].Value)));
                            //total = Convert.ToInt32(txtTotal.Text);

                            TotalProducto();
                            Limpiar();

                        }
                    }


                }
            }
        }

//*********************************************************************************************************
        public void TotalProducto()
        {
            txtTotal.Text = "0";
            //int n = dgvTicket.Rows.Add();
            for (int i = 0; i < dgvTicket.RowCount; i++)
            {             
                txtTotal.Text = "" + (Convert.ToDouble(txtTotal.Text) + (Convert.ToInt32(dgvTicket.Rows[i].Cells[1].Value) * Convert.ToDouble(dgvTicket.Rows[i].Cells[2].Value)));
                
            }
            total = Convert.ToInt32(txtTotal.Text);
        }

//*********************************************************************************************************
        private void btnModificarCantidad_Click(object sender, EventArgs e)//boton para modificar la cantidad de producto agregado al ticket
        {
            if (txtCantidadProducto.Text.Length != 0)
            {
                dgvTicket[1, posicion].Value = txtCantidadProducto.Text;
                dgvTicket[3, posicion].Value = (Convert.ToInt32(txtCantidadProducto.Text) * Convert.ToDouble(dgvTicket.Rows[posicion].Cells[2].Value));
                TotalProducto();
                Limpiar();
            }
        }

        //*********************************************************************************************************
        private void btnEliminarProducto_Click(object sender, EventArgs e)//boton para eliminar el producto agregado al ticket
        {
            if (txtCantidadProducto.Text.Length != 0)
            {
                dgvTicket.Rows.RemoveAt(posicion);
                TotalProducto();
                Limpiar();
            }
        }

//*********************************************************************************************************
        private void btnTerminarProceso_Click(object sender, EventArgs e)//boton para limpiar toda la ventada
        {
            using (var context = new ApplicationDbContext())
            {
                var agregar = new Historial();               

                int n = dgvTicket.Rows.Add();
                for (int i = 0; i < n/*dgvTicket.RowCount*/; i++)
                {
                    var mercancia = context.Mercancia.First(x => x.Nombre == dgvTicket.Rows[i].Cells[0].Value.ToString());
                    mercancia.Cantidad = mercancia.Cantidad - Convert.ToInt32(dgvTicket.Rows[i].Cells[1].Value);

                    agregar.ProductoCantidadPrecio = "" + agregar.ProductoCantidadPrecio + ("[" + dgvTicket.Rows[i].Cells[0].Value + "][" + dgvTicket.Rows[i].Cells[1].Value + "][$" + dgvTicket.Rows[i].Cells[2].Value + "];" );
                    agregar.Total = total;
                }

                context.Historial.Add(agregar);

                context.SaveChanges();
            }

            Limpiar();
            txtTotal.Text = "";
            dgvTicket.Rows.Clear();
        }

//*********************************************************************************************************
        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvTicket.CurrentRow.Index;
            txtNombreProducto.Text = dgvTicket.CurrentRow.Cells[0].Value.ToString().ToUpper();
            txtCantidadProducto.Text = dgvTicket.CurrentRow.Cells[1].Value.ToString();
        }

//*********************************************************************************************************
        public void Limpiar()
        {
            txtNombreProducto.Text = "";
            txtCantidadProducto.Text = "";        
        }

    }
}
