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
    
    public partial class tb_supply
    {
        public int id_supply { get; set; }
        public int id_stock { get; set; }
        public string nm_supply { get; set; }
        public int vl_amount { get; set; }
        public decimal vl_value { get; set; }
        public string ds_note { get; set; }
    
        public virtual tb_stock tb_stock { get; set; }
    }
}
