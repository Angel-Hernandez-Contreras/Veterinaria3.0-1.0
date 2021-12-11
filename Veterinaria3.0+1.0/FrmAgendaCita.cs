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
    public partial class FrmAgendaCita : Form
    {
        //Lista de veterinarios que trabajan en en la mañana
        public String[] veterinarioMañana = { "Mario Gomez", "Joaquin Guzman", "Andres manuel" };
        //Lista de veterinarios que trabajan en la Tarde
        public String[] veterinariosTarde = { "Salinas gortari", "Guadalupe Victoria", "Felix Gallardo" };
        public int id = 0;//recibe el valor del Id seleccionado en el DataGridView
        public FrmAgendaCita()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Agenda Cita)
        }

//*********************************************************************************************************
        private void AgendaCita_Load(object sender, EventArgs e)//carga las citas al abrir el formulario
        {
            TodosCita();//llama al metodo Todos Cita
        }//fin del metodo

//*********************************************************************************************************
        private void txtBuscar_TextChanged(object sender, EventArgs e)//textbox para Buscar Cita
        {
            using (var context = new ApplicationDbContext())
            {
                var cita = context.Cita.Where(x => x.NombreCliente.Contains(txtBuscar.Text)).ToList();
                dgvAgendaCita.DataSource = cita;
            }
        }//fin del metodo

//*********************************************************************************************************
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();//llama al metodo Modificar
            TodosCita();//llama al metodo Todos Cita
        }//fin del metodo

//********************************************************************************************************* 
        private void btnEliminar_Click(object sender, EventArgs e)//boton para elñiminar cita
        {
            Eliminar();//llama al metodo Eliminar
            TodosCita();//llama al metodo Todos Cita
        }

//********************************************************************************************************* 
        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar el TextBox Bucar
        {
            txtBuscar.Text = "";
        }

//********************************************************************************************************* 
        public void TodosCita()//metodo para mostrar la lista de las citas
        {
           using (var context = new ApplicationDbContext())
           {
               var cita = context.Cita.ToList();
               dgvAgendaCita.DataSource = cita;
           }//fin del using
        }//fin del metodo

//********************************************************************************************************* 
        public void Modificar()//metodo para Modificar la Ficha de la Cita
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var cita = context.Cita.First(x => x.Id == id);//buscar con un ORM
                    if (cita != null)
                    {
                        cita.FechaCita = Convert.ToString(dtpFechaCita.Value).ToUpper();
                        cita.HoraCita = Convert.ToString(cbHoraCita.SelectedItem).ToUpper();
                        cita.NombreVeterinario = Convert.ToString(cbNombreVeterinario.SelectedItem).ToUpper();
                        context.SaveChanges();
                    }
                }
            }//fin del using
        }//fin del metodo
//********************************************************************************************************* 
        public void Eliminar()//metodo para Eliminar la Ficha de la Cita
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {                   
                    var cita = context.Cita.First(x => x.Id == id);//buscar con un ORM
                    if (cita != null)
                    {
                        context.Remove(cita);
                        context.SaveChanges();
                    }
                }
            }//fin del using
        }//fin del metodo

//********************************************************************************************************* 
        private void dgvAgendaCita_CellContentClick(object sender, DataGridViewCellEventArgs e)//metodo para poder seleccionar una cita en el DataGridView
        {
            id = Convert.ToInt32(dgvAgendaCita.CurrentRow.Cells[0].Value.ToString());          
        }//fin del metodo

//********************************************************************************************************* 
        private void cbHoraCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dependiendo de la hora los doctores disponibles son diferentes
            if (cbHoraCita.SelectedIndex + 1 >= 6)
            {
                cbNombreVeterinario.DataSource = veterinariosTarde;
            }else{
                cbNombreVeterinario.DataSource = veterinarioMañana;
            }
        }//fin del metodo

//********************************************************************************************************* 
    }
}
