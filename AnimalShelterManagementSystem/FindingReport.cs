//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalShelterManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class FindingReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FindingReport()
        {
            this.FindingReportRecords = new HashSet<FindingReportRecord>();
        }
    
        public int FindingReportId { get; set; }
        public string Place { get; set; }
        public System.DateTime Date { get; set; }
        public bool IsInShelter { get; set; }
        public int Species { get; set; }
        public byte[] Picture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FindingReportRecord> FindingReportRecords { get; set; }
    }
}
