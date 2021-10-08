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
        //areglo Informacion Cliente
        string[] Arreglo_IdCliente = new string[10];
        string[] Arreglo_NombreCliente = new string[10];
        string[] Arreglo_ApellidoCliente = new string[10];
        string[] Arreglo_CuentaBancoCliente = new string[10];
        string[] Arreglo_TelefonoCliente = new string[10];
        //arreglo Informacion Mascota
        string[] Arreglo_NombreMascota = new string[10];
        string[] Arreglo_EspecieMascota = new string[10];
        string[] Arreglo_RazaMascota = new string[10];
        string[] Arreglo_ColorPeloMascota = new string[10];
        string[] Arreglo_SexoMascota = new string[10];
        string[] Arreglo_VacunacionMascota = new string[10];
        //arreglo Cita
        string[] Arreglo_FechaCita = new string[10];
        string[] Arreglo_HoraCita = new string[10];
        string[] Arreglo_Veterinario = new string[10];
        string[] Arreglo_TelefonoVeterinario = new string[10];
        public NuevaCita()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnAgregarCita_Click_1(object sender, EventArgs e)//boton Agregar Cita
        {         
            int n = dgvFichaCita.Rows.Add();
            //ingreso la Informaciion de cliente, mascota y cita en arreglos
            Arreglo_IdCliente[n] = txtIdCliente.Text;
            Arreglo_NombreCliente[n] = txtNombreCliente.Text;
            Arreglo_ApellidoCliente[n] = txtApellidoCliente.Text;
            Arreglo_CuentaBancoCliente[n] = txtApellidoCliente.Text;
            Arreglo_TelefonoCliente[n] = txtTelefonoCliente.Text;

            Arreglo_NombreMascota[n] = txtNombreMascota.Text;
            Arreglo_EspecieMascota[n] = Convert.ToString(cbEspecieMascota.SelectedItem);
            Arreglo_RazaMascota[n] = Convert.ToString(cbRazaMascota.SelectedItem);
            Arreglo_ColorPeloMascota[n] = txtColorPeloMascota.Text;
            Arreglo_SexoMascota[n] = rbMachoMascota.Checked ? "Masculino" : "Hembra";
            //Arreglo_VacunacionMascota[n] = Convert.ToString();

            Arreglo_FechaCita[n] = dtpFechaCita.Value.ToString();
            Arreglo_HoraCita[n] = txtHoraCita.Text;
            Arreglo_Veterinario[n] = Convert.ToString(cbNombreVeterinario.SelectedItem);
            Arreglo_TelefonoVeterinario[n] = txtTelefonoVeterinario.Text;

            //-------------AGREGAR FICHA CITA
            dgvFichaCita.Rows[n].Cells[0].Value = Arreglo_IdCliente[n];
            dgvFichaCita.Rows[n].Cells[1].Value = Arreglo_FechaCita[n];
            dgvFichaCita.Rows[n].Cells[2].Value = Arreglo_HoraCita[n];
            dgvFichaCita.Rows[n].Cells[3].Value = Arreglo_Veterinario[n];
           
            /*InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente[n] = new InformacionCliente(Arreglo_NombreCliente);*/
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
