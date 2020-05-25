using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIMS.Models;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace SIMS.Controllers
{
    public class DailyReportController : Controller
    {
        SIMS1DBEntities db = new SIMS1DBEntities();
        // GET: DailyReport
        public ActionResult DailyReportView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DailyReportView(SIMS.Models.MailModel objsendmail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(objsendmail.To);
                mail.From = new MailAddress(objsendmail.From);
               
                mail.Subject = objsendmail.Subject;
                string Body = objsendmail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("pharsh224@gmail.com", "Hansadidipapaji@28*99");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.Message = "Report Sent Successfully..";
                return View("DailyReportView", objsendmail);
            }
            else
            {
                return View();
            }
        }
            //MailMessage mailmsg = new MailMessage("pharsh224@gmail.com", objsendmail.To);
            //mailmsg.Subject = objsendmail.Subject;
            //mailmsg.Body = objsendmail.Body;

            //if (sendfile != null)
            //{
            //    string filename = Path.GetFileName(sendfile.FileName);
            //    mailmsg.Attachments.Add(new Attachment(sendfile.InputStream, filename));

            //}
            //mailmsg.IsBodyHtml = false;
            //SmtpClient smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true

            //};
            //NetworkCredential networkCredential = new NetworkCredential("mihirpatel19.mp@gmail.com", "mihirpatel1997");
            //smtp.UseDefaultCredentials = true;
            //smtp.Credentials = networkCredential;
            //smtp.Send(mailmsg);
            //smtp.Timeout = 25000;
            //ViewBag.Message = "Certificate Sent Successfully..";
            //return View("SendCertificate", objsendcertificate);
        
    }
}