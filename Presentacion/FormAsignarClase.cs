using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAsignarClase : Form
    {
        NClasexAlumno nClasexAlumno = new NClasexAlumno();
        NClase nClase = new NClase();
        NAlumno nAlumno = new NAlumno();
        private int TotalDeClasesRegistrados = 0;
        private int TotalDeAlumnosAsignadosClasesRegistrados = 0;

        public FormAsignarClase()
        {
            InitializeComponent();
            MostrarClasesRegistradas(nClase.Listar());
            MostrarClases_x_AlumnosAsignados(nClasexAlumno.Listar());
            MostrarClasesFiltradas(nClase.Listar());
        }

        private void MostrarClasesRegistradas(List<Clase> clases)
        {
            dgClasesHabiles.DataSource = null;
            if (clases.Count == 0)
            {
                return;
            }
            else
            {
                dgClasesHabiles.DataSource = clases;
            }

            TotalDeClasesRegistrados = nClase.TotalRegistros();
            lblNum_TotalDeRegistros.Text = TotalDeClasesRegistrados.ToString();
        }

        private void MostrarClasesFiltradas(List<Clase> clasesFiltradas)
        {
            dgClasesHabiles.DataSource = null;
            if (clasesFiltradas.Count == 0)
            {
                return;
            }
            else
            {
                dgClasesHabiles.DataSource = clasesFiltradas;
            }

            TotalDeClasesRegistrados = clasesFiltradas.Count;
            lblNum_TotalDeRegistros.Text = TotalDeClasesRegistrados.ToString();
        }

        private void MostrarClases_x_AlumnosAsignados(List<Clases_x_Alumnos> clases_X_Alumnos)
        {
            dgClasesReservadas.DataSource = null;
            if (clases_X_Alumnos.Count == 0)
            {
                return;
            }
            else
            {
                dgClasesReservadas.DataSource = clases_X_Alumnos;
            }

            TotalDeAlumnosAsignadosClasesRegistrados = nClasexAlumno.TotalRegistros();
            lblNum_TotalDeRegistrosAlumnosClasesAsignados.Text = TotalDeAlumnosAsignadosClasesRegistrados.ToString();
        }

        private void MostrarClaseEnIngresoDeDatosClasesHabiles(int claseId)
        {
            Clase clase = nClase.ClasePorId(claseId);
            if (clase != null)
            {
                int aforoMaximo = clase.AforoMaximo;
                int alumnosInscritos = nClasexAlumno.ContarAlumnosEnClase(clase.idCurso);
                int aforoDisponible = aforoMaximo - alumnosInscritos;

                lblAforoDisponible.Text = $"{aforoDisponible}";
            }
        }

        private void dgClasesHabiles_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgClasesHabiles.CurrentCell;
            if (cell != null)
            {
                int fila = cell.RowIndex;
                int id = (int)dgClasesHabiles.Rows[fila].Cells["idCurso"].Value;
                MostrarClaseEnIngresoDeDatosClasesHabiles(id);

                txtCodigoClase.Text = id.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbEstadoDePago.Text.Trim().Equals("") || txtDNIAlumno.Text.Trim().Equals("") || txtCodigoClase.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!long.TryParse(txtDNIAlumno.Text.Trim(), out _))
            {
                MessageBox.Show("DNI debe contener solo números");
                return;
            }

            if (txtDNIAlumno.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.");
                return;
            }

            String dniAlumno = txtDNIAlumno.Text.Trim();

            if (!nAlumno.ExisteAlumnoPorDNI(dniAlumno))
            {
                MessageBox.Show("El DNI ingresado no está registrado.");
                return;
            }

            Alumno alumno = nAlumno.ObtenerAlumnoPorDNI(dniAlumno);
            if (alumno == null)
            {
                MessageBox.Show("No se pudo encontrar el alumno con el DNI proporcionado.");
                return;
            }

            int claseId;
            if (!int.TryParse(txtCodigoClase.Text, out claseId))
            {
                MessageBox.Show("Código de clase inválido.");
                return;
            }

            Clases_x_Alumnos clases_X_Alumnos = new Clases_x_Alumnos()
            {
                EstadoDePago = cmbEstadoDePago.Text.Trim(),
                Clase_idCurso = claseId,
                Alumno_idAlumno = alumno.idAlumno,
                Eliminado = false,
                UsuarioCreacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaCreacion = DateTime.Now,
                UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaModificacion = DateTime.Now,
            };

            String mensaje = nClasexAlumno.Registrar(clases_X_Alumnos);
            MessageBox.Show(mensaje);

            //MostrarClases_x_AlumnosAsignados(nClasexAlumno.Listar());
            if (mensaje == "Clase asignada a Alumno correctamente")
            {
                MostrarClases_x_AlumnosAsignados(nClasexAlumno.Listar());
            }
        }

        private void MostrarClase_x_AlumnoEnIngresoDeDatos(int clases_x_AlumnosId)
        {
            Clases_x_Alumnos clases_X_Alumnos = nClasexAlumno.Clase_x_AlumnosPorId(clases_x_AlumnosId);

            Alumno alumno = nAlumno.AlumnoPorID(clases_X_Alumnos.Alumno_idAlumno);

            if (clases_X_Alumnos != null)
            {
                cmbEstadoDePago.Text = clases_X_Alumnos.EstadoDePago.ToString();
                txtDNIAlumno.Text = alumno.DNI;
                txtCodigoClase.Text = clases_X_Alumnos.Clase_idCurso.ToString();

                ssCreadoPor.Text = (clases_X_Alumnos.UsuarioCreacion != null) ? clases_X_Alumnos.UsuarioCreacion.Codigo : "";
                ssModificadoPor.Text = (clases_X_Alumnos.UsuarioModificacion != null) ? clases_X_Alumnos.UsuarioModificacion.Codigo : "";
                ssCreadoEl.Text = clases_X_Alumnos.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
                ssModificadoEl.Text = clases_X_Alumnos.FechaModificacion.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbEstadoDePago.Text.Trim().Equals("") || txtDNIAlumno.Text.Trim().Equals("") || txtCodigoClase.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!long.TryParse(txtDNIAlumno.Text.Trim(), out _))
            {
                MessageBox.Show("DNI debe contener solo números");
                return;
            }

            if (txtDNIAlumno.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.");
                return;
            }

            String dniAlumno = txtDNIAlumno.Text.Trim();

            if (!nAlumno.ExisteAlumnoPorDNI(dniAlumno))
            {
                MessageBox.Show("El DNI ingresado no está registrado.");
                return;
            }

            Alumno alumno = nAlumno.ObtenerAlumnoPorDNI(dniAlumno);
            if (alumno == null)
            {
                MessageBox.Show("No se pudo encontrar el alumno con el DNI proporcionado.");
                return;
            }

            int claseId;
            if (!int.TryParse(txtCodigoClase.Text, out claseId))
            {
                MessageBox.Show("Código de clase inválido.");
                return;
            }

            int clase_x_AlumnosId = (int)dgClasesReservadas.SelectedRows[0].Cells["idClases_x_Alumnos"].Value;

            Clases_x_Alumnos clases_X_Alumnos = new Clases_x_Alumnos()
            {
                idClases_x_Alumnos = clase_x_AlumnosId,
                EstadoDePago = cmbEstadoDePago.Text.Trim(),
                Clase_idCurso = claseId,
                Alumno_idAlumno = alumno.idAlumno,
                Eliminado = false,
                UsuarioCreacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaCreacion = DateTime.Now,
                UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                FechaModificacion = DateTime.Now,
            };

            String mensaje = nClasexAlumno.Editar(clases_X_Alumnos);
            MessageBox.Show(mensaje);

            MostrarClases_x_AlumnosAsignados(nClasexAlumno.Listar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgClasesReservadas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una asignación", "José galvez");
                return;
            }

            DialogResult resultado = MessageBox.Show("Seguro de eliminar esta asignación?", "José galvez", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int clases_x_AlumnosId = int.Parse(dgClasesReservadas.SelectedRows[0].Cells[0].Value.ToString());

                Clases_x_Alumnos clases_X_Alumnos = new Clases_x_Alumnos();
                clases_X_Alumnos.idClases_x_Alumnos = clases_x_AlumnosId;
                clases_X_Alumnos.Eliminado = true;
                clases_X_Alumnos.UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario;
                clases_X_Alumnos.FechaModificacion = DateTime.Now;

                String mensaje = nClasexAlumno.EliminarLogico(clases_X_Alumnos);
                MessageBox.Show(mensaje);
            }

            MostrarClases_x_AlumnosAsignados(nClasexAlumno.Listar());
        }

        private void dgClasesReservadas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgClasesReservadas.CurrentCell;
            if (cell != null)
            {
                int fila = cell.RowIndex;
                int id = (int)dgClasesReservadas.Rows[fila].Cells["idClases_x_Alumnos"].Value;
                MostrarClase_x_AlumnoEnIngresoDeDatos(id);

                txtCodigoClase.Text = id.ToString();
            }
        }

        private void btnBuscarClasesReservadas_Click(object sender, EventArgs e)
        {
            List<Clases_x_Alumnos> clases_X_AlumnosFlitrados = new List<Clases_x_Alumnos>();

            if (cmbFiltrarPorClasesReservadas.Text.Trim() == "Estado de Pago")
            {
                if (txtBuscandoClasesReservadas.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Complete el campo");
                    return;
                }
                clases_X_AlumnosFlitrados = nClasexAlumno.BuscarClasesPorEstadoPago(txtBuscandoClasesReservadas.Text.Trim());
            }
            else if (cmbFiltrarPorClasesReservadas.Text.Trim() == "DNI Alumno")
            {
                clases_X_AlumnosFlitrados = nClasexAlumno.BuscarClasesPorDNIalumno(txtBuscandoClasesReservadas.Text.Trim());
            }

            if (clases_X_AlumnosFlitrados.Count > 0)
            {
                MostrarClases_x_AlumnosAsignados(clases_X_AlumnosFlitrados);
            }
            else
            {
                MessageBox.Show("No se encontró ninguna clase que coincida con el criterio de búsqueda.");
            }
        }

        private void btnBuscarClasesHabiles_Click(object sender, EventArgs e)
        {
            List<Clase> clases = new List<Clase>();

            if (cmbFiltrarPorClasesHabiles.Text.Trim() == "Tipo de Licencia")
            {
                if (txtBuscandoClasesHabiles.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Complete el campo");
                    return;
                }
                clases = nClase.BuscarClasesPorTipoLicencia(txtBuscandoClasesHabiles.Text.Trim());
            }
            else if (cmbFiltrarPorClasesHabiles.Text.Trim() == "Nombre de Profesor")
            {
                clases = nClase.BuscarClasesPorNombreProfesor(txtBuscandoClasesHabiles.Text.Trim());
            }

            if (clases.Count > 0)
            {
                MostrarClasesFiltradas(clases);
            }
            else
            {
                MessageBox.Show("No se encontró ninguna clase que coincida con el criterio de búsqueda.");
            }
        }
    }
}