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
    public partial class FormNotaMantenimiento : Form
    {
        NClasexAlumno nClasexAlumno = new NClasexAlumno();
        NNota nNota = new NNota();
        NTipoEvaluacion nTipoEvaluacion = new NTipoEvaluacion();

        public FormNotaMantenimiento()
        {
            InitializeComponent();
            MostrarClases_x_AlumnosAsignados(nClasexAlumno.Listar());//Son los alumnos que ya pagaron sus clases
            MostrarNotas(nNota.ListarTodo());

        }

        private void MostrarNotas(List<Nota> notas)
        {
            dgNotas.DataSource = null;
            if (notas.Count == 0)
            {
                return;
            }
            else
            {
                dgNotas.DataSource = notas;
            }
        }

        private void MostrarClases_x_AlumnosAsignados(List<Clases_x_Alumnos> clases_X_Alumnos)
        {
            dgAlumnosConClasesPagadas.DataSource = null;
            if (clases_X_Alumnos.Count == 0)
            {
                return;
            }
            else
            {
                dgAlumnosConClasesPagadas.DataSource = clases_X_Alumnos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNotaPractica.Text == "" || tbNotaTeorica.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Objeto Nota
            Nota nota = new Nota()
            {
                //iD
                Nota1 = (int.Parse(tbNotaPractica.Text) + int.Parse(tbNotaTeorica.Text))/2 
            };
            nNota.Registrar(nota);
            MessageBox.Show("Nota registrada exitosamente");
            MostrarNotas(nNota.ListarTodo());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbNotaPractica.Text == "" || tbNotaTeorica.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            if (dgNotas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una nota para eliminar");
                return;
            }
            int notaId;
            if (!int.TryParse(dgNotas.SelectedRows[0].Cells["idNota"].Value.ToString(), out notaId))
            {
                MessageBox.Show("Nota seleccionada inválida.");
                return;
            }

            // Crear el objeto Nota con los datos actualizados
            Nota nota = new Nota()
            {
                idNota = notaId,
                Nota1 = (int.Parse(tbNotaPractica.Text) + int.Parse(tbNotaTeorica.Text)) / 2,
                //TipoEvaluacion = cmbTipoEvaluacion.Text,
               
            };

            string mensaje = nNota.Modificar(nota);
            MessageBox.Show(mensaje);

            MostrarNotas(nNota.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgNotas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una nota para eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta nota?", "Confirmación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int notaId = int.Parse(dgNotas.SelectedRows[0].Cells["idNota"].Value.ToString());

                // Crear el objeto Nota para marcar como eliminada
                Nota nota = new Nota()
                {
                    idNota = notaId,
                    Eliminado = true,  // Supongamos que el modelo tiene una propiedad "Eliminado"
                    UsuarioModificacionId = NUsuario.UsuarioLogueado.IdUsuario,
                    FechaModificacion = DateTime.Now
                };

                // Llamar al método de eliminación en la capa de negocio
                string mensaje = nNota.EliminadoLogico(nota);
                MessageBox.Show(mensaje);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validaciones
            List<Clases_x_Alumnos> clasesxAlumno = new List<Clases_x_Alumnos>
            if (cmbFiltrarPor.Text == "")
            {
                MessageBox.Show("Complete el campo");
                return;
            }
            else
            {
                if(cmbFiltrarPor.Text == "")
                {
                    MessageBox.Show("Complete el campo");
                    return;
                }
            }
            clasesxAlumno = nClasexAlumno.BuscarClasesPorDNIalumno(cmbFiltrarPor.Text);
            clasesxAlumno = nClasexAlumno.BuscarClasesPorDNIalumno(cmbFiltrarPor.Text);
            if (clasesxAlumno.Count > 0)
            {
                MostrarClases_x_AlumnosAsignados(clasesxAlumno);
            }
            else
            {
                MessageBox.Show("No se encontró ninguna alumno que coincida con el criterio de búsqueda.");
            }
        }


        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            List<Clase> clases = new List<Clase>();

            
        }
    }
}
