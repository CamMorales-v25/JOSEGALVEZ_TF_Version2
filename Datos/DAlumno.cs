using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Alumno
    {
        public Usuario UsuarioCreacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
    }

    public class DAlumno
    {
        public Alumno AlumnoPorId(int alumnoid)
        {
            Alumno alumTempo = null;
            using (var context = new BDEFEntities())
            {

                alumTempo = context.Alumno.FirstOrDefault(u => u.idAlumno == alumnoid);
                if (alumTempo != null)
                {
                    alumTempo.UsuarioCreacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == alumTempo.UsuarioCreacionId);
                    alumTempo.UsuarioModificacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == alumTempo.UsuarioModificacionId);
                }
            }
            return alumTempo;
        }


        public bool CodigoExiste(string dni, int alumnoId)
        {
            using (var context = new BDEFEntities())
            {
                Alumno alumno = context.Alumno.FirstOrDefault(p => p.DNI == dni && p.idAlumno != alumnoId && p.Eliminado == false);
                if (alumno != null) { return true; }
            }
            return false;
        }

        public List<Alumno> Listar()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    alumnos = context.Alumno.Where(u => u.Eliminado == false).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }

        public String Registrar(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Alumno.Add(alumno);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Editar(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumTemp = context.Alumno.Find(alumno.idAlumno);
                    alumTemp.NombreApellidos = alumno.NombreApellidos;
                    alumTemp.DNI = alumno.DNI;
                    alumTemp.Telefono = alumno.Telefono;
                    alumTemp.CorreoElectronico = alumno.CorreoElectronico;
                    alumTemp.FechaNacimiento = alumno.FechaNacimiento;
                    alumTemp.Direccion = alumno.Direccion;
                    alumTemp.Activo = alumno.Activo;
                    alumTemp.UsuarioModificacionId = alumno.UsuarioModificacionId;
                    alumTemp.FechaModificacion = alumno.FechaModificacion;
                    context.SaveChanges();
                }
                return "Editado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumTemp = context.Alumno.Find(alumno.idAlumno);
                    alumTemp.Eliminado = true;
                    alumTemp.UsuarioModificacionId = alumno.UsuarioModificacionId;
                    alumTemp.FechaModificacion = alumno.FechaModificacion;
                    context.SaveChanges();
                    return "";
                }
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
                return context.Alumno.Count(u => u.Eliminado == false);
            }
        }

        public List<Alumno> BuscarPorDni(string dni)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Alumno.Where(u => u.DNI == dni && u.Eliminado == false).ToList();
            }
        }

        public List<Alumno> BuscarAlumnosDesactivados()
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Alumno.Where(u => u.Activo == false && u.Eliminado == false).ToList();
            }
        }

        public static bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > ahora.AddYears(-edad))
            {
                edad--; 
            }

            return edad >= 18;
        }

        //
        public Alumno ObtenerAlumnoPorDNI(string dni)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Alumno.SingleOrDefault(a => a.DNI == dni && a.Eliminado == false);
            }
        }
    }
}
