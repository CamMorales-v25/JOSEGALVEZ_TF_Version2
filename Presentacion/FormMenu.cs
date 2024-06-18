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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public void MostrarMenuSegunUsuario()
        {
            Usuario uTemp = NUsuario.UsuarioLogueado;
            if (uTemp.RolUsuario_idRolUsuario == 3)
            {
                usuariosToolStripMenuItem.Visible = false;
                mantenimientoClaseToolStripMenuItem.Visible = false;
            }

            if (uTemp.RolUsuario_idRolUsuario == 2)
            {
                usuariosToolStripMenuItem.Visible = false;
                clasesToolStripMenuItem.Visible = false;
                alumnosToolStripMenuItem.Visible = false;
            }

            // Muestra el código y el rol del usuario en los labels correspondientes
            lblNombreCodigo.Text = uTemp.Codigo;
            lblRol.Text = uTemp.NombreRol;
        }

        private void mantenimientoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarioMantenimiento formUsuarioMantenimiento = new FormUsuarioMantenimiento();
            formUsuarioMantenimiento.MdiParent = this; // Establecer el formulario principal como el padre MDI
            formUsuarioMantenimiento.Show();
        }

        private void mantenimientoClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClaseMantenimiento formClaseMantenimiento = new FormClaseMantenimiento();
            formClaseMantenimiento.MdiParent = this; 
            formClaseMantenimiento.Show();
        }

        private void asignarClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignarClase formAsignarClase = new FormAsignarClase();
            formAsignarClase.MdiParent = this; 
            formAsignarClase.Show();
        }

        private void mantenimientoNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaMantenimiento formNotaMantenimiento = new FormNotaMantenimiento();
            formNotaMantenimiento.MdiParent = this;
            formNotaMantenimiento.Show();
        }

        private void mantenimientoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlumnoMantenimiento formAlumnoMantenimiento = new FormAlumnoMantenimiento();
            formAlumnoMantenimiento.MdiParent = this;
            formAlumnoMantenimiento.Show();
        }
    }
}
