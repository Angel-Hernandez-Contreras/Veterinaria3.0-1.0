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
    public partial class InformacionCliente : Form
    {
        public InformacionCliente()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnBuscar_Click(object sender, EventArgs e)//boton Buscar
        {

        }

//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)//boton Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Informacion Cliente
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click(object sender, EventArgs e)//boton Agenda Cita
        {
            AgendaCita fmAC = new AgendaCita();
            fmAC.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar clase Informacion Cliente
        }      
    }
}
