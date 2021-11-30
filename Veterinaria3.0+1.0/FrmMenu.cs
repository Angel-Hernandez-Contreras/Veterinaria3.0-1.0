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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita nuevaCita = new NuevaCita();
            nuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar esta clase (Mercancia)
        }
//*********************************************************************************************************
        private void btnAgendaCitas_Click(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            FrmAgendaCita agendaCita = new FrmAgendaCita();
            agendaCita.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar esta clase (Mercancia)
        }
//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Clientes
        {
            FrmInformacionCliente informacionCliente = new FrmInformacionCliente();
            informacionCliente.Show();//llamar al formulario Informacion Clientes
            this.Close();//cerrar esta clase (Mercancia)
        }
//*********************************************************************************************************
        private void btnCajero_Click(object sender, EventArgs e)//boton para ingresar a Cajero
        {
            FrmCajero cajero = new FrmCajero();
            cajero.Show();//llamar al formulario Cajero
            this.Close();//cerrar esta clase (Mercancia)
        }
//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            FrmMercancia mercancia = new FrmMercancia();
            mercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar esta clase (Mercancia)
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //ERROR NO BORRAR O NO COMPILA
            frmHistorial historial = new frmHistorial();
            historial.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.Show();
            this.Close();
        }
    }
}
