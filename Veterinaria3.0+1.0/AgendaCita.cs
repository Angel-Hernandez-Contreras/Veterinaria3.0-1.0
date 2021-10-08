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
    public partial class AgendaCita : Form
    {
        public AgendaCita()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formuario Nueva Cita
            this.Close();//cerrar clase Agenda
        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)
        {
            InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Agenda
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)
        {
            Mercancia fmMercancia = new Mercancia();
            fmMercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar clase Agenda
        }
    }
}
