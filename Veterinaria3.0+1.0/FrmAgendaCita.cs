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
        public int id = 0;
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
            TodosCita();
        }

        //*********************************************************************************************************
        private void txtBuscar_TextChanged(object sender, EventArgs e)//textbox para Buscar Cita
        {
            using (var context = new ApplicationDbContext())
            {
                var cita = context.Cita.Where(x => x.IdCliente.Contains(txtBuscar.Text)).ToList();
                dgvAgendaCita.DataSource = cita;
            }
        }

//*********************************************************************************************************
        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //buscar con un ORM
                    var cita = context.Cita.First(x => x.Id == id);
                    if (cita != null)
                    {
                        cita.FechaCita = Convert.ToString(dtpFechaCita.Value);
                        cita.HoraCita = Convert.ToString(cbHoraCita.SelectedItem);
                        cita.NombreVeterinario = Convert.ToString(cbNombreVeterinario.SelectedItem);
                        context.SaveChanges();
                    }
                }
            }

            TodosCita();
        }

//********************************************************************************************************* 
        private void btnEliminar_Click(object sender, EventArgs e)//boton para elñiminar cita
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //buscar con un ORM
                    var cita = context.Cita.First(x => x.Id == id);
                    if (cita != null)
                    {
                        context.Remove(cita);
                        context.SaveChanges();
                    }
                }
            }

            TodosCita();
        }

//********************************************************************************************************* 
        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar
        {
            txtBuscar.Text = "";
        }

//********************************************************************************************************* 
        private void TodosCita()//metodo para mostrar la lista de las citas
        {
            /*using (var context = new ApplicationDbContext())
           {
               var cita = context.Cita.ToList();
               dgvAgendaCita.DataSource = cita;

           }*/
        }
    }
}
