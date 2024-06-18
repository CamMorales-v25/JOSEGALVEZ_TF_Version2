using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        DUsuario dUsuario = new DUsuario();
        public static Usuario UsuarioLogueado { get; set; }

        public List<Usuario> Listar()
        {
            return dUsuario.Listar();
        }

        public Usuario Login(string codigo, string password)
        {
            UsuarioLogueado = dUsuario.Login(codigo, password);
            return UsuarioLogueado;
        }
        public Usuario UsuarioPorId(int usuarioId)
        {
            return dUsuario.UsuarioPorId(usuarioId);
        }

        public String Editar(Usuario usuario)
        {
            if (!dUsuario.CodigoExiste(usuario.Codigo, usuario.IdUsuario))
            {
                return dUsuario.Editar(usuario);
            }
            return "El código ya existe";
        }

        public String Insertar(Usuario usuario)
        {
            if (!dUsuario.CodigoExiste(usuario.Codigo, usuario.IdUsuario))
            {
                return dUsuario.Registrar(usuario);
              
            }
            return "El código ya existe";
        }

        public string EliminarLogico(Usuario objUsuario)
        {
            return dUsuario.EliminarLogico(objUsuario);
        }

        public List<Usuario> BuscarPorRol(string rol)
        {
            return dUsuario.BuscarPorRol(rol);
        }

        public List<Usuario> BuscarPorDni(string dni)
        {
            return dUsuario.BuscarPorDni(dni);
        }

        public int TotalRegistros()
        {
            return dUsuario.TotalRegistros(); 
        }
    }
}
