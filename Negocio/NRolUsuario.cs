using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRolUsuario
    {
        private DRolUsuario dRolUsuario = new DRolUsuario();
        public List<RolUsuario> ObtenerRoles()
        {
            return dRolUsuario.ObtenerRoles();
        }
    }
}
