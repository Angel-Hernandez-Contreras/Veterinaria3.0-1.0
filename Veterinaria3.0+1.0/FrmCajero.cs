using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria3._0_1._0
{
    public partial class FrmCajero : Form
    {
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
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

//*********************************************************************************************************
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

//*********************************************************************************************************
        private void btnTerminarProceso_Click(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCantidadProducto.Text = "";
        }
    }
}
