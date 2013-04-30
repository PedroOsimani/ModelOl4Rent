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
    
    public partial class Sitio
    {
        public Sitio()
        {
            this.ConfiguracionesOrigenDatos = new HashSet<SitioOrigenDatos>();
            this.HabilitacionesUsuarioSitio = new HashSet<HabilitacionUsuarioSitio>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte[] Logo { get; set; }
        public byte[] CSS { get; set; }
        public string MailAdmin { get; set; }
        public string URL { get; set; }
        public short CantBienesPopulares { get; set; }
        public short CantMarcasXCont { get; set; }
        public short CantContBloqXUsu { get; set; }
    
        public virtual TipoBien TipoBien { get; set; }
        public virtual ICollection<SitioOrigenDatos> ConfiguracionesOrigenDatos { get; set; }
        public virtual Usuario UsuarioPropietario { get; set; }
        public virtual ICollection<HabilitacionUsuarioSitio> HabilitacionesUsuarioSitio { get; set; }
    }
}
