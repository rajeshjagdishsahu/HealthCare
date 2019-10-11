using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using HealthCare.Models;

namespace HealthCare.Controllers
{
    public class HomeController : Controller
    {
        public const string COMPANY_EMAIL = "info@healthcareaccessltd.co.uk";
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

        [HttpPost]
        public ActionResult Contact(FeedbackForm feedbackForm)
        {



            StringBuilder sb = new StringBuilder();
            MailMessage mail = new MailMessage();

            //To revisit this as this a feedback from website and not 
            //MailAddress from = new MailAddress(feedbackForm.UserEmailAddress);
            MailAddress from = new MailAddress(COMPANY_EMAIL);

            //Append the collections from the form
            sb.Append("User Name:  " + feedbackForm.UserName + "\n");
            sb.Append("User Postcode: " + feedbackForm.UserPostcode + "\n");
            sb.Append("User Email " + feedbackForm.UserEmailAddress + "\n");
            sb.Append("User Phone Number: " + feedbackForm.UserPhoneNumber + "\n\n");
            sb.Append("User Message: " + feedbackForm.UserMessage + "\n");
            sb.Append("\n\nKind regards, XYZ\n");

            //Lets construct the email
            mail.From = from;
            mail.To.Add(COMPANY_EMAIL);
            mail.Subject = "Feedback from the Website";
            mail.Body = sb.ToString();

            //Set the SMTP
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.healthcareaccessltd.co.uk";
            smtp.Port = 587;
            smtp.Send(mail);


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