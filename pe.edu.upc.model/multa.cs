//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pe.edu.upc.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class multa
    {
        public int id { get; set; }
        public int diasmora { get; set; }
        public long montopagar { get; set; }
        public int movimiento_id { get; set; }
    
        public virtual movimiento movimiento { get; set; }
    }
}
