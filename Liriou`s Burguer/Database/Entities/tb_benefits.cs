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
    
    public partial class tb_benefits
    {
        public int id_benefits { get; set; }
        public int id_emp { get; set; }
        public bool bt_food { get; set; }
        public bool bt_transport { get; set; }
        public bool bt_meal { get; set; }
        public bool bt_lifeSafe { get; set; }
        public bool bt_planHealth { get; set; }
        public bool bt_planDental { get; set; }
        public Nullable<decimal> vl_transport { get; set; }
        public Nullable<decimal> vl_meal { get; set; }
        public Nullable<decimal> vl_food { get; set; }
        public Nullable<decimal> vl_lifeSafe { get; set; }
        public Nullable<decimal> vl_planHealth { get; set; }
        public Nullable<decimal> vl_planDental { get; set; }
    
        public virtual tb_employees tb_employees { get; set; }
    }
}
