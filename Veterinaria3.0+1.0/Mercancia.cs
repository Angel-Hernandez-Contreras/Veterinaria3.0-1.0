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
    public partial class Mercancia : Form
    {
        public Mercancia()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void button1_Click(object sender, EventArgs e)//boton Buscar producto
        {

        }

//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Mercancia
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            AgendaCita fmAgnCita = new AgendaCita();
            fmAgnCita.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar clase Mercancia
        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Cliente
        {
            InformacionCliente fmInfoCliente = new InformacionCliente();
            fmInfoCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Mercancia
        }
      
    }
}
