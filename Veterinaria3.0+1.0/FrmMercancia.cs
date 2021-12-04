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
        private void FrmMercancia_Load(object sender, EventArgs e)
        {
            TodosMercancia();
        }

//*********************************************************************************************************
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)//textbox para buscar mediante nombre producto
        {
            using (var context = new ApplicationDbContext())
            {
                var nombre = context.Mercancia.Where(x => x.Nombre.Contains(txtBuscarNombreProducto.Text.ToUpper())).ToList();
                dgvMercancia.DataSource = nombre;

            }
        }

//*********************************************************************************************************
        private void btnAgregar_Click(object sender, EventArgs e)//boton para agregar producto
        {
            using (var context = new ApplicationDbContext())
            {
                if (txtBuscarNombreProducto.Text.Length != 0 && txtAgregarCantidadProducto.Text.Length != 0 && txtAgregarPrecioProducto.Text.Length != 0)
                {
                    var agregar = new Mercancia();
                    agregar.Nombre = txtAgregarNombreProducto.Text.ToUpper();
                    agregar.Cantidad = Convert.ToInt32(txtAgregarCantidadProducto.Text.ToUpper());
                    agregar.Precio = Convert.ToInt32(txtAgregarPrecioProducto.Text.ToUpper());
                    agregar.Estado = "ACTIVO";
                    context.Mercancia.Add(agregar);

                    Limpiar();

                    context.SaveChanges();
                }
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
                        mercancia.Nombre = txtAgregarNombreProducto.Text.ToUpper();
                        mercancia.Cantidad = Convert.ToInt32(txtAgregarCantidadProducto.Text.ToUpper());
                        mercancia.Precio = Convert.ToDouble(txtAgregarPrecioProducto.Text.ToUpper());
                        context.SaveChanges();
                    }
                    Limpiar();
                }
            }    
            TodosMercancia();
        }

//*********************************************************************************************************
        private void btnActivarDesactivar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    //buscar con un ORM
                    var mercancia = context.Mercancia.First(x => x.Id == id);
                    if (mercancia != null)
                    {
                        if (mercancia.Estado == "INACTIVO")
                        {
                            mercancia.Estado = "ACTIVO";
                        }
                        else
                        {
                            mercancia.Estado = "INACTIVO";
                        }
                        context.SaveChanges();
                    }
                    Limpiar();
                }
                TodosMercancia();
            }
        }

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)//boton par alimpiar
        {
            Limpiar();
        }

//*********************************************************************************************************
        private void TodosMercancia()
        {
            using (var context = new ApplicationDbContext())
                {
                    var mercancia = context.Mercancia.ToList();
                    dgvMercancia.DataSource = mercancia;
                }
        }

//*********************************************************************************************************
        private void dgvMercancia_CellContentClick(object sender, DataGridViewCellEventArgs e)//metodo para poder seleccionar una cita en el DataGridView
        {
            id = Convert.ToInt32(dgvMercancia.CurrentRow.Cells[0].Value.ToString());

            txtAgregarNombreProducto.Text = dgvMercancia.CurrentRow.Cells[1].Value.ToString();
            txtAgregarCantidadProducto.Text = dgvMercancia.CurrentRow.Cells[2].Value.ToString();
            txtAgregarPrecioProducto.Text = dgvMercancia.CurrentRow.Cells[3].Value.ToString();
        }

//*********************************************************************************************************
        public void Limpiar()//metodo para limpiar
        {
            txtAgregarNombreProducto.Text = "";

            txtAgregarNombreProducto.Text = "";
            txtAgregarCantidadProducto.Text = "";
            txtAgregarPrecioProducto.Text = "";
        }
        
    }
}
