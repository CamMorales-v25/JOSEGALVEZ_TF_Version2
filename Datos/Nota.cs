//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nota
    {
        public int idNota { get; set; }
        public double Nota1 { get; set; }
        public bool Eliminado { get; set; }
        public int UsuarioCreacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public int TipoEvaluacion_idTipoEvaluacion { get; set; }
        public int Clases_x_Alumnos_idClases_x_Alumnos { get; set; }
    
        public virtual Clases_x_Alumnos Clases_x_Alumnos { get; set; }
        public virtual TipoEvaluacion TipoEvaluacion { get; set; }
    }
}
