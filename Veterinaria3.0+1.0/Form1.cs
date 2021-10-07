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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)//boton agregar cita
        {
            //-------------AGREGAR FICHA CITA
            int n = dgvFichaCita.Rows.Add();

            dgvFichaCita.Rows[n].Cells[0].Value = txtIdCliente.Text;
            dgvFichaCita.Rows[n].Cells[1].Value = dtpFechaCita.Value.ToString();
            dgvFichaCita.Rows[n].Cells[2].Value = txtHoraCita.Text;
            dgvFichaCita.Rows[n].Cells[3].Value = cbNombreVeterinario.SelectedItem;
        }
    }
}
