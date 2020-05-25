using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.IO;
using System.Web;
using System.Web.Mvc;
using SIMS.Models;


namespace SIMS.Controllers
{
    public class TicketController : Controller
    {
        
        // GET: Ticket
        public ActionResult Ticket()
        {
            SIMS1DBEntities db = new SIMS1DBEntities();
            //var result = (from t in db.Ticket
            //              select new TicketGridModel
            //              {
            //                  TicketId = t.TicketId,
            //                  ProjectId = t.ProjectId,
            //                  Title = t.Title,
            //                  Type = t.Type,
            //                  TicketStatus = t.TicketStatus,
            //                  Remarks = t.Remarks,
            //                  CreatedOn = t.CreatedOn,
            //                  UpdatedOn = t.UpdatedOn,
            //                  //Lookup = t.Lookup,
            //                  //Lookup1 = t.Lookup1,
            //                  //Lookup2 = t.Lookup2,
            //                  //ProjectDetails = t.ProjectDetails,
            //              }).ToList();
            return View(db.Ticket.OrderBy(t => t.TicketId));
        }
       
    }
}