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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

//*********************************************************************************************************
        private void btnIngresar_Click(object sender, EventArgs e)//bton para ingresar a Nueva Cita
        {
            /*using (var context = new ApplicationDbContext())
            {
                //string usuario = txtUsuario.Text.ToUpper();
                var cuenta = context.Cuenta.First(x => x.Usuario == txtUsuario.Text.ToUpper());
                if (cuenta != null)
                {
                    if (txtUsuario.Text.ToUpper() == cuenta.Usuario.ToString() && txtContraseña.Text == cuenta.Contraseña.ToString())
                    {
                        FrmMenu menu = new FrmMenu();
                        menu.Show();//llamar al formulario Menu
                        this.Hide();//esconder clase Inicio
                    }
                    else
                    {
                        lblResultado.Text = "LA CONTRASEÑA ES INCORRECTAS";
                        txtContraseña.Text = "";
                    }
                }
                else
                {
                    lblResultado.Text = "EL NOMBRE DE USUARIO ES INCORRECTO";
                    txtContraseña.Text = "";
                } 
            }*/
            FrmMenu menu = new FrmMenu();menu.Show();this.Hide();
        }
//*********************************************************************************************************
    }
}
