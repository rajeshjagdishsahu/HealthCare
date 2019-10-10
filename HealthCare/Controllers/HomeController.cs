using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using HealthCare.Models;

namespace HealthCare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
            
        }
/*        [HttpGet]
        public ActionResult Contacts()
        {
            FeedbackForm temp = new FeedbackForm();
            temp.UserMessage = @Resources.Global.Contacts_Form_Message_Field;
            return View(temp);
        }


        [HttpPost]
        public ActionResult Contacts(FeedbackForm Model)
        {
            string Text = "<html> <head> </head>" +
                          " <body style= \" font-size:12px; font-family: Arial\">" +
                          Model.UserMessage +
                          "</body></html>";

            SendEmail("tayna-anita@mail.ru", Text);
            FeedbackForm tempForm = new FeedbackForm();
            return View(tempForm);
        }


        public static bool SendEmail(string SentTo, string Text)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("Test@mail.ru");
            msg.To.Add(SentTo);
            msg.Subject = "Password";
            msg.Body = Text;
            msg.Priority = MailPriority.High;
            msg.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.mail.ru", 25);



            client.UseDefaultCredentials = false;
            client.EnableSsl = false;
            client.Credentials = new NetworkCredential("TestLogin", "TestPassword");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.EnableSsl = true;

            try
            {
                client.Send(msg);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }*/


    }
}