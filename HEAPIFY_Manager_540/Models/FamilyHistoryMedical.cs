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
    
    public partial class FamilyHistoryMedical
    {
        public int id { get; set; }
        public int PatientFamilyProblemID { get; set; }
        public int ProblemID { get; set; }
        public int RelationshipID { get; set; }
        public int PatientID { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Problem Problem { get; set; }
        public virtual Relationship Relationship { get; set; }
    }
}