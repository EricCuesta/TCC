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
    
    public partial class tb_product
    {
        public int id_product { get; set; }
        public string ds_placeStock { get; set; }
        public string nm_product { get; set; }
        public string ds_typeProduct { get; set; }
        public int vl_amount { get; set; }
        public decimal vl_value { get; set; }
        public string ds_note { get; set; }
    }
}
