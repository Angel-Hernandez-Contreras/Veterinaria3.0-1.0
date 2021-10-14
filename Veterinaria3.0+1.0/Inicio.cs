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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)//bton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Hide();//esconder clase Inicio
        }
    }
}
