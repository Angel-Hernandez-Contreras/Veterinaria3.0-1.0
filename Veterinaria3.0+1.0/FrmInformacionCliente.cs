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
        public int id = 0;
        public FrmInformacionCliente()
        {
            InitializeComponent();
        }

 //*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Informacion Clientes)
        }

//*********************************************************************************************************
        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)//textbox para buscar mediante Nombre Cliente
        {
            using (var context = new ApplicationDbContext())
            {
                var cliente = context.Cliente.Where(x => x.Nombre.Contains(txtBuscarNombre.Text)).ToList();
                dgvCliente.DataSource = cliente;

                var mascota = context.Mascota.Where(x => x.NombreCliente.Contains(txtBuscarNombre.Text)).ToList();
                dgvMascota.DataSource = mascota;
            }
        }

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar
        {
            txtBuscarNombre.Text = "";
        }

//*********************************************************************************************************
        private void btnEliminar_Click(object sender, EventArgs e)//boton eliminar cliente
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var cliente = context.Cliente.First(x => x.Id == id);
                    if (cliente != null)
                    {
                        context.Remove(cliente);
                        context.SaveChanges();
                    }

                    var mascota = context.Mascota.First(x => x.Id == id);
                    if (mascota != null)
                    {
                        context.Remove(mascota);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
