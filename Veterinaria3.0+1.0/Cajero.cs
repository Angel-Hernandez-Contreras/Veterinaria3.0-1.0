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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnNuevaCita_Click(object sender, EventArgs e)//boton para ingresar a Nueva Cita
        {
            NuevaCita fmNuevaCita = new NuevaCita();
            fmNuevaCita.Show();//llamar al formulario Nueva Cita
            this.Close();//cerrar clase Cajero
        }

//*********************************************************************************************************
        private void btnAgendaCita_Click(object sender, EventArgs e)//boton para ingresar a Agenda Cita
        {
            AgendaCita fmAgendaCita = new AgendaCita();
            fmAgendaCita.Show();//llamar al formulario Agenda Cita
            this.Close();//cerrar clase Cajero
        }

//*********************************************************************************************************
        private void btnInformacionClientes_Click(object sender, EventArgs e)//boton para ingresar a Informacion Clientes
        {
            InformacionCliente fmInfCliente = new InformacionCliente();
            fmInfCliente.Show();//llamar al formulario Informacion Cliente
            this.Close();//cerrar clase Cajero
        }

//*********************************************************************************************************
        private void btnMercancia_Click(object sender, EventArgs e)//boton para ingresar a Mercancia
        {
            Mercancia fmMercancia = new Mercancia();
            fmMercancia.Show();//llamar al formulario Mercancia
            this.Close();//cerrar clase Cajero
        }

        private void Cajero_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblVendajes.Text) >= 1)
            {
                lblVendajes.Text = (int.Parse(lblVendajes.Text) - 1).ToString();
            }
        }

        private void btnMenosJeringas_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblJeringas.Text) >= 1)
            {
                lblJeringas.Text = (int.Parse(lblJeringas.Text) - 1).ToString();
            }
        }

        private void btnMenosShampoo_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblShampoo.Text) >= 1)
            {
                lblShampoo.Text = (int.Parse(lblShampoo.Text) - 1).ToString();
            }
        }

        private void btnMenosDesinfectante_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblDesinfectante.Text) >= 1)
            {
                lblDesinfectante.Text = (int.Parse(lblDesinfectante.Text) - 1).ToString();
            }
        }

        private void btnMenosComida_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblComida.Text) >= 1)
            {
                lblComida.Text = (int.Parse(lblComida.Text) - 1).ToString();
            }
        }

        private void btnMasJeringas_Click(object sender, EventArgs e)
        {
            lblJeringas.Text = (int.Parse(lblJeringas.Text) + 1).ToString();
        }

        private void btnMasVendajes_Click(object sender, EventArgs e)
        {
            lblVendajes.Text = (int.Parse(lblVendajes.Text) + 1).ToString();
        }

        private void btnMasShampoo_Click(object sender, EventArgs e)
        {
            lblShampoo.Text = (int.Parse(lblShampoo.Text) + 1).ToString();
        }

        private void btnMasDesinfectante_Click(object sender, EventArgs e)
        {
            lblDesinfectante.Text = (int.Parse(lblDesinfectante.Text) + 1).ToString();
        }

        private void btnMasComida_Click(object sender, EventArgs e)
        {
            lblComida.Text = (int.Parse(lblComida.Text) + 1).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Items agregados al Inventario", "Inventarios", MessageBoxButtons.OK);
            lblJeringas.Text = "0";
            lblVendajes.Text = "0";
            lblShampoo.Text = "0";
            lblDesinfectante.Text = "0";
            lblComida.Text = "0";
        }
    }
}
