//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoaRoupa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Roupa
    {
        public int Id { get; set; }
        public string DescricaoRoupa { get; set; }
        public string TipoRoupa { get; set; }
    
        public virtual Doador Doador { get; set; }
    }
}
