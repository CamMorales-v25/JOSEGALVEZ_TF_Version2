using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NClasexAlumno
    {
        DClasexAlumno dClasexAlumno = new DClasexAlumno();

        public Clases_x_Alumnos Clase_x_AlumnosPorId(int clases_x_AlumnosId)
        {
            return dClasexAlumno.Clase_x_AlumnosPorId(clases_x_AlumnosId);
        }

        public List<Clases_x_Alumnos> Listar()
        {
            return dClasexAlumno.Listar();
        }

        public String Registrar(Clases_x_Alumnos clases_X_Alumnos)
        {
            return dClasexAlumno.Registrar(clases_X_Alumnos);
        }

        public String Editar(Clases_x_Alumnos clases_X_Alumnos)
        {
            return dClasexAlumno.Editar(clases_X_Alumnos);
        }

        public String EliminarLogico(Clases_x_Alumnos clases_X_Alumnos)
        {
            return dClasexAlumno.EliminarLogico(clases_X_Alumnos);
        }

        public int TotalRegistros()
        {
            return dClasexAlumno.TotalRegistros();
        }

        public int ContarAlumnosEnClase(int claseId)
        {
            return dClasexAlumno.ContarAlumnosEnClase(claseId);
        }

        public List<Clases_x_Alumnos> BuscarClasesPorEstadoPago(String estadoPago)
        {
            return dClasexAlumno.BuscarClasesPorEstadoPago(estadoPago);
        }

        public List<Clases_x_Alumnos> BuscarClasesPorDNIalumno(string dniAlumno)
        {
            return dClasexAlumno.BuscarClasesPorDNIalumno(dniAlumno);
        }
    }
}