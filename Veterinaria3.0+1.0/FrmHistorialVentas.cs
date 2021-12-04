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
    public partial class FrmHistorialVentas : Form
    {
        public FrmHistorialVentas()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void frmHistorial_Load(object sender, EventArgs e)//carga el Histrial al abrir el formulario
        {
            using (var context = new ApplicationDbContext())
            {
                var historial = context.Historial.ToList();
                dgvHistorialVentas.DataSource = historial;
            }
        }

//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Cajero)
        }
 
    }
}
