using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Usuario
    {
        public Usuario UsuarioCreacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        public string NombreRol { get; set; }
    }

    public class DUsuario
    {
        public Usuario Login(string codigo, string password)
        {
            Usuario userTemp = null;
            using (var context = new BDEFEntities())
            {
                var query = from b in context.Usuario
                            where b.Codigo == codigo
                                  && b.Password == password
                                  && b.Eliminado == false
                                  && b.Activo == true
                            select b;
                userTemp = query.FirstOrDefault();

                // Si se encontró un usuario, carga el tipo de rol
                if (userTemp != null)
                {
                    // Primero, obtenemos el RolUsuario asociado con el usuario
                    var rolUsuario = context.RolUsuario.FirstOrDefault(r => r.idRolUsuario == userTemp.RolUsuario_idRolUsuario);

                    // Luego, si existe un RolUsuario asociado, obtenemos el nombre del rol
                    if (rolUsuario != null)
                    {
                        userTemp.NombreRol = rolUsuario.NombreRol;
                    }
                }
            }
            return userTemp;
        }

        public Usuario UsuarioPorId(int usuarioId)
        {
            Usuario userTemp = null;
            using (var context = new BDEFEntities())
            {

                userTemp = context.Usuario.FirstOrDefault(u => u.IdUsuario == usuarioId);
                if (userTemp != null)
                {
                    userTemp.UsuarioCreacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.Usuario.FirstOrDefault(u => u.IdUsuario == userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.Where(u => u.Eliminado == false).ToList();
                }

                return usuarios;
            }
            catch (Exception ex)
            {
                return usuarios;
            }
        }

        public bool CodigoExiste(string codigo, int usuarioId)
        {
            using (var context = new BDEFEntities())
            {
                Usuario usuario = context.Usuario.FirstOrDefault(p => p.Codigo == codigo && p.IdUsuario != usuarioId && p.Eliminado == false);
                if (usuario != null) { return true; }
            }
            return false;
        }

        public String Registrar(Usuario usuario)
        {
           try
            {
                using (var context = new BDEFEntities())
                {
                    context.Usuario.Add(usuario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Editar(Usuario usuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Usuario userTemp = context.Usuario.Find(usuario.IdUsuario);
                    userTemp.Codigo = usuario.Codigo;
                    userTemp.Password = usuario.Password;
                    userTemp.Nombres = usuario.Nombres;
                    userTemp.Apellidos = usuario.Apellidos;
                    userTemp.CorreoElectronico = usuario.CorreoElectronico;
                    userTemp.Telefono = usuario.Telefono;
                    userTemp.DNI = usuario.DNI;
                    userTemp.Activo = usuario.Activo;
                    userTemp.UsuarioModificacionId = usuario.UsuarioModificacionId;
                    userTemp.FechaModificacion = usuario.FechaModificacion;
                    context.SaveChanges();
                }
                return "Editado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Usuario objUsuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Usuario userTemp = context.Usuario.Find(objUsuario.IdUsuario);
                    userTemp.Eliminado = true;
                    userTemp.UsuarioModificacionId = objUsuario.UsuarioModificacionId;
                    userTemp.FechaModificacion = objUsuario.FechaModificacion;
                    context.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                //Aqui se debería de guardar a BD o a archivo el error que salio para un posterior análisis
                return ex.Message;
            }
        }


        public List<Usuario> BuscarPorDni(string dni)
        {
            using (var context = new BDEFEntities())
            {
                return context.Usuario.Where(u => u.DNI == dni && u.Eliminado == false).ToList();
            }
        }

        public List<Usuario> BuscarPorRol(string rol)
        {
            using (var context = new BDEFEntities())
            {
                var rolId = context.RolUsuario.FirstOrDefault(r => r.NombreRol == rol)?.idRolUsuario;
                if (rolId.HasValue)
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Usuario.Where(u => u.RolUsuario_idRolUsuario == rolId.Value && u.Eliminado == false).ToList();
                }
                return new List<Usuario>();
            }
        }

        public int TotalRegistros()
        {
            using (var context = new BDEFEntities())
            {
                return context.Usuario.Count(u => u.Eliminado == false);
            }
        }

    }

}
