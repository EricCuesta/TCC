//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Liriou_s_Burguer.Database.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cpp
    {
        public int id_cpp { get; set; }
        public int id_enterprise { get; set; }
        public decimal vl_cpp { get; set; }
        public decimal vl_fgts { get; set; }
    
        public virtual tb_enterprise tb_enterprise { get; set; }
    }
}
