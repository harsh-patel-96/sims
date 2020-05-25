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
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.TaskHistory = new HashSet<TaskHistory>();
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int TaskId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public Nullable<int> SubModuleId { get; set; }
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public int TaskStatus { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        public virtual ProjectDetails ProjectDetails { get; set; }
        public virtual ProjectModules ProjectModules { get; set; }
        public virtual SubModuleDetails SubModuleDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskHistory> TaskHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
