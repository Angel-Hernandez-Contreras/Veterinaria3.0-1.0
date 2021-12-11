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

    public partial class FrmInformacionCliente : Form
    {
        public int id = 0;//recibe el valor del Id seleccionado en el DataGridView
        public FrmInformacionCliente()
        {
            InitializeComponent();
        }//fin del metodo

//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Informacion Clientes)
        }//fin del metodo

//*********************************************************************************************************
        private void FrmInformacionCliente_Load(object sender, EventArgs e)//carga las citas al abrir el formulario
        {
            TodosCliente();//llama al metodo Todos Clientes
        }//fin del metodo

//*********************************************************************************************************
        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)//textbox para buscar mediante Nombre Cliente
        {
            using (var context = new ApplicationDbContext())
            {
                var cliente = context.Cliente.Where(x => x.Nombre.Contains(txtBuscarNombre.Text.ToUpper())).ToList();//buscar con un ORM
                dgvCliente.DataSource = cliente;

                var mascota = context.Mascota.Where(x => x.NombreCliente.Contains(txtBuscarNombre.Text.ToUpper())).ToList();//buscar con un ORM
                dgvMascota.DataSource = mascota;
            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar
        {
            txtBuscarNombre.Text = "";
        }//fin del metodo

//*********************************************************************************************************
        private void btnEliminar_Click(object sender, EventArgs e)//boton eliminar cliente
        {
            Eliminar();
        }//fin del metodo

//*********************************************************************************************************
        public void Eliminar()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var cliente = context.Cliente.First(x => x.Id == id);//buscar con un ORM
                    if (cliente != null)
                    {
                        context.Remove(cliente);
                        context.SaveChanges();
                    }

                    var mascota = context.Mascota.First(x => x.Id == id);//buscar con un ORM
                    if (mascota != null)
                    {
                        context.Remove(mascota);
                        context.SaveChanges();
                    }
                }
                TodosCliente();//llama al metodo Todos Cliente
            }//fin del using
        }
//*********************************************************************************************************
        private void TodosCliente()//metodo para mostrar la lista de los clientes y mascotas
        {
            using (var context = new ApplicationDbContext())
            {
            var cliente = context.Cliente.ToList();
            dgvCliente.DataSource = cliente;

            var mascota = context.Mascota.ToList();
            dgvMascota.DataSource = mascota;

            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)//metodo para poder seleccionar una cita en el DataGridView
        {
            id = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value.ToString());
        }//fin del metodo

//*********************************************************************************************************
    }
}
