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
    public partial class FrmMercancia : Form
    {
        public int id = 0;
        public FrmMercancia()
        {
            InitializeComponent();
        
        }

//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Mercancia)
        }

//*********************************************************************************************************
        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)//textbox para buscar mediante codigo producto
        {
            using (var context = new ApplicationDbContext())
            {
                var codigo = context.Mercancia.Where(x => x.Codigo.Contains(txtBuscarCodigoProducto.Text)).ToList();
                dgvMercancia.DataSource = codigo;

            }
        }

//*********************************************************************************************************
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)//textbox para buscar mediante nombre producto
        {
            using (var context = new ApplicationDbContext())
            {
                var nombre = context.Mercancia.Where(x => x.Codigo.Contains(txtBuscarNombreProducto.Text)).ToList();
                dgvMercancia.DataSource = nombre;

            }
        }

//*********************************************************************************************************
        private void btnAgregar_Click(object sender, EventArgs e)//boton para agregar producto
        {
            using (var context = new ApplicationDbContext())
            {
                var agregar = new Mercancia();
                agregar.Codigo = txtAgregarCodigoProducto.Text;
                agregar.Nombre = txtAgregarNombreProducto.Text;
                agregar.Cantidad = Convert.ToInt32(txtAgregarCantidadProducto.Text);
                agregar.Precio = Convert.ToInt32(txtAgregarPrecioProducto.Text);

                context.SaveChanges();
            }

            TodosMercancia();
        }

//*********************************************************************************************************
        private void btnModificar_Click(object sender, EventArgs e)//boton para modificar producto
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //buscar con un ORM
                    var mercancia = context.Mercancia.First(x => x.Id == id);
                    if (mercancia != null)
                    {
                        mercancia.Codigo = txtAgregarCodigoProducto.Text;
                        mercancia.Nombre = txtAgregarNombreProducto.Text;
                        mercancia.Cantidad = Convert.ToInt32(txtAgregarCantidadProducto.Text);
                        mercancia.Precio = Convert.ToInt32(txtAgregarPrecioProducto.Text);
                        context.SaveChanges();
                    }
                }
            }

            TodosMercancia();
        }

//*********************************************************************************************************
        private void btnEliminar_Click_1(object sender, EventArgs e)//bton para eliminar producto
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //buscar con un ORM
                    var mercancia = context.Mercancia.First(x => x.Id == id);
                    if (mercancia != null)
                    {
                        context.Remove(mercancia);
                        context.SaveChanges();
                    }
                }
            }

            TodosMercancia();
        }

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)//boton par alimpiar
        {
            txtBuscarCodigoProducto.Text = "";
            txtAgregarNombreProducto.Text = "";

            txtAgregarCodigoProducto.Text = "";
            txtAgregarNombreProducto.Text = "";
            txtAgregarCantidadProducto.Text = "";
            txtAgregarCantidadProducto.Text = "";
        }

//*********************************************************************************************************
        private void TodosMercancia()
        {
            /*using (var context = new ApplicationDbContext())
                {
                    var mercancia = context.Mercancia.ToList();
                    dgvMercancia.DataSource = mercancia;
                }*/
        }

    }
}
