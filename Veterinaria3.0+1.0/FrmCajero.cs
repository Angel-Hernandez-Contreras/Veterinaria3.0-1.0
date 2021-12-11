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
    public partial class FrmCajero : Form
    {
        public int posicion = 0;//recibe el valor de la posicion del la fila del DataGridView
        public int CantidadProducto = 0;//recibe el valor del CantidadProducto para utilizarla en una operacion

        public FrmCajero()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void FrmCajero_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var mercancia = context.Mercancia.ToList();
                dgvProducto.DataSource = mercancia;
            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        private void btnRegresar_Click(object sender, EventArgs e)//boton para ingresar a Menu
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();//llamar al formulario Menu
            this.Close();//cerrar esta clase (Cajero)
        }//fin del metodo

//*********************************************************************************************************
        private void btnLimpiar_Click(object sender, EventArgs e)//boton para limpiar
        {
            Limpiar();//llama al metodo Limpiar
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregarProducto_Click(object sender, EventArgs e)//boton para agregar producto al ticket
        {
            AgregarProducto();//llama al metodo Agregar Producto
        }//fin del metodo

//*********************************************************************************************************
        private void btnModificarCantidad_Click(object sender, EventArgs e)//boton para modificar la cantidad de producto agregado al ticket
        {
            ModificarProducto();//llama al metodo Modificar Producto
        }//fin del metodo

//*********************************************************************************************************
        private void btnEliminarProducto_Click(object sender, EventArgs e)//boton para eliminar el producto agregado al ticket
        {
            EliminarProducto();//llama al metodo Eliminar Producto
        }//fin del metodo

//*********************************************************************************************************
        private void btnTerminarProceso_Click(object sender, EventArgs e)//boton para limpiar toda la ventada
        {
            TerminarProceso();//llama al metodo Terminar Proceso
        }//fin del metodo

//*********************************************************************************************************
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var mercancia = context.Mercancia.Where(x => x.Nombre.Contains(txtNombreProducto.Text.ToUpper())).ToList();
                dgvProducto.DataSource = mercancia;
            }//fin del using
        }//fin del metodo

//*********************************************************************************************************
        public void AgregarProducto()//metodo para Agregar Producto al Ticket
        {
            if (txtNombreProducto.Text.Length != 0 && lblCantidadProducto.Text != "0" && txtNombreProducto.Text.ToUpper() == dgvProducto.CurrentRow.Cells[1].Value.ToString().ToUpper())//if para que Nombre y Cantidad de Producto no esten vacias
            {
                using (var context = new ApplicationDbContext())
                {
                    var mercancia = context.Mercancia.First(x => x.Nombre == dgvProducto.CurrentRow.Cells[1].Value.ToString().ToUpper()/*txtNombreProducto.Text.ToUpper()*/);
                    if (mercancia != null)
                    {
                        if (mercancia.Estado == "INACTIVO")//if para para que no agregue un Producto al Ticket si este esta Inactivo
                        {
                            lblResultado.Text = "EL PRODUCTO NO ESTA ACTIVO";
                        }
                        else if (mercancia.Cantidad < Convert.ToInt32(lblCantidadProducto.Text))//else/if para que no agregue un Producto al Ticket si se este la Cantidad es mayor que la Existencia
                        {
                            lblResultado.Text = "LA EXISTENCIA DEL PRODUCTO ES DE [" + Convert.ToString(mercancia.Cantidad + "]");
                        }
                        else//else donde agrega los datos al ticket
                        {
                            int n = dgvTicket.Rows.Add();
                            dgvTicket.Rows[n].Cells[0].Value = mercancia.Nombre;
                            dgvTicket.Rows[n].Cells[1].Value = lblCantidadProducto.Text;
                            dgvTicket.Rows[n].Cells[2].Value = mercancia.Precio;
                            dgvTicket.Rows[n].Cells[3].Value = (Convert.ToInt32(lblCantidadProducto.Text) * mercancia.Precio);

                            TotalProducto();//llama al metodo Total Producto
                            Limpiar();//llama al metodo Limpiar
                        }
                    }
                }//fin de using
            }
        }//fin del metodo

//*********************************************************************************************************
        public void ModificarProducto()//metodo para Modificar Producto del Ticket
        {
            if (txtNombreProducto.Text.Length != 0 && lblCantidadProducto.Text != "0")//if para que se ejecute cuando el TextBox de Nombre y Cantidad no esten vacio
            {
                dgvTicket[1, posicion].Value = lblCantidadProducto.Text;
                dgvTicket[3, posicion].Value = (Convert.ToInt32(lblCantidadProducto.Text) * Convert.ToDouble(dgvTicket.Rows[posicion].Cells[2].Value));
                TotalProducto();//llama al metodo Total Producto
                Limpiar();//llama al metodo Limpiar
            }
        }//fin del metodo

//*********************************************************************************************************
        public void EliminarProducto()//metodo para Eliminar Producto del Ticket
        {
            if (txtNombreProducto.Text.Length != 0 && lblCantidadProducto.Text != "0")//if para que se ejecute cuando el TextBox de Nombre y Cantidad no esten vacio
            {
                dgvTicket.Rows.RemoveAt(posicion);
                TotalProducto();//llama al metodo Total Producto
                Limpiar();//llama al metodo Limpiar
            }
        }//fin del metodo
