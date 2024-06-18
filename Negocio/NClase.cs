using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NClase
    {
        DClase dClase = new DClase();

        public Clase ClasePorId(int claseId)
        {
            return dClase.ClasePorId(claseId);
        }

        public List<Clase> Listar()
        {
            return dClase.Listar();
        }

        public String Registrar(Clase clase)
        {
            return dClase.Registrar(clase);
        }

        public String Editar(Clase clase)
        {
            return dClase.Editar(clase);
        }

        public String EliminarLogico(Clase clase)
        {
            return dClase.EliminarLogico(clase);
        }

        public int TotalRegistros()
        {
            return dClase.TotalRegistros();
        }

        public List<Clase> BuscarClasesPorTipoLicencia(String tipoLicencia)
        {
            return dClase.BuscarClasesPorTipoLicencia(tipoLicencia);
        }

        public List<Clase> BuscarClasesPorNombreProfesor(String nombreProfesor)
        {
            return dClase.BuscarClasesPorNombreProfesor(nombreProfesor);
        }
    }
}