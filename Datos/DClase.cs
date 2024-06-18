using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Clase
    {
        public Usuario UsuarioCreacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
    }

    public class DClase
    {
        public Clase ClasePorId(int claseId)
        {
            Clase claseTemp = null;
            using (var context = new BDEFEntities())
            {
                claseTemp = context.Clase.FirstOrDefault(c => c.idCurso == claseId);
                if (claseTemp != null)
                {
                    claseTemp.UsuarioCreacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == claseTemp.UsuarioCreacionId);
                    claseTemp.UsuarioModificacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == claseTemp.UsuarioModificacionesId);
                }
            }
            return claseTemp;
        }

        public List<Clase> Listar()
        {
            List<Clase> clases = new List<Clase>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clases = context.Clase.Where(u => u.Eliminado == false).ToList();
                }
                return clases;
            }
            catch (Exception ex)
            {
                return clases;
            }
        }

        public String Registrar(Clase clase)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Clase.Add(clase);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Editar(Clase clase)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Clase claseTemp = context.Clase.Find(clase.idCurso);
                    claseTemp.TipoDeClase = clase.TipoDeClase;
                    claseTemp.AforoMaximo = clase.AforoMaximo;
                    claseTemp.Precio = clase.Precio;
                    claseTemp.TipoDeLicencia = clase.TipoDeLicencia;
                    claseTemp.IntervadoDeHoras = clase.IntervadoDeHoras;
                    claseTemp.NombreProfesor = clase.NombreProfesor;
                    claseTemp.Activo = clase.Activo;
                    claseTemp.UsuarioModificacionesId = clase.UsuarioModificacionesId;
                    claseTemp.FechaModificacion = clase.FechaModificacion;
                    claseTemp.Usuario_IdUsuario = clase.Usuario_IdUsuario;
                    context.SaveChanges();
                }
                return "Editado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String EliminarLogico(Clase clase)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Clase claseTemp = context.Clase.Find(clase.idCurso);
                    claseTemp.Eliminado = true;
                    claseTemp.UsuarioModificacionesId = clase.UsuarioModificacionesId;
                    claseTemp.FechaModificacion = clase.FechaModificacion;
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
                return context.Clase.Count(c => c.Eliminado == false);
            }
        }

        public List<Clase> BuscarClasesPorTipoLicencia(String tipoLicencia)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Clase.Where(c => c.TipoDeLicencia == tipoLicencia && c.Eliminado == false).ToList();
            }
        }

        public List<Clase> BuscarClasesPorNombreProfesor(String nombreProfesor)
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Clase.Where(c => c.NombreProfesor == nombreProfesor && c.Eliminado == false).ToList();
            }
        }

    }
}