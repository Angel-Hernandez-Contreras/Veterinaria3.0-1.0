using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria3._0_1._0
{
    public partial class Mercancia : Form
    {
        String[] productos=new string[] {"jeringas", "vendajes", "Shampoo","desinfectante", "Comida" };
        public Mercancia()
        {
            InitializeComponent();
            btnBuscarProducto.Enabled= false;
        }

//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Mercancia
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            AgendaCita fmAgnCita = new AgendaCita();
            fmAgnCita.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar clase Mercancia
        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Cliente
        {
            InformacionCliente fmInfoCliente = new InformacionCliente();
            fmInfoCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Mercancia
        }

//*********************************************************************************************************
        private void btnCajero_Click(object sender, EventArgs e)
        {
            Cajero fmCajero = new Cajero();
            fmCajero.Show();
            this.Close();
        }

//*********************************************************************************************************
        private void button1_Click(object sender, EventArgs e)//boton Buscar producto
        {
            Boolean bandera = false;
            for (int i = 0; i < productos.Length; i++)
            {
                if (int.Parse(txtCodigoProducto.Text) == (120 + i))
                {
                    lblNombreProducto.Text = productos[i];
                    lblTipoProducto.Text = "???";
                    lblPrecio.Text = (50 * (i+1)).ToString();//Asigna precio si pensarlo la neta jaja
                    bandera = false;
                    break;
                }
                else
                {
                    bandera = true;
                }
            }
            if (bandera)
            {
                MessageBox.Show("PRODUCTO NO ENCONTRADO", "Error", MessageBoxButtons.OK);
            }

        }

//*********************************************************************************************************
        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            //Cambio de color del texto
            //Entra al if solo si el campo de texto NO esta vacio y tiene mas de 2 caracteres dentro
            if(txtCodigoProducto.Text != "" && txtCodigoProducto.Text.Length>=3)
            {
                txtCodigoProducto.BackColor = Color.Gray;
                btnBuscarProducto.Enabled = true;
            }
            else
            {
                txtCodigoProducto.BackColor = Color.Red;
                btnBuscarProducto.Enabled = false;
            }
        }

    }
}
