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
    
    public partial class tb_employees
    {
        public int id_emp { get; set; }
        public string nm_firstName { get; set; }
        public string nm_lastName { get; set; }
        public string ds_email { get; set; }
        public string pw_password { get; set; }
        public System.DateTime dt_hiring { get; set; }
        public System.DateTime dt_resignation { get; set; }
        public System.DateTime dt_birth { get; set; }
        public string ds_sex { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public string ds_cep { get; set; }
        public string ds_country { get; set; }
        public string ds_state { get; set; }
        public string ds_address { get; set; }
        public string ds_note { get; set; }
        public string nr_cellphone { get; set; }
        public string nr_tellphone { get; set; }
    }
}