//*********************************************************************************************************
        public void TotalProducto()//metodo para Hacer la suma de todos los Productos agregados al Ticket
        {
            lblTotal.Text = "0";//sirve para hacer desde 0 la suma de los Productos
            for (int i = 0; i < dgvTicket.RowCount; i++)//for para sumar los Productos del Ticket
            {
                lblTotal.Text = "" + (Convert.ToDouble(lblTotal.Text) + (Convert.ToInt32(dgvTicket.Rows[i].Cells[1].Value) * Convert.ToDouble(dgvTicket.Rows[i].Cells[2].Value)));             
            }
        }//fin del metodo
        
//*********************************************************************************************************
        public void TerminarProceso()//metodo para agregar al Modelo Historial los datos de los Productos agregados al Ticket
        {
            using (var context = new ApplicationDbContext())
            {
                if (lblTotal.Text != "0")//if por si el total es 0, no agrege al Historia el Ticket y no modifique las Existencias 
                {
                    var agregar = new Historial();
                        int n = dgvTicket.Rows.Add();
                        for (int i = 0; i < n; i++)//for para ingresar todos los datos del Ticket a una sola Casilla
                        {
                            var mercancia = context.Mercancia.First(x => x.Nombre == dgvTicket.Rows[i].Cells[0].Value.ToString());//buscar con un ORM
                            mercancia.Cantidad = mercancia.Cantidad - Convert.ToInt32(dgvTicket.Rows[i].Cells[1].Value);

                            if (mercancia.Cantidad == 0)//if por si la Existencia del Producto llega a 0 este se cambie su estado a Inactivo  
                            {
                                mercancia.Estado = "INACTIVO";
                            }
                            agregar.ProductoCantidadPrecio = "" + agregar.ProductoCantidadPrecio + ("[" + dgvTicket.Rows[i].Cells[0].Value + "][" + dgvTicket.Rows[i].Cells[1].Value + "][$" + dgvTicket.Rows[i].Cells[2].Value + "];");
                        }//fin del for

                    agregar.Fecha = DateTime.Now;

                    agregar.Total = Convert.ToInt32(lblTotal.Text);

                    context.Historial.Add(agregar);

                    context.SaveChanges(); 
                }
            }//fin del using

            Limpiar();//llama al Metodo Limpiar
            lblTotal.Text = "0";
            dgvTicket.Rows.Clear();
        }//fin del metodo

//*********************************************************************************************************
        public void Limpiar()//metodo para limpiar 
        {
            txtNombreProducto.Text = "";
            lblCantidadProducto.Text = "0";
            lblResultado.Text = "";
        }//fin del metodo

//*********************************************************************************************************
        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)//metodo para agregar un producto al Ticket
        {
            posicion = dgvTicket.CurrentRow.Index; 
            txtNombreProducto.Text = dgvTicket.CurrentRow.Cells[0].Value.ToString().ToUpper();
            lblCantidadProducto.Text = dgvTicket.CurrentRow.Cells[1].Value.ToString();
        }//fin del metodo


//*********************************************************************************************************
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)//metodo para seleccionar un producto
        {
            txtNombreProducto.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString().ToUpper();
        }//fin del metodo

//----------------------------------------------------------------------------------------------------------------
//*********************************************************************************************************
//---------------------ESTOS METODOS SON LOS BOTONES PARA AGREGAR/QUITAR CANTIDAD AL PRODUCTO---------------------  
        private void btnAgregarCantidad1_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) + 1;
            lblCantidadProducto.Text = CantidadProducto.ToString();
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregarCantidad2_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) + 2;
            lblCantidadProducto.Text = CantidadProducto.ToString();
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregarCantidad5_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) + 5;
            lblCantidadProducto.Text = CantidadProducto.ToString();
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregarCantidad10_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) + 10;
            lblCantidadProducto.Text = CantidadProducto.ToString();
        }//fin del metodo

//*********************************************************************************************************
        private void btnAgregarCantidad50_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) + 50;
            lblCantidadProducto.Text = CantidadProducto.ToString();
        }
        
//*********************************************************************************************************
        private void btnEliminarCantidad1_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) - 1;
            CondicionCantidadMenorCero();//llama al metodo Condicion de Cantidad menor a 0
                 
        }//fin del metodo

//*********************************************************************************************************
        private void btnEliminarCantidad2_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) - 2;
            CondicionCantidadMenorCero();//llama al metodo Condicion de Cantidad menor a 0
        }//fin del metodo

//*********************************************************************************************************
        private void btnEliminarCantidad5_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) - 5;
            CondicionCantidadMenorCero();//llama al metodo Condicion de Cantidad menor a 0
        }//fin del metodo

//*********************************************************************************************************
        private void btnEliminarCantidad10_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) - 10;
            CondicionCantidadMenorCero();//llama al metodo Condicion de Cantidad menor a 0
        }//fin del metodo

//*********************************************************************************************************
        private void btnEliminarCantidad50_Click(object sender, EventArgs e)
        {
            CantidadProducto = Convert.ToInt32(lblCantidadProducto.Text) - 50;
            CondicionCantidadMenorCero();//llama al metodo Condicion de Cantidad menor a 0
        }//fin del metodo      

//*********************************************************************************************************
    public void CondicionCantidadMenorCero()//metodo para no recibir valores negativos en cantidad 
        {
            if (CantidadProducto < 0)//por si la cantidad es menor a 0
            {
                lblCantidadProducto.Text = "0";
            }
            else
            {
                lblCantidadProducto.Text = CantidadProducto.ToString();
            }
        }

//*********************************************************************************************************
    }
}
