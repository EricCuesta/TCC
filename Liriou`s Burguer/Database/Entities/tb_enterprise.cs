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
    
    public partial class tb_enterprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_enterprise()
        {
            this.tb_cpp = new HashSet<tb_cpp>();
            this.tb_cnae = new HashSet<tb_cnae>();
        }
    
        public int id_enterprise { get; set; }
        public string nm_enterprise { get; set; }
        public string nm_commercialName { get; set; }
        public string ds_email { get; set; }
        public string ds_cnpj { get; set; }
        public string ds_cep { get; set; }
        public string ds_country { get; set; }
        public string ds_state { get; set; }
        public string ds_Address { get; set; }
        public string ds_note { get; set; }
        public string nr_cellphone { get; set; }
        public string nr_tellphone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cpp> tb_cpp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cnae> tb_cnae { get; set; }
    }
}
