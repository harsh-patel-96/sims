//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.TaskAssignmentHistory = new HashSet<TaskAssignmentHistory>();
            this.TaskAssignmentHistory1 = new HashSet<TaskAssignmentHistory>();
        }
    
        public int TicketId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public string Title { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> AssignmentStatus { get; set; }
        public int TicketStatus { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        public virtual Lookup Lookup1 { get; set; }
        public virtual Lookup Lookup2 { get; set; }
        public virtual ProjectDetails ProjectDetails { get; set; }
        public virtual Task Task { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignmentHistory> TaskAssignmentHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignmentHistory> TaskAssignmentHistory1 { get; set; }
    }
}