//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HEAPIFY_Manager_540.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drug()
        {
            this.PatientDrugs = new HashSet<PatientDrug>();
        }
    
        public int DrugID { get; set; }
        public string DrugName { get; set; }
        public string Dose { get; set; }
        public Nullable<int> HowLong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientDrug> PatientDrugs { get; set; }
    }
}
