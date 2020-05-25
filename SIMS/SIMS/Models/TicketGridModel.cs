using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIMS.Models
{
    public class TicketGridModel
    {
        public int TicketId { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }  
        public int TicketStatus { get; set; }
        public string Remarks { get; set; }        
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        //public virtual Lookup Lookup { get; set; }
        //public virtual Lookup Lookup1 { get; set; }
        //public virtual Lookup Lookup2 { get; set; }
        //public virtual ProjectDetails ProjectDetails { get; set; }
    }
}