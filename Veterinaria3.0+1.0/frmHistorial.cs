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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {

        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Cajero)
        }
    }
}
