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
        private void btnNuevaCita_Click_1(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Agenda
        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Cliente
        {
            InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Agenda
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            Mercancia formularioMercancia = new Mercancia();
            formularioMercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar clase Agenda
        }
        
//*********************************************************************************************************
        private void btnCajero_Click(object sender, EventArgs e)//boton para ingresar a Cajero
        {
            Cajero fmCajero = new Cajero();
            fmCajero.Show();//llamar al formulario Cajero
            this.Close();//cerrar clase Agenda
        }
    }
}
