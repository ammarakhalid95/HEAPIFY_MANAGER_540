﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccountsAdmin> AccountsAdmins { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<ActiveSStanding> ActiveSStandings { get; set; }
        public virtual DbSet<AddLabReport> AddLabReports { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AlchoholStanding> AlchoholStandings { get; set; }
        public virtual DbSet<AllergiesName> AllergiesNames { get; set; }
        public virtual DbSet<AllergyType> AllergyTypes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<CreateOrderInternal> CreateOrderInternals { get; set; }
        public virtual DbSet<Demographic> Demographics { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugAbuse> DrugAbuses { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Ethnicity> Ethnicities { get; set; }
        public virtual DbSet<FamilyHistoryMedical> FamilyHistoryMedicals { get; set; }
        public virtual DbSet<Immunization> Immunizations { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<MaritalStanding> MaritalStandings { get; set; }
        public virtual DbSet<Modify> Modifies { get; set; }
        public virtual DbSet<NotesMedicalStaff> NotesMedicalStaffs { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientAllergy> PatientAllergies { get; set; }
        public virtual DbSet<PatientDrug> PatientDrugs { get; set; }
        public virtual DbSet<PatientEmergencyContact> PatientEmergencyContacts { get; set; }
        public virtual DbSet<PatientImmunization> PatientImmunizations { get; set; }
        public virtual DbSet<PatientInsurance> PatientInsurances { get; set; }
        public virtual DbSet<PatientProblem> PatientProblems { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<Problem> Problems { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<SmokingStanding> SmokingStandings { get; set; }
        public virtual DbSet<Vital> Vitals { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
    }
}
