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
    
    public partial class tb_timecard
    {
        public int id_timecard { get; set; }
        public int id_emp { get; set; }
        public System.DateTime hr_fixedInput { get; set; }
        public System.DateTime hr_fixedOutput { get; set; }
        public System.DateTime hr_fixedIntInput { get; set; }
        public System.DateTime hr_fixedIntOutput { get; set; }
    
        public virtual tb_employees tb_employees { get; set; }
    }
}
