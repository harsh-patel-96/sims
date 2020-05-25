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
    
    public partial class TaskAssignmentHistory
    {
        public int TaskAssignmentHistoryId { get; set; }
        public Nullable<int> TicketAssignmentId { get; set; }
        public Nullable<int> TicketId { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public Nullable<int> AssignedBy { get; set; }
        public Nullable<System.DateTime> AssignedOn { get; set; }
        public Nullable<int> TicketStatus { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual EmployeeDetails EmployeeDetails { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual Ticket Ticket1 { get; set; }
        public virtual TicketAssignment TicketAssignment { get; set; }
    }
}