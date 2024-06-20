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
    public class DNota
    {
        public String Registrar()
        {
            try
            {
                using (var context = new BDEFEntities())
                {

                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Nota> ListarTod(List<Nota> notas)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    notas = context.Nota.ToList();
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
