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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_employees()
        {
            this.tb_department = new HashSet<tb_department>();
            this.tb_discounts = new HashSet<tb_discounts>();
            this.tb_financial = new HashSet<tb_financial>();
            this.tb_function = new HashSet<tb_function>();
            this.tb_points = new HashSet<tb_points>();
            this.tb_timecard = new HashSet<tb_timecard>();
        }
    
        public int id_emp { get; set; }
        public string nm_firstName { get; set; }
        public string nm_lastName { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public int ds_dependents { get; set; }
        public string ds_sex { get; set; }
        public System.DateTime dt_birth { get; set; }
        public string ds_cep { get; set; }
        public string ds_state { get; set; }
        public string ds_address { get; set; }
        public string ds_note { get; set; }
        public string nr_cellphone { get; set; }
        public string nr_tellphone { get; set; }
        public string ds_email { get; set; }
        public string pw_password { get; set; }
        public System.DateTime dt_hiring { get; set; }
        public System.DateTime dt_resignation { get; set; }
        public Nullable<bool> bt_admin { get; set; }
        public Nullable<bool> bt_funcionaro { get; set; }
        public Nullable<bool> bt_rh { get; set; }
        public Nullable<bool> bt_financeiro { get; set; }
        public Nullable<bool> bt_estoque { get; set; }
        public Nullable<bool> bt_crm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_department> tb_department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_discounts> tb_discounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_financial> tb_financial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_function> tb_function { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_points> tb_points { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_timecard> tb_timecard { get; set; }
    }
}
