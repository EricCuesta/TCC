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
    
    public partial class tb_financial
    {
        public int id_salary { get; set; }
        public int id_emp { get; set; }
        public decimal vl_grossSalary { get; set; }
        public Nullable<decimal> vl_netSalary { get; set; }
        public string ds_typeSalary { get; set; }
        public string dt_fromDate { get; set; }
        public string dt_toDate { get; set; }
    
        public virtual tb_employees tb_employees { get; set; }
    }
}
