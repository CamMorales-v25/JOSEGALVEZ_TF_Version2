using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRolUsuario
    {
        public List<RolUsuario> ObtenerRoles()
        {
            List<RolUsuario> rolUsuarios = new List<RolUsuario>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    rolUsuarios = context.RolUsuario.ToList();
                }
                return rolUsuarios;
            }
            catch (Exception ex)
            {
                return rolUsuarios;
            }
        }
    }
}
