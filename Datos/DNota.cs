using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Nota
    {
        public Usuario UsuarioCreacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
    }
    public class DNota
    {
        public Nota NotaPorId(int notaId)
        {
            Nota notaTemp = null;
            using (var context = new BDEFEntities())
            {
                notaTemp = context.Nota.FirstOrDefault(c => c.idNota == notaId);
                if (notaTemp != null)
                {
                    notaTemp.UsuarioCreacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == notaTemp.UsuarioCreacionId);
                    //notaTemp.UsuarioModificacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == notaTemp.UsuarioModificacionesId);
                }
            }
            return notaTemp;
        }
        public String Registrar(Nota nota)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Nota.Add(nota);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Nota nota)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Nota notaTemp = context.Nota.Find(nota.idNota);
                    notaTemp.Nota1 = nota.Nota1;
                    notaTemp.UsuarioCreacionId = nota.UsuarioCreacionId;
                    notaTemp.FechaCreacion = nota.FechaCreacion;
                    notaTemp.UsuarioModificacionId = nota.UsuarioModificacionId;
                    notaTemp.FechaModificacion = nota.FechaModificacion;
                    notaTemp.Clases_x_Alumnos_idClases_x_Alumnos = nota.Clases_x_Alumnos_idClases_x_Alumnos;
                    notaTemp.TipoEvaluacion_idTipoEvaluacion = nota.TipoEvaluacion_idTipoEvaluacion;
                    context.SaveChanges();
                }
                return "Editado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String EliminadoLogico(Nota nota)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Nota notaTemp = context.Nota.Find(nota.idNota);
                    notaTemp.Eliminado = true;
                    notaTemp.UsuarioModificacionId = nota.UsuarioModificacionId;
                    notaTemp.FechaModificacion = nota.FechaModificacion;
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Nota> ListarTodo()
        {
            List<Nota> notas = new List<Nota>();
            try
            {
                
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    notas = context.Nota.ToList();
                }
                return notas;
            }
            catch (Exception ex)
            {
                return notas;
            }
        }

        public List<Nota> ListarPorDNI(string dniAlumno)
        {
            List<Nota> notas = new List<Nota>();
            try
            {
                
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    context.Nota.Where(ca => ca.Clases_x_Alumnos.Alumno.DNI == dniAlumno && ca.Eliminado == false).ToList();
                }
                return notas;
            }
            catch (Exception ex)
            {
                return notas;
            }
        }



    }
}
