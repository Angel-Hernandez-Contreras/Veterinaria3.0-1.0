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
        public int id = 0;//recibe el valor de la posicion del la fila del DataGridView
        public int cantidad = 0;//recibe el valor del CantidadProducto para utilizarla en una operacion
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
        private void FrmMercancia_Load(object sender, EventArgs e)//carga las Mercancias al abrir el formulario
        {
            TodosMercancia();//llama al metodo Todos Mercancia
        }//fin del metodo

//*********************************************************************************************************
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)//textbox para buscar mediante Nombre del Producto
        {
            using (var context = new ApplicationDbContext())
            {
                var nombre = context.Mercancia.Where(x => x.Nombre.Contains(txtBuscarNombreProducto.Text.ToUpper())).ToList();//buscar con un ORM
                dgvMercancia.DataSource = nombre;

            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregar_Click(object sender, EventArgs e)//boton para agregar producto
        {
            Agregar();//lama al metodo Agregar
            TodosMercancia();//llama al metodo Todos Mercancia
        }//fin del metodo

//*********************************************************************************************************
        private void btnModificar_Click(object sender, EventArgs e)//boton para modificar producto
        {
            Modificar();//llama al metodo Modificar
            TodosMercancia();//llama al metodo Todos Mercancia
        }//fin del metodo

//*********************************************************************************************************
        private void btnActivarDesactivar_Click(object sender, EventArgs e)//boton para Activar/Desactivar un Producto
        {
            ActivarDesactivar();//llama al metodo Activar Desactivar
            TodosMercancia();//llama al metodo Todos Mercancia
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregarExistencias_Click(object sender, EventArgs e)//boton para Agregar Existencias a un producto
        {
            Agregar();//llama al metodo Agregar
            TodosMercancia();//llama al metodo Todos Mercancia
        }//fin del metodo

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar
        {
            Limpiar();//llama al metodo Limpiar
        }//fin del metodo

//*********************************************************************************************************
        private void TodosMercancia()//metodo para mostrar la lista de las mercancias
        {
            using (var context = new ApplicationDbContext())
            {
                    var mercancia = context.Mercancia.ToList();
                    dgvMercancia.DataSource = mercancia;
            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        public void Agregar()//metodo para agregar Productos
        {
            using (var context = new ApplicationDbContext())
            {
                if (txtBuscarNombreProducto.Text.Length != 0 && txtAgregarPrecioProducto.Text.Length != 0)//if para no agregar si las casillas no estan llenas
                {
                    var agregar = new Mercancia();
                    agregar.Nombre = txtAgregarNombreProducto.Text.ToUpper();
                    agregar.Precio = Convert.ToInt32(txtAgregarPrecioProducto.Text.ToUpper());
                    agregar.Estado = "ACTIVO";
                    context.Mercancia.Add(agregar);

                    Limpiar();

                    context.SaveChanges();
                }
            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        public void Modificar()//metodo para modificar Productos
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {                
                    var mercancia = context.Mercancia.First(x => x.Id == id);//buscar con un ORM
                    if (mercancia != null)
                    {
                        mercancia.Nombre = txtAgregarNombreProducto.Text.ToUpper();
                        mercancia.Precio = Convert.ToDouble(txtAgregarPrecioProducto.Text.ToUpper());
                        context.SaveChanges();
                    }
                    Limpiar();//llama al metodo Limpiar
                }
            }//fin del using
        }//fin del metodo 

//*********************************************************************************************************
        public void ActivarDesactivar()//metodo para cambiar el Estado del producto
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {         
                    var mercancia = context.Mercancia.First(x => x.Id == id);//buscar con un ORM
                    if (mercancia != null)
                    {
                        if (mercancia.Cantidad == 0)//if por si la cantidad del producto es igual a 0 no se ejecute nada
                        {
                            //aqui no va nada
                        }
                        else//else cambiar el estado del producto de Activo a Inactivo, o de Inactivo a Activo
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
                    }
                    Limpiar();//llama al metodo Limpiar
                }
            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        public void AgregarExistencia()//metodo para agregar Existencias al Producto
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    if (Convert.ToInt32(lblCantidadProducto.Text) != 0)
                    {                  
                        var mercancia = context.Mercancia.First(x => x.Id == id);//buscar con un ORM
                        if (mercancia != null)
                        {
                            mercancia.Cantidad = Convert.ToInt32(lblCantidadProducto.Text);
                            context.SaveChanges();
                        }
                        Limpiar();//llama al metodo limpiar
                    }
                }
            }//fin del using 
        }//fin del metodo
//*********************************************************************************************************
        public void Limpiar()//metodo para limpiar
        {
            txtAgregarNombreProducto.Text = "";
            txtAgregarNombreProducto.Text = "";
            lblCantidadProducto.Text = "";
            txtAgregarPrecioProducto.Text = "";
        }

//*********************************************************************************************************
        private void dgvMercancia_CellContentClick(object sender, DataGridViewCellEventArgs e)//metodo para poder seleccionar una cita en el DataGridView
        {
            id = Convert.ToInt32(dgvMercancia.CurrentRow.Cells[0].Value.ToString());
            txtAgregarNombreProducto.Text = dgvMercancia.CurrentRow.Cells[1].Value.ToString();
            lblCantidadProducto.Text = dgvMercancia.CurrentRow.Cells[2].Value.ToString();
            txtAgregarPrecioProducto.Text = dgvMercancia.CurrentRow.Cells[3].Value.ToString();
        }
//---------------------------------------------------------------------------------------------------------

//*********************************************************************************************************

//---------------------ESTOS METODOS SON LOS BOTONES PARA AGREGAR EXISTENCIA AL PRODUCTO---------------------
        private void btnCantidad1_Click_1(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(lblCantidadProducto.Text) + 1;
            lblCantidadProducto.Text = cantidad.ToString();
        }

//*********************************************************************************************************
        private void btnCantidad5_Click_1(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(lblCantidadProducto.Text) + 5;
            lblCantidadProducto.Text = cantidad.ToString();
        }

//*********************************************************************************************************
        private void btnCantidad10_Click_1(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(lblCantidadProducto.Text) + 10;
            lblCantidadProducto.Text = cantidad.ToString();

        }
        
//*********************************************************************************************************
        private void btnCantidad50_Click_1(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(lblCantidadProducto.Text) + 50;
            lblCantidadProducto.Text = cantidad.ToString();

        }

//*********************************************************************************************************
    }
}
