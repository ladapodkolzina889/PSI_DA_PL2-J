//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Morada
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string CodPostal { get; set; }
        public string Pais { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}
