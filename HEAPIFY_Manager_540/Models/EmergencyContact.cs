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
    
    public partial class EmergencyContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmergencyContact()
        {
            this.Demographics = new HashSet<Demographic>();
            this.PatientEmergencyContacts = new HashSet<PatientEmergencyContact>();
        }
    
        public int EmergencyContactID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> PhoneNumberID { get; set; }
        public string Email { get; set; }
        public int RelationshipID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demographic> Demographics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientEmergencyContact> PatientEmergencyContacts { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
        public virtual Relationship Relationship { get; set; }
    }
}