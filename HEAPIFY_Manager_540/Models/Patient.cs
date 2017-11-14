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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.AddLabReports = new HashSet<AddLabReport>();
            this.Billings = new HashSet<Billing>();
            this.CreateOrderInternals = new HashSet<CreateOrderInternal>();
            this.Demographics = new HashSet<Demographic>();
            this.FamilyHistoryMedicals = new HashSet<FamilyHistoryMedical>();
            this.NotesMedicalStaffs = new HashSet<NotesMedicalStaff>();
            this.PatientAllergies = new HashSet<PatientAllergy>();
            this.PatientDrugs = new HashSet<PatientDrug>();
            this.PatientEmergencyContacts = new HashSet<PatientEmergencyContact>();
            this.PatientImmunizations = new HashSet<PatientImmunization>();
            this.PatientProblems = new HashSet<PatientProblem>();
            this.Vitals = new HashSet<Vital>();
            this.PatientInsurances = new HashSet<PatientInsurance>();
        }
    
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int AddressID { get; set; }
        public Nullable<int> PhoneNumberID { get; set; }
        public Nullable<int> MaritalStatusID { get; set; }
        public Nullable<int> InsuranceID { get; set; }
        public string PatientSSN { get; set; }
        public string Email { get; set; }
        public System.DateTime DateOfBirth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddLabReport> AddLabReports { get; set; }
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billing> Billings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreateOrderInternal> CreateOrderInternals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demographic> Demographics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FamilyHistoryMedical> FamilyHistoryMedicals { get; set; }
        public virtual Insurance Insurance { get; set; }
        public virtual MaritalStanding MaritalStanding { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotesMedicalStaff> NotesMedicalStaffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientAllergy> PatientAllergies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientDrug> PatientDrugs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientEmergencyContact> PatientEmergencyContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientImmunization> PatientImmunizations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientProblem> PatientProblems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vital> Vitals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientInsurance> PatientInsurances { get; set; }
        public virtual PhoneNumber PhoneNumber { get; set; }
    }
}