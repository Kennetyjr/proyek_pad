//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyekpad
{
    using System;
    using System.Collections.Generic;
    
    public partial class alatmusik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alatmusik()
        {
            this.reviews = new HashSet<review>();
            this.variants = new HashSet<variant>();
        }
    
        public string al_id { get; set; }
        public string al_name { get; set; }
        public string al_description { get; set; }
        public decimal al_price { get; set; }
        public int al_stock { get; set; }
        public int al_status { get; set; }
        public string al_br_id { get; set; }
        public string al_in_id { get; set; }
    
        public virtual brand brand { get; set; }
        public virtual instrument instrument { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<review> reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<variant> variants { get; set; }
    }
}
