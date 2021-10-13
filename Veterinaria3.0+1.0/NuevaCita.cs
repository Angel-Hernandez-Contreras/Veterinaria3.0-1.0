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
    public partial class NuevaCita : Form
    {
        
        public NuevaCita()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnAgregarCita_Click_1(object sender, EventArgs e)//boton Agregar Cita
        {         
            int n = dgvFichaCita.Rows.Add();
            //-------------AGREGAR FICHA CITA
            dgvFichaCita.Rows[n].Cells[0].Value = txtIdCliente.Text;
            dgvFichaCita.Rows[n].Cells[1].Value = dtpFechaCita.Value.ToString() ;
            dgvFichaCita.Rows[n].Cells[2].Value = txtHoraCita.Text;
            dgvFichaCita.Rows[n].Cells[3].Value = cbNombreVeterinario.SelectedItem;

            InformacionCliente fmInfCliente = new InformacionCliente(
                /*informacion cliente*/txtIdCliente.Text, txtNombreCliente.Text, txtApellidoCliente.Text, txtCuentaBanco.Text, txtTelefonoCliente.Text, 
                /*informacion mascota*/txtNombreMascota.Text, Convert.ToString(cbEspecieMascota.SelectedItem), Convert.ToString(cbRazaMascota.SelectedItem), txtColorPeloMascota.Text, rbMachoMascota.Checked ? "Macho" : "Hembra"
                );

            AgendaCita fmAgnCliente = new AgendaCita();
            fmInfCliente.Show();
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            AgendaCita fmAgnCliente = new AgendaCita();
            fmAgnCliente.Show();//llamar al formulario Agenda Cita
            this.Hide();//esconder clase Nueva Cita

        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Cliente
        {
            InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente.Show();//llamar al formulario Informacion Cliente
            this.Hide();//esconder clase Nueva Cita
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            Mercancia fmMercancia = new Mercancia();
            fmMercancia.Show();//llamar al formulario Mercancia
            this.Hide();//esconder clase Nueva Cita
        }
    }
}
