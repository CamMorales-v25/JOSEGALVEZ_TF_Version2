using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{

    public partial class FormClaseMantenimiento : Form
    {
        NClase nClase = new NClase();
        NUsuario nUsuario = new NUsuario();
        private int TotalClasesRegistradas = 0;

        public FormClaseMantenimiento()
        {
            InitializeComponent();
            MostrarClases(nClase.Listar());
            MostrarProfesores(nUsuario.Listar());

            cmbTipoClase.SelectedIndexChanged += cmbTipoClase_SelectedIndexChanged;
            cmbTipoDeLicencia.SelectedIndexChanged += cmbTipoDeLicencia_SelectedIndexChanged;
        }

        private void MostrarClases(List<Clase> clases)
        {
            dgClases.DataSource = null;
            if (clases.Count == 0)
            {
                return;
            }
            else
            {
                dgClases.DataSource = clases;
            }

            foreach (DataGridViewColumn column in dgClases.Columns)
            {
                if (column.Name == "Eliminado")
                {
                    column.Visible = false;
                }
            }

            TotalClasesRegistradas = nClase.TotalRegistros();
            lblNum_TotalDeRegistros.Text = TotalClasesRegistradas.ToString();
        }

        private void MostrarProfesores(List<Usuario> usuarios)
        {
            cmbNombreProfesor.DataSource = null;
            var profesores = usuarios.Where(u => u.RolUsuario_idRolUsuario == 2).ToList();

            if (usuarios.Count == 0)
            {
                return;
            }
            else
            {
                cmbNombreProfesor.DataSource = profesores;
                cmbNombreProfesor.ValueMember = "IdUsuario";
                cmbNombreProfesor.DisplayMember = "Nombres";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTipoClase.Text.Trim().Equals("") || cmbAforoDeClase.Text.Trim().Equals("") || cmbTipoDeLicencia.Text.Trim().Equals("") || cmbIntervaloDeHoras.Text.Trim().Equals("") || cmbNombreProfesor.Text.Trim().Equals("") || txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!double.TryParse(txtPrecio.Text.Trim(), out double precio))
            {
                MessageBox.Show("Precio debe contener solo números");
                return;
            }

            //int selectedProfessorId = (int)cmbNombreProfesor.SelectedValue;

            if (cmbNombreProfesor.SelectedValue is int selectedProfessorId)
            {
                Clase clase = new Clase()
                {
                    TipoDeClase = cmbTipoClase.Text.Trim(),
                    AforoMaximo = int.Parse(cmbAforoDeClase.Text.Trim()),
                    TipoDeLicencia = cmbTipoDeLicencia.Text.Trim(),
                    IntervadoDeHoras = cmbIntervaloDeHoras.Text.Trim(),
                    NombreProfesor = cmbNombreProfesor.Text.Trim(),
                    Precio = (double)precio,
                    Activo = chActivo.Checked,
                    Eliminado = false,
                    UsuarioCreacionId = NUsuario.UsuarioLogueado.IdUsuario,
                    FechaCreacion = DateTime.Now,
                    UsuarioModificacionesId = NUsuario.UsuarioLogueado.IdUsuario,
                    FechaModificacion = DateTime.Now,
                    Usuario_IdUsuario = selectedProfessorId
                };

                String mensaje = nClase.Registrar(clase);
                MessageBox.Show(mensaje);

                MostrarClases(nClase.Listar());
            }
            else
            {
                MessageBox.Show("Error al seleccionar el profesor.");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbTipoClase.Text.Trim().Equals("") || cmbAforoDeClase.Text.Trim().Equals("") || cmbTipoDeLicencia.Text.Trim().Equals("") || cmbIntervaloDeHoras.Text.Trim().Equals("") || cmbNombreProfesor.Text.Trim().Equals("") || txtPrecio.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (!double.TryParse(txtPrecio.Text.Trim(), out double precio))
            {
                MessageBox.Show("Precio debe contener solo números");
                return;
            }

            int cursoId = (int)dgClases.SelectedRows[0].Cells["idCurso"].Value;
            //int selectedProfessorId = (int)cmbNombreProfesor.SelectedValue;

            if (cmbNombreProfesor.SelectedValue is int selectedProfessorId)
            {
                Clase clase = new Clase()
                {
                    idCurso = cursoId,
                    TipoDeClase = cmbTipoClase.Text.Trim(),
                    AforoMaximo = int.Parse(cmbAforoDeClase.Text.Trim()),
                    TipoDeLicencia = cmbTipoDeLicencia.Text.Trim(),
                    IntervadoDeHoras = cmbIntervaloDeHoras.Text.Trim(),
                    NombreProfesor = cmbNombreProfesor.Text.Trim(),
                    Precio = (double)precio,
                    Activo = chActivo.Checked,
                    Eliminado = false,
                    UsuarioCreacionId = NUsuario.UsuarioLogueado.IdUsuario,
                    FechaCreacion = DateTime.Now,
                    UsuarioModificacionesId = NUsuario.UsuarioLogueado.IdUsuario,
                    FechaModificacion = DateTime.Now,
                    Usuario_IdUsuario = selectedProfessorId
                };

                String mensaje = nClase.Editar(clase);
                MessageBox.Show(mensaje);

                MostrarClases(nClase.Listar());
            }
            else
            {
                MessageBox.Show("Error al seleccionar el profesor.");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgClases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una clase", "José Galvez");
                return;
            }

            DialogResult resultado = MessageBox.Show("Seguro de eliminar la clase?", "José Galvez", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int cursoId = int.Parse(dgClases.SelectedRows[0].Cells[0].Value.ToString());
                Clase clase = new Clase();
                clase.idCurso = cursoId;
                clase.Eliminado = true;
                clase.UsuarioModificacionesId = NUsuario.UsuarioLogueado.IdUsuario;
                clase.FechaModificacion = DateTime.Now;

                String mensaje = nClase.EliminarLogico(clase);
                MessageBox.Show(mensaje);
            }

            MostrarClases(nClase.Listar());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTipoClase.Text = "";
            cmbAforoDeClase.Text = "";
            cmbTipoDeLicencia.Text = "";
            cmbIntervaloDeHoras.Text = "";
            cmbNombreProfesor.Text = "";
            txtPrecio.Text = "";
            chActivo.Checked = true;
        }

        private void cmbTipoClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoClase.SelectedItem.ToString().Equals("Clase Práctica"))
            {
                cmbAforoDeClase.Items.Clear();
                //cmbAforoDeClase.Items.Add("Máximo 1 Alumno");
                cmbAforoDeClase.Items.Add(1);
                cmbAforoDeClase.SelectedIndex = 0;
                cmbAforoDeClase.Enabled = false;
            }
            else if (cmbTipoClase.SelectedItem.ToString().Equals("Clase Teórica"))
            {
                cmbAforoDeClase.Items.Clear();
                //cmbAforoDeClase.Items.Add("Máximo 15 Alumnos");
                cmbAforoDeClase.Items.Add(15);
                cmbAforoDeClase.SelectedIndex = 0;
                cmbAforoDeClase.Enabled = false;
            }
        }

        private void cmbTipoDeLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIntervaloDeHoras.Items.Clear();

            if (cmbTipoDeLicencia.SelectedItem.ToString() == "Licencia A-I")
            {
                cmbIntervaloDeHoras.Items.Add("08:00 AM - 10:00 AM");
                cmbIntervaloDeHoras.Items.Add("09:00 AM - 11:00 AM");
                cmbIntervaloDeHoras.Items.Add("10:00 AM - 12:00 PM");
            }
            else if (cmbTipoDeLicencia.SelectedItem.ToString() == "Licencia A-IIa")
            {
                cmbIntervaloDeHoras.Items.Add("11:00 AM - 13:00 PM");
                cmbIntervaloDeHoras.Items.Add("12:00 PM - 14:00 PM");
                cmbIntervaloDeHoras.Items.Add("14:00 PM - 16:00 PM");
            }
            else if (cmbTipoDeLicencia.SelectedItem.ToString() == "Licencia A-IIb")
            {
                cmbIntervaloDeHoras.Items.Add("15:00 PM - 17:00 PM");
                cmbIntervaloDeHoras.Items.Add("16:00 PM - 18:00 PM");
                cmbIntervaloDeHoras.Items.Add("17:00 PM - 19:00 PM");
            }
            else if (cmbTipoDeLicencia.SelectedItem.ToString() == "Licencia A-IIIa")
            {
                cmbIntervaloDeHoras.Items.Add("08:00 AM - 10:00 AM");
                cmbIntervaloDeHoras.Items.Add("09:00 AM - 11:00 AM");
                cmbIntervaloDeHoras.Items.Add("10:00 AM - 12:00 PM");
            }
            else if (cmbTipoDeLicencia.SelectedItem.ToString() == "Licencia A-IIIb")
            {
                cmbIntervaloDeHoras.Items.Add("11:00 AM - 13:00 PM");
                cmbIntervaloDeHoras.Items.Add("12:00 PM - 14:00 PM");
                cmbIntervaloDeHoras.Items.Add("14:00 PM - 16:00 PM");
            }
            else if (cmbTipoDeLicencia.SelectedItem.ToString() == "Licencia A-IIIc")
            {
                cmbIntervaloDeHoras.Items.Add("15:00 PM - 17:00 PM");
                cmbIntervaloDeHoras.Items.Add("16:00 PM - 18:00 PM");
                cmbIntervaloDeHoras.Items.Add("17:00 PM - 19:00 PM");
            }

            cmbIntervaloDeHoras.SelectedIndex = 0;
        }

        private void MostrarClaseEnIngresoDeDatos(int claseId)
        {
            Clase clase = nClase.ClasePorId(claseId);
            if (clase != null)
            {
                cmbTipoClase.Text = clase.TipoDeClase;
                cmbAforoDeClase.Text = clase.AforoMaximo.ToString();
                txtPrecio.Text = clase.Precio.ToString();
                cmbTipoDeLicencia.Text = clase.TipoDeLicencia;
                cmbIntervaloDeHoras.Text = clase.IntervadoDeHoras;
                cmbNombreProfesor.Text = clase.NombreProfesor;
                chActivo.Checked = clase.Activo;

                ssCreadoPor.Text = (clase.UsuarioCreacion != null) ? clase.UsuarioCreacion.Codigo : "";
                ssModificadoPor.Text = (clase.UsuarioModificacion != null) ? clase.UsuarioModificacion.Codigo : "";
                ssCreadoEl.Text = clase.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss");
                ssModificadoEl.Text = clase.FechaModificacion.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void dgClases_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgClases.CurrentCell;
            if (cell != null)
            {
                int fila = cell.RowIndex;
                int id = (int)dgClases.Rows[fila].Cells["idCurso"].Value;
                MostrarClaseEnIngresoDeDatos(id);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Clase> clasesFiltrados = new List<Clase>();

            if (cmbFiltrarPor.Text.Trim() == "Tipo de Licencia")
            {
                if (txtBuscando.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Complete el campo");
                    return;
                }
                clasesFiltrados = nClase.BuscarClasesPorTipoLicencia(txtBuscando.Text.Trim());
            }
            else if (cmbFiltrarPor.Text.Trim() == "Nombre de Profesor")
            {
                clasesFiltrados = nClase.BuscarClasesPorNombreProfesor(txtBuscando.Text.Trim());
            }

            if (clasesFiltrados.Count > 0)
            {
                MostrarClases(clasesFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontró ninguna clase que coincida con el criterio de búsqueda.");
            }
        }
    }
}