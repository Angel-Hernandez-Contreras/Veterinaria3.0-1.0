using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria3._0_1._0.Models;

namespace Veterinaria3._0_1._0
{
    public partial class NuevaCita : Form
    {
        public int id = 0;
        public NuevaCita()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Nueva Cita)
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

//*********************************************************************************************************
        private void btnAgregarCita_Click(object sender, EventArgs e)//boton Agregar Cita
        {
            AgregarCita();
            Limpiar();
        }

//*********************************************************************************************************
        private void AgregarCita()//metodo para agregar cita/ agregar cliente/ agregar mascota a sus tablas respectivas
        {
            using (var context = new ApplicationDbContext())
            {
                var agregarCliente = new Cliente();
                agregarCliente.IdCliente = txtIdCliente.Text;
                agregarCliente.Nombre = txtNombreCliente.Text;
                agregarCliente.Apellido = txtApellidoCliente.Text;
                agregarCliente.Sexo = rbMasculino.Checked ? "Masculino" : "Femenino";
                agregarCliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                context.Cliente.Add(agregarCliente);

                var agregarMascota = new Mascota();
                agregarMascota.NombreCliente = txtNombreCliente.Text;
                agregarMascota.NombreMascota = txtNombreMascota.Text;
                agregarMascota.Especie = Convert.ToString(cbEspecieMascota.SelectedItem);
                agregarMascota.ColorPelo = txtColorPeloMascota.Text;
                agregarMascota.Sexo = rbMachoMascota.Checked ? "Macho" : "Femenino";
                context.Mascota.Add(agregarMascota);

                context.SaveChanges();

                dgvFichaCita.CurrentRow.Cells[0].Value = Convert.ToString(txtIdCliente.Text);
                dgvFichaCita.CurrentRow.Cells[1].Value = dtpFechaCita.Value;
                dgvFichaCita.CurrentRow.Cells[2].Value = Convert.ToString(cbHoraCita.SelectedItem);
                dgvFichaCita.CurrentRow.Cells[3].Value = Convert.ToString(cbNombreVeterinario.SelectedItem);

            }
        }

//*********************************************************************************************************
        private void Limpiar()//metodo para limpiar el formulario Nueva Cita
        {
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtTelefonoCliente.Text = "";

            txtNombreMascota.Text = "";
            txtColorPeloMascota.Text = "";

        }
        
    }
}
