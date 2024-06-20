using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NNota
    {
        DNota dNota = new DNota();
        public String Registrar(Nota nota)
        {
            return dNota.Registrar(nota);
        }

        public String Modificar(Nota nota)
        {
            return dNota.Modificar(nota);
        }

        public String EliminadoLogico(Nota nota)
        {
            return dNota.EliminadoLogico(nota);
        }

        public List<Nota> ListarTodo()
        {
            return dNota.ListarTodo();
        }

        public List<Nota> ListarPorDNI(string dniAlumno)
        {
            return dNota.ListarPorDNI(dniAlumno);
        }
    }
}
