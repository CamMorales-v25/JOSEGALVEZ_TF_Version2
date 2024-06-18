using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Clases_x_Alumnos
    {
        public Usuario UsuarioCreacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
    }

    public class DClasexAlumno
    {
        public Clases_x_Alumnos Clase_x_AlumnosPorId(int clases_x_AlumnosId)
        {
            Clases_x_Alumnos clases_x_AlumnosTemp = null;
            using (var context = new BDEFEntities())
            {
                clases_x_AlumnosTemp = context.Clases_x_Alumnos.FirstOrDefault(c => c.idClases_x_Alumnos == clases_x_AlumnosId);
                if (clases_x_AlumnosTemp != null)
                {
                    clases_x_AlumnosTemp.UsuarioCreacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == clases_x_AlumnosTemp.UsuarioCreacionId);
                    clases_x_AlumnosTemp.UsuarioModificacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == clases_x_AlumnosTemp.UsuarioModificacionId);
                }
            }
            return clases_x_AlumnosTemp;
        }

        public List<Clases_x_Alumnos> Listar()
        {
            List<Clases_x_Alumnos> clases_X_Alumnos = new List<Clases_x_Alumnos>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clases_X_Alumnos = context.Clases_x_Alumnos.Where(u => u.Eliminado == false).ToList();
                }
                return clases_X_Alumnos;
            }
            catch (Exception ex)
            {
                return clases_X_Alumnos;
            }
        }

        public String Registrar(Clases_x_Alumnos clases_X_Alumnos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Verificacion del aforo
                    var clase = context.Clase.Find(clases_X_Alumnos.Clase_idCurso);
                    if (clase != null)
                    {
                        int aforoMaximo = clase.AforoMaximo;
                        int alumnosInscritos = context.Clases_x_Alumnos.Count(ca => ca.Clase_idCurso == clase.idCurso && ca.Eliminado == false);

                        if (alumnosInscritos >= aforoMaximo)
                        {
                            return "Aforo lleno, no se puede asignar más alumnos a esta clase.";
                        }
                    }
                    else
                    {
                        return "Clase no encontrada.";
                    }

                    context.Clases_x_Alumnos.Add(clases_X_Alumnos);
                    context.SaveChanges();
                }
                return "Clase asignada a Alumno correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Editar(Clases_x_Alumnos clases_X_Alumnos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Clases_x_Alumnos clases_X_AlumnosTemp = context.Clases_x_Alumnos.Find(clases_X_Alumnos.idClases_x_Alumnos);
                    clases_X_AlumnosTemp.EstadoDePago = clases_X_Alumnos.EstadoDePago;
                    clases_X_AlumnosTemp.Clase_idCurso = clases_X_Alumnos.Clase_idCurso;
                    clases_X_AlumnosTemp.Alumno_idAlumno = clases_X_Alumnos.Alumno_idAlumno;
                    clases_X_AlumnosTemp.UsuarioCreacionId = clases_X_Alumnos.UsuarioCreacionId;
                    clases_X_AlumnosTemp.FechaCreacion = clases_X_Alumnos.FechaCreacion;
                    clases_X_AlumnosTemp.UsuarioModificacionId = clases_X_Alumnos.UsuarioModificacionId;
                    clases_X_AlumnosTemp.FechaModificacion = clases_X_Alumnos.FechaModificacion;
                    context.SaveChanges();
                }
                return "Editado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String EliminarLogico(Clases_x_Alumnos clases_X_Alumnos)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Clases_x_Alumnos clases_X_AlumnosTemp = context.Clases_x_Alumnos.Find(clases_X_Alumnos.idClases_x_Alumnos);
                    clases_X_AlumnosTemp.Eliminado = true;
                    clases_X_AlumnosTemp.UsuarioModificacionId = clases_X_Alumnos.UsuarioModificacionId;
                    clases_X_AlumnosTemp.FechaModificacion = clases_X_Alumnos.FechaModificacion;
                    context.SaveChanges();
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public int TotalRegistros()
        {
            using (var context = new BDEFEntities())
            {
                return context.Clases_x_Alumnos.Count(u => u.Eliminado == false);
            }
        }

        public int ContarAlumnosEnClase(int claseId)
        {
            using (var context = new BDEFEntities())
            {
                return context.Clases_x_Alumnos.Count(ca => ca.Clase_idCurso == claseId && ca.Eliminado == false);
            }
        }

        public List<Clases_x_Alumnos> BuscarClasesPorEstadoPago(String estadoPago)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Clases_x_Alumnos.Where(ca => ca.EstadoDePago == estadoPago && ca.Eliminado == false).ToList();
            }
        }

        public List<Clases_x_Alumnos> BuscarClasesPorDNIalumno(string dniAlumno)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Clases_x_Alumnos.Where(ca => ca.Alumno.DNI == dniAlumno && ca.Eliminado == false).ToList();
            }
        }
    }
}