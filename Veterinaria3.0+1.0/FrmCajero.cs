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
        private void btnAgregarProducto_Click(object sender, EventArgs e)//boton para agregar producto al ticket
        {
            using (var context = new ApplicationDbContext())
            {
                if (txtIdProducto.Text.Length != 0)
                {
                    int idTxt = Int32.Parse(txtIdProducto.Text);
                    var mercancia = context.Mercancia.First(x => x.Id == idTxt);
                    if (mercancia != null)
                    {
                        int n = dgvTicket.Rows.Add();
                        dgvTicket.Rows[n].Cells[0].Value = mercancia.Nombre;
                        dgvTicket.Rows[n].Cells[1].Value = txtCantidadProducto.Text;
                        dgvTicket.Rows[n].Cells[2].Value = mercancia.Precio;
                        dgvTicket.Rows[n].Cells[3].Value = (Convert.ToInt32(txtCantidadProducto.Text) * mercancia.Precio);
                    }
                }
                else
                {
                    string nombre = txtNombreProducto.Text.ToUpper();
                    var mercancia = context.Mercancia.First(x => x.Nombre == nombre);
                    if (mercancia != null)
                    {
                        int n = dgvTicket.Rows.Add();
                        dgvTicket.Rows[n].Cells[0].Value = mercancia.Nombre;
                        dgvTicket.Rows[n].Cells[1].Value = txtCantidadProducto.Text;
                        dgvTicket.Rows[n].Cells[2].Value = mercancia.Precio;
                        dgvTicket.Rows[n].Cells[3].Value = (Convert.ToInt32(txtCantidadProducto.Text) * mercancia.Precio);
                    }
                }
                txtTotal.Text = "" + Convert.ToDouble(txtTotal.Text) + (Convert.ToInt32(dgvTicket.CurrentRow.Cells[1].Value) * Convert.ToDouble(dgvTicket.CurrentRow.Cells[2].Value));
            }
        }

//*********************************************************************************************************
        private void btnModificarCantidad_Click(object sender, EventArgs e)//boton para modificar la cantidad de producto agregado al ticket
        {

        }

//*********************************************************************************************************
        private void btnEliminarProducto_Click(object sender, EventArgs e)//boton para eliminar el producto agregado al ticket
        {

        }

//*********************************************************************************************************
        private void btnTerminarProceso_Click(object sender, EventArgs e)//boton para limpiar toda la ventada
        {
            txtIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCantidadProducto.Text = "";
            txtTotal.Text = "";

            dgvTicket.Rows.Clear();
        }

        
    }
}
