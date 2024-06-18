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
    public partial class FormAlumnoMantenimiento : Form
    {
        NAlumno nAlumno = new NAlumno();
        private int TotalDeAlumnosRegistrados = 0;
        public FormAlumnoMantenimiento()
        {
            InitializeComponent();
            MostrarAlumnos(nAlumno.Listar());
            //dgAlumnos.CellClick += dgAlumnos_SelectionChanged;
        }
        private void MostrarAlumnos(List<Alumno> alumnos)
        {
            dgAlumnos.DataSource = null;
            if (alumnos.Count == 0)
            {
                return;
            }
            else
            {
                dgAlumnos.DataSource = alumnos;
            }

            foreach (DataGridViewColumn column in dgAlumnos.Columns)
            {
                if (column.Name == "Eliminado")
                {
                    column.Visible = false;
                }
            }

            TotalDeAlumnosRegistrados = nAlumno.TotalRegistros();
            lblNum_TotalDeRegistros.Text = TotalDeAlumnosRegistrados.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtNombreCompleto.Text.Trim().Equals("") || dtpFechaNacimiento.Text.Trim().Equals("") || txtCorreoElectronico.Text.Trim().Equals("") || txtTelefono.Text.Trim().Equals("") || txtDocumentoNacionalDNI.Text.Trim().Equals("") || txtDireccion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!long.TryParse(txtDocumentoNacionalDNI.Text.Trim(), out _) || !long.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("DNI y Teléfono deben contener solo números");
                return;
            }

            if (txtDocumentoNacionalDNI.Text.Length != 8 || txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos y el teléfono 9 dígitos.");
                return;
            }

            bool esMayorDeEdad = Datos.DAlumno.EsMayorDeEdad(dtpFechaNacimiento.Value);

            if (!esMayorDeEdad)
            {                
                MessageBox.Show("La persona no es mayor de edad.");
                return;
            }

            Alumno alumno = new Alumno()
            {
                NombreApellidos = txtNombreCompleto.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                DNI = txtDocumentoNacionalDNI.Text.Trim(),
                CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Direccion = txtDireccion.Text.Trim(),
                Activo = chActivo.Checked,
                Eliminado = false,
                UsuarioCreacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaCreacion = DateTime.Now,
                UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaModificacion = DateTime.Now                
            };

            String mensaje = nAlumno.Insertar(alumno);
            MessageBox.Show(mensaje);

            MostrarAlumnos(nAlumno.Listar());
        }
        private void MostrarAlumnoEnIngresoDeDatos(int alumnoId)
        {
            Alumno alumno = nAlumno.AlumnoPorID(alumnoId);
            if (alumno != null)
            {
                txtAlumnoId.Text = alumno.idAlumno.ToString();
                txtNombreCompleto.Text = alumno.NombreApellidos;
                txtCorreoElectronico.Text = alumno.CorreoElectronico;
                txtTelefono.Text = alumno.Telefono;
                txtDocumentoNacionalDNI.Text = alumno.DNI;
                txtDireccion.Text = alumno.Direccion;
                dtpFechaNacimiento.Text = alumno.FechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss");
                chActivo.Checked = alumno.Activo;

                ssCreadoPor.Text = (alumno.UsuarioCreacion != null) ? alumno.UsuarioCreacion.Codigo : "";
                ssModificadoPor.Text = (alumno.UsuarioModificacion != null) ? alumno.UsuarioModificacion.Codigo : "";
                ssCreadoEl.Text = alumno.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
                ssModificadoEl.Text = alumno.FechaModificacion.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAlumnoId.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtDocumentoNacionalDNI.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Text = "";
            chActivo.Checked = true;

            txtNombreCompleto.Focus();            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text.Trim().Equals("") || dtpFechaNacimiento.Text.Trim().Equals("") || txtCorreoElectronico.Text.Trim().Equals("") || txtTelefono.Text.Trim().Equals("") || txtDocumentoNacionalDNI.Text.Trim().Equals("") || txtDireccion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!long.TryParse(txtDocumentoNacionalDNI.Text.Trim(), out _) || !long.TryParse(txtTelefono.Text.Trim(), out _))
            {
                MessageBox.Show("DNI y Teléfono deben contener solo números");
                return;
            }

            if (txtDocumentoNacionalDNI.Text.Length != 8 || txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos y el teléfono 9 dígitos.");
                return;
            }

            bool esMayorDeEdad = Datos.DAlumno.EsMayorDeEdad(dtpFechaNacimiento.Value);

            if (!esMayorDeEdad)
            {
                MessageBox.Show("La persona no es mayor de edad.");
                return;
            }

            Alumno alumno = new Alumno()
            {
                idAlumno = int.Parse(txtAlumnoId.Text),
                NombreApellidos = txtNombreCompleto.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                DNI = txtDocumentoNacionalDNI.Text.Trim(),
                CorreoElectronico = txtCorreoElectronico.Text.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Direccion = txtDireccion.Text.Trim(),
                Activo = chActivo.Checked,
                Eliminado = false,
                UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaModificacion = DateTime.Now
            };

            String mensaje = nAlumno.Editar(alumno);
            MessageBox.Show(mensaje);

            MostrarAlumnos(nAlumno.Listar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtAlumnoId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione un usuario", "José galvez");
                return;
            }

            DialogResult resultado = MessageBox.Show("Seguro de eliminar el usuario?", "José galvez", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int alumnoId = int.Parse(txtAlumnoId.Text.Trim());
                Alumno alumno = nAlumno.AlumnoPorID(alumnoId);
                alumno.Eliminado = true;
                alumno.UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario;
                alumno.FechaModificacion = DateTime.Now;

                nAlumno.EliminarLogico(alumno);
            }
            MostrarAlumnos(nAlumno.Listar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnosFiltrados = new List<Alumno>();

            if (cmbFiltrarPor.Text.Trim() == "DNI")
            {
                if (txtBuscando.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Complete el campo");
                    return;
                }
                alumnosFiltrados = nAlumno.BuscarPorDni(txtBuscando.Text.Trim());
            }
            else if(cmbFiltrarPor.Text.Trim() == "Desactivados")
            {
                alumnosFiltrados = nAlumno.BuscarAlumnosDesactivados();
            }

            if (alumnosFiltrados.Count > 0)
            {
                MostrarAlumnos(alumnosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontró ningún usuario que coincida con el criterio de búsqueda.");
            }
        }

        private void dgAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgAlumnos.CurrentCell;
            if (cell != null)
            {
                int fila = cell.RowIndex;
                int id = (int)dgAlumnos.Rows[fila].Cells["IdAlumno"].Value;
                MostrarAlumnoEnIngresoDeDatos(id);
            }
        }
    }
}
