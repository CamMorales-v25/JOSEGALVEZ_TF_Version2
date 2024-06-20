using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTipoEvaluacion
    {
        DTipoEvaluacion dTipoEvaluacion = new DTipoEvaluacion();

        public List<TipoEvaluacion> ObtenerTipoEvaluacion()
        {
            return dTipoEvaluacion.ObtenerTipoEvaluacion();
        }
    }
}
