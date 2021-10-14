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
            this.Close();//cerrar clase Nueva Cita

        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Cliente
        {
            InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Nueva Cita
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            Mercancia fmMercancia = new Mercancia();
            fmMercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar clase Nueva Cita
        }

//*********************************************************************************************************
        private void cbEspecieMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEspecieMascota.SelectedIndex+1)
            {
                case 1:
                    //pbAnimal.Image = Image.FromFile("C:\\Users\\HP\\Source\\Repos\\Veterinaria3.0-1.0\\Veterinaria3.0+1.0\\imagenes\\gato.jpg");
                    pbAnimal.Image = Image.FromFile("C:\\Users\\herna_a09rita\\source\\repos\\Veterinaria3.0+1.0\\Veterinaria3.0+1.0\\imagenes\\gato.jpg");
                    break;
                case 2:
                    //pbAnimal.Image = Image.FromFile("C:\\Users\\HP\\Source\\Repos\\Veterinaria3.0-1.0\\Veterinaria3.0+1.0\\imagenes\\perro.jpg");
                    pbAnimal.Image = Image.FromFile("C:\\Users\\herna_a09rita\\source\\repos\\Veterinaria3.0+1.0\\Veterinaria3.0+1.0\\imagenes\\perro.jpg");
                    break;
                case 3:
                    //pbAnimal.Image = Image.FromFile("C:\\Users\\HP\\Source\\Repos\\Veterinaria3.0-1.0\\Veterinaria3.0+1.0\\imagenes\\cuyo.jpg");
                    pbAnimal.Image = Image.FromFile("C:\\Users\\herna_a09rita\\source\\repos\\Veterinaria3.0+1.0\\Veterinaria3.0+1.0\\imagenes\\cuyo.jpg");
                    break;
                case 4:
                    //pbAnimal.Image = Image.FromFile("C:\\Users\\HP\\Source\\Repos\\Veterinaria3.0-1.0\\Veterinaria3.0+1.0\\imagenes\\pato.jpg");
                    pbAnimal.Image = Image.FromFile("C:\\Users\\herna_a09rita\\source\\repos\\Veterinaria3.0+1.0\\Veterinaria3.0+1.0\\imagenes\\pato.jpg");
                    break;
                default:
                    break;
            }
        }
    }
}
