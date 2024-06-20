using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTipoEvaluacion
    {
        public List<TipoEvaluacion> ObtenerTipoEvaluacion()
        {
            List<TipoEvaluacion> tipoEvaluaciones = new List<TipoEvaluacion>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    tipoEvaluaciones = context.TipoEvaluacion.ToList();
                }
                return tipoEvaluaciones;
            }
            catch (Exception ex)
            {
                return tipoEvaluaciones;
            }
        }
    }
}
