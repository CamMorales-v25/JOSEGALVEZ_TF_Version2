using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        DAlumno dAlumno = new DAlumno();

        public List<Alumno> Listar()
        {
            return dAlumno.Listar();
        }

        public String Editar(Alumno alumno)
        {
            if (!dAlumno.CodigoExiste(alumno.DNI, alumno.idAlumno))
            {
                return dAlumno.Editar(alumno);
            }
            return "El DNI ya existe";
        }

        public String Insertar(Alumno alumno)
        {
            if (!dAlumno.CodigoExiste(alumno.DNI, alumno.idAlumno))
            {
               return dAlumno.Registrar(alumno);               

            }
            return "El código ya existe";
        }

        public Alumno AlumnoPorID(int alumnoiD)
        {
            return dAlumno.AlumnoPorId(alumnoiD);
        }

        public string EliminarLogico(Alumno alumno)
        {
            return dAlumno.EliminarLogico(alumno);
        }
        public int TotalRegistros()
        {
            return dAlumno.TotalRegistros();
        }
        public List<Alumno> BuscarPorDni(string dni)
        {
            return dAlumno.BuscarPorDni(dni);
        }

        public List<Alumno> BuscarAlumnosDesactivados()
        {
            return dAlumno.BuscarAlumnosDesactivados();
        }
        public static bool EsMayorDeEdad(DateTime fechaNacimiento)
        {
            return DAlumno.EsMayorDeEdad(fechaNacimiento);
        }

        //
        public bool ExisteAlumnoPorDNI(string dni)
        {
            List<Alumno> alumnos = dAlumno.BuscarPorDni(dni);
            return alumnos.Count > 0;
        }

        public Alumno ObtenerAlumnoPorDNI(string dni)
        {
            return dAlumno.ObtenerAlumnoPorDNI(dni);
        }
    }
}
