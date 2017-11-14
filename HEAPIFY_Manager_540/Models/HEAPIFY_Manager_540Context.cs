using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HEAPIFY_Manager_540.Models
{
    public class HEAPIFY_Manager_540Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public HEAPIFY_Manager_540Context() : base("name=HEAPIFY_Manager_540Context")
        {
        }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Problem> Problems { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.AccountType> AccountTypes { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.AccountsAdmin> AccountsAdmins { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Modify> Modifies { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.ActiveSStanding> ActiveSStandings { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.AddLabReport> AddLabReports { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Patient> Patients { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.AlchoholStanding> AlchoholStandings { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.AllergiesName> AllergiesNames { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.AllergyType> AllergyTypes { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Billing> Billings { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Insurance> Insurances { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.CreateOrderInternal> CreateOrderInternals { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Demographic> Demographics { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.DrugAbuse> DrugAbuses { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.EmergencyContact> EmergencyContacts { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Ethnicity> Ethnicities { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Occupation> Occupations { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Race> Races { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Drug> Drugs { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PhoneNumber> PhoneNumbers { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Relationship> Relationships { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Immunization> Immunizations { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.MaritalStanding> MaritalStandings { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.NotesMedicalStaff> NotesMedicalStaffs { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PatientAllergy> PatientAllergies { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PatientDrug> PatientDrugs { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PatientImmunization> PatientImmunizations { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PatientInsurance> PatientInsurances { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PatientProblem> PatientProblems { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.PhoneType> PhoneTypes { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.SmokingStanding> SmokingStandings { get; set; }

        public System.Data.Entity.DbSet<HEAPIFY_Manager_540.Models.Vital> Vitals { get; set; }
    }
}
