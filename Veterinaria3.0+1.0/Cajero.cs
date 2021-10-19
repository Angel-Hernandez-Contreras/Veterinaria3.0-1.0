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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Cajero
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            AgendaCita fmAgendaCita = new AgendaCita();
            fmAgendaCita.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar clase Cajero
        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Clientes
        {
            InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Cajero
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            Mercancia fmMercancia = new Mercancia();
            fmMercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar clase Cajero
        }
    }
}
