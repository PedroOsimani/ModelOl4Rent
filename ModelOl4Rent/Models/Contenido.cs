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
    
    public partial class Contenido
    {
        public Contenido()
        {
            this.Adjunto = new HashSet<Adjunto>();
        }
    
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public short CantMarcas { get; set; }
    
        public virtual Bien Bien { get; set; }
        public virtual ICollection<Adjunto> Adjunto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
