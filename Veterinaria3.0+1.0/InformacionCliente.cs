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
        int n = 0;
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
        /*string[] Arreglo_FechaCita = new string[10];
        string[] Arreglo_HoraCita = new string[10];
        string[] Arreglo_Veterinario = new string[10];
        string[] Arreglo_TelefonoVeterinario = new string[10];*/
        public InformacionCliente()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnNuevaCita_Click_1(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Informacion Cliente
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click_1(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            AgendaCita fmAC = new AgendaCita();
            fmAC.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar clase Informacion Cliente
        }

//*********************************************************************************************************
        private void btnCajero_Click(object sender, EventArgs e)//boton para ingresar a Cajero
        {
            Cajero fmCajero = new Cajero();
            fmCajero.Show();//llamar al formulario Cajero
            this.Close();//cerrar clase Informacion Cliente
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            Mercancia fmMercancia = new Mercancia();
            fmMercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar clase Informacion Mercancia
        }

//*********************************************************************************************************
        public InformacionCliente( 
            /*informacion cliente*/String IdCliente, String NombreCliente, String ApellidoCliente, String CuentaBancoCliente, String telefonoCliente, 
            /*informacion mascota*/String NombreMascota, String EspecieMascota, String RazaMascota, String ColorPeloMascota, String SexoMascota
            )
        {
            n = 0;
            InitializeComponent();
            while (Arreglo_IdCliente[n] != null)
            {
                n++;
            }
            //arreglo informacio cliente
            this.Arreglo_IdCliente[n] = IdCliente;
            this.Arreglo_NombreCliente[n] = NombreCliente;
            this.Arreglo_ApellidoCliente[n] = ApellidoCliente;
            this.Arreglo_CuentaBancoCliente[n] = CuentaBancoCliente;
            this.Arreglo_TelefonoCliente[n] = telefonoCliente;
            //arreglo informacion mascota
            this.Arreglo_NombreMascota[n] = NombreMascota;
            this.Arreglo_EspecieMascota[n] = EspecieMascota;
            this.Arreglo_RazaMascota[n] = RazaMascota;
            this.Arreglo_ColorPeloMascota[n] = ColorPeloMascota;
            this.Arreglo_SexoMascota[n] = SexoMascota;
      
        }

//*********************************************************************************************************
        private void btnBuscar_Click(object sender, EventArgs e)//boton Buscar
        {
            n = 0;
            while (Arreglo_IdCliente[n] != txtIdCliente.Text)
            {
                n++;
                if (n < 10)
                {
                    MessageBox.Show("No se encontro el Cliente", "Error", MessageBoxButtons.OK);
                    break;
                }

            }
            lblNombreCliente.Text = Arreglo_NombreCliente[n];
            lblApellidoCliente.Text = Arreglo_ApellidoCliente[n];
            lblCuentaBanco.Text = Arreglo_CuentaBancoCliente[n];
            lblTelefonoCliente.Text = Arreglo_TelefonoCliente[n];

            lblNombreMascota.Text = Arreglo_NombreMascota[n];
            lblEspecieMascota.Text = Arreglo_EspecieMascota[n];
            lblRazaMascota.Text = Arreglo_RazaMascota[n];
            lblColorPeloMascota.Text = Arreglo_ColorPeloMascota[n];
            lblSexoMascota.Text = Arreglo_ColorPeloMascota[n];
        }

    }
}
