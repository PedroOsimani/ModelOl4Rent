//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelOl4Rent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Novedad
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public System.DateTime FechaHora { get; set; }
    
        public virtual SitioOrigenDatos SitioOrigenDatos { get; set; }
    }
}
