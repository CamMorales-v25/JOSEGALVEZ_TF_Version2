using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        NUsuario nUsuario = new NUsuario();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string password = txtPassword.Text.Trim();

            Usuario uTemp = nUsuario.Login(codigo, password);

            if (uTemp == null)
            {
                MessageBox.Show("Código o contraseña incorrecto");
            }
            else
            {
                this.Hide();
                FormMenu objPrincipal = new FormMenu();
                objPrincipal.MostrarMenuSegunUsuario();
                objPrincipal.ShowDialog();
                this.Close();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
