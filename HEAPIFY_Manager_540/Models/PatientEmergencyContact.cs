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
    
    public partial class PatientEmergencyContact
    {
        public int PatientEmergencyContactID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> EmergencyContactID { get; set; }
    
        public virtual EmergencyContact EmergencyContact { get; set; }
        public virtual Patient Patient { get; set; }
    }
}