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
    
    public partial class Insurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Insurance()
        {
            this.Billings = new HashSet<Billing>();
            this.Patients = new HashSet<Patient>();
            this.PatientInsurances = new HashSet<PatientInsurance>();
        }
    
        public int InsuranceID { get; set; }
        public string InsuranceName { get; set; }
        public string InsurancePlan { get; set; }
        public Nullable<double> CoPay { get; set; }
        public Nullable<double> Deductibles { get; set; }
        public string PrimarySubscriber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientInsurance> PatientInsurances { get; set; }
    }
}
