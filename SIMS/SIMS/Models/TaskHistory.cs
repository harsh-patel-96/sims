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
    
    public partial class TaskHistory
    {
        public int TaskHistoryId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public Nullable<int> SubModuleId { get; set; }
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public Nullable<int> TaskStatus { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        public virtual ProjectDetails ProjectDetails { get; set; }
        public virtual ProjectModules ProjectModules { get; set; }
        public virtual SubModuleDetails SubModuleDetails { get; set; }
        public virtual Task Task { get; set; }
    }
}