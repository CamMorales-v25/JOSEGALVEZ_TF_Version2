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
    public partial class FormUsuarioMantenimiento : Form
    {
        NUsuario nUsuario = new NUsuario();
        private NRolUsuario nRolUsuario = new NRolUsuario();

        private int totalRegistros = 0;
        public FormUsuarioMantenimiento()
        {
            InitializeComponent();
            MostrarUsuarios(nUsuario.Listar());
            CargarRolesEnComboBox(nRolUsuario.ObtenerRoles());
        }

        private void CargarRolesEnComboBox(List<RolUsuario> rolUsuarios)
        {
            cmRolUsuario.DataSource = null;
            if (rolUsuarios.Count == 0)
            {
                return;
            }
            else
            {
                cmRolUsuario.DataSource = rolUsuarios;
                cmRolUsuario.ValueMember = "idRolUsuario";
                cmRolUsuario.DisplayMember = "NombreRol";
            }
        }

        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            dgUsuarios.DataSource = null;
            if (usuarios.Count == 0)
            {
                return;
            }
            else
            {
                dgUsuarios.DataSource = usuarios;
            }

            foreach (DataGridViewColumn column in dgUsuarios.Columns)
            {
                if (column.Name == "UsuarioCreacion" || column.Name == "UsuarioModificacion" || column.Name == "NombreRol" || column.Name == "Clase" || column.Name == "RolUsuario" || column.Name == "Eliminado")
                {
                    column.Visible = false;
                }
            }

            totalRegistros = nUsuario.TotalRegistros();
            lblNum_TotalDeRegistros.Text = totalRegistros.ToString();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim().Equals("") || txtApellidos.Text.Trim().Equals("") || txtCodigo.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals("") || txtTelefono.Text.Trim().Equals("") || txtDocumentoNacionalDNI.Text.Trim().Equals("") || txtCorreoElectronico.Text.Trim().Equals("") || cmRolUsuario.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (!long.TryParse(txtDocumentoNacionalDNI.Text.Trim(), out _) || !long.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("DNI y Teléfono deben contener solo números");
                return;
            }

            int rolUsuario = int.Parse(cmRolUsuario.SelectedValue.ToString());


            Usuario usuario = new Usuario()
            {
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Codigo = txtCodigo.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                DNI = txtDocumentoNacionalDNI.Text.Trim(),
                CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                RolUsuario_idRolUsuario = rolUsuario,
                Activo = chActivo.Checked,
                Eliminado = false,
                UsuarioCreacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaCreacion = DateTime.Now,
                UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaModificacion = DateTime.Now
            };


            String mensaje = nUsuario.Insertar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.Listar());
        }
        private void MostrarUsuarioEnIngresoDeDatos(int usuarioId)
        {
            Usuario usuario = nUsuario.UsuarioPorId(usuarioId);
            if (usuario != null)
            {
                txtUsuarioId.Text = usuario.IdUsuario.ToString();
                txtNombres.Text = usuario.Nombres;
                txtApellidos.Text = usuario.Apellidos;
                txtCodigo.Text = usuario.Codigo;
                txtPassword.Text = usuario.Password;
                txtCorreoElectronico.Text = usuario.CorreoElectronico;
                txtTelefono.Text = usuario.Telefono;
                txtDocumentoNacionalDNI.Text = usuario.DNI;
                chActivo.Checked = usuario.Activo;
                cmRolUsuario.SelectedValue = usuario.RolUsuario_idRolUsuario;

                ssCreadoPor.Text = (usuario.UsuarioCreacion != null) ? usuario.UsuarioCreacion.Codigo : "";
                ssModificadoPor.Text = (usuario.UsuarioModificacion != null) ? usuario.UsuarioModificacion.Codigo : "";
                ssCreadoEl.Text = usuario.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
                ssModificadoEl.Text = usuario.FechaModificacion.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtDocumentoNacionalDNI.Text.Trim(), out _) || !long.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("DNI y Teléfono deben contener solo números");
                return;
            }


            if (!long.TryParse(txtDocumentoNacionalDNI.Text.Trim(), out _) || !long.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("DNI y Teléfono deben contener solo números");
                return;
            }

            int rolUsuario = int.Parse(cmRolUsuario.SelectedValue.ToString());

            Usuario usuario = new Usuario()
            {
                IdUsuario = int.Parse(txtUsuarioId.Text),
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Codigo = txtCodigo.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                DNI = txtDocumentoNacionalDNI.Text.Trim(),
                CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                RolUsuario_idRolUsuario = rolUsuario,
                Activo = chActivo.Checked,
                Eliminado = false,
                UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaModificacion = DateTime.Now
            };

            String mensaje = nUsuario.Editar(usuario);
            MessageBox.Show(mensaje);

            MostrarUsuarios(nUsuario.Listar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un usuario", "José galvez");
                return;
            }

            DialogResult resultado = MessageBox.Show("Seguro de eliminar el usuario?", "José galvez", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int usuarioId = int.Parse(txtUsuarioId.Text.Trim());
                Usuario usuario = nUsuario.UsuarioPorId(usuarioId);
                usuario.Eliminado = true;
                usuario.UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario;
                usuario.FechaModificacion = DateTime.UtcNow;

                nUsuario.EliminarLogico(usuario);
            }

            MostrarUsuarios(nUsuario.Listar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscando.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete el campo");
                return;
            }

            List<Usuario> usuariosFiltrados = new List<Usuario>();

            if (cmbFiltrarPor.Text.Trim() == "DNI")
            {
                usuariosFiltrados = nUsuario.BuscarPorDni(txtBuscando.Text.Trim());
            }
            else if (cmbFiltrarPor.Text.Trim() == "Rol")
            {
                usuariosFiltrados = nUsuario.BuscarPorRol(txtBuscando.Text.Trim());
            }

            if (usuariosFiltrados.Count > 0)
            {
                MostrarUsuarios(usuariosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontró ningún usuario que coincida con el criterio de búsqueda.");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar campos de texto
            txtUsuarioId.Text = "";
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtPassword.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtDocumentoNacionalDNI.Text = "";

            chActivo.Checked = true;

            cmRolUsuario.SelectedIndex = -1;

            txtCodigo.Focus();
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgUsuarios.CurrentCell;
            if (cell != null)
            {
                int fila = cell.RowIndex;
                int id = (int)dgUsuarios.Rows[fila].Cells["IdUsuario"].Value;
                MostrarUsuarioEnIngresoDeDatos(id);
            }
        }
    }
}
