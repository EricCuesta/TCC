//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
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
        public decimal vl_incomeTax { get; set; }
        public Nullable<decimal> vl_alimony { get; set; }
        public decimal vl_inss { get; set; }
        public decimal vl_fgts { get; set; }
    
        public virtual tb_employees tb_employees { get; set; }
    }
}
