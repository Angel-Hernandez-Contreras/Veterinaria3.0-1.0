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
        private void cbEspecieMascota_SelectedIndexChanged(object sender, EventArgs e)//ComboBox para mostar una imagen de la mascota seleccionada
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
            AgregarCita();//llama al metodo Agregar Cita
            Limpiar();//llama al metodo Limpiar
        }//fin del metodo

//*********************************************************************************************************
        private void AgregarCita()//metodo para agregar cita/ agregar cliente/ agregar mascota a sus tablas respectivas
        {
            using (var context = new ApplicationDbContext())
            {
                if (txtNombreCliente.Text.Length != 0 && txtApellidoCliente.Text.Length != 0 && txtTelefonoCliente.Text.Length != 0 && //if para que se llenen todas las casillas
                    txtNombreMascota.Text.Length != 0 && txtColorPeloMascota.Text.Length != 0) {

                    var agregarCliente = new Cliente();//Modelo Cliente
                    agregarCliente.Nombre = txtNombreCliente.Text.ToUpper();
                    agregarCliente.Apellido = txtApellidoCliente.Text.ToUpper();
                    agregarCliente.Sexo = rbMasculino.Checked ? "MASCULINO" : "FEMENINO";
                    agregarCliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text.ToUpper());
                    context.Cliente.Add(agregarCliente);

                    var agregarMascota = new Mascota();//Modelo Mascota
                    agregarMascota.NombreCliente = txtNombreCliente.Text.ToUpper();
                    agregarMascota.NombreMascota = txtNombreMascota.Text.ToUpper();
                    agregarMascota.Especie = Convert.ToString(cbEspecieMascota.SelectedItem).ToUpper();
                    agregarMascota.ColorPelo = txtColorPeloMascota.Text.ToUpper();
                    agregarMascota.Sexo = rbMachoMascota.Checked ? "MACHO" : "HEMBRA";
                    foreach (var item in chbVacunacionesMascota.CheckedItems)//for para agregar en una casilla todas las vacunas seleccionadas
                    {
                        agregarMascota.Vacunas = agregarMascota.Vacunas + item.ToString() + "; ";
                    }//fin del foreach
                    context.Mascota.Add(agregarMascota);

                    var agregarCita = new Cita();//Modelo Cita
                    agregarCita.NombreCliente = txtNombreCliente.Text.ToUpper();
                    agregarCita.FechaCita = Convert.ToString(dtpFechaCita.Value).ToUpper();
                    agregarCita.HoraCita = Convert.ToString(cbHoraCita.SelectedItem).ToUpper();
                    agregarCita.NombreVeterinario = Convert.ToString(cbNombreVeterinario.SelectedItem).ToUpper();
                    context.Cita.Add(agregarCita);

                    context.SaveChanges();
                    //----------agrega los datos a la Ficha de la Cita----------
                    int n = dgvFichaCita.Rows.Add();
                    dgvFichaCita.CurrentRow.Cells[0].Value = txtNombreCliente.Text.ToUpper();
                    dgvFichaCita.CurrentRow.Cells[1].Value = Convert.ToString(dtpFechaCita.Value).ToUpper();
                    dgvFichaCita.CurrentRow.Cells[2].Value = Convert.ToString(cbHoraCita.SelectedItem).ToUpper();
                    dgvFichaCita.CurrentRow.Cells[3].Value = Convert.ToString(cbNombreVeterinario.SelectedItem).ToUpper();
                }
                else//else que habisa si todas las casillas no han sido llenadas
                {
                    lblResultado.Text = "TODAS LAS CASILLAS DEBEN SER LLENADAS";
                }
            }//find el using
        }//fin del metodo

//*********************************************************************************************************
        private void Limpiar()//metodo para limpiar el formulario Nueva Cita
        {
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtTelefonoCliente.Text = "";

            txtNombreMascota.Text = "";
            txtColorPeloMascota.Text = "";

            lblResultado.Text = "";
        }//fin del metodo
//*********************************************************************************************************
    }
}
