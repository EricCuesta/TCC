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
    
    public partial class tb_discounts
    {
        public int id_discounts { get; set; }
        public int id_emp { get; set; }
        public Nullable<decimal> vl_incomeTax { get; set; }
        public Nullable<decimal> vl_familySalary { get; set; }
        public Nullable<decimal> vl_foodPension { get; set; }
        public Nullable<decimal> vl_inss { get; set; }
        public Nullable<decimal> vl_fgts { get; set; }
    
        public virtual tb_employees tb_employees { get; set; }
    }
}
