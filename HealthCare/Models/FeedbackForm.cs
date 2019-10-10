using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCare.Models
{
    public class FeedbackForm
    {
        public string UserName { get; set; }
        [Required]
        public string UserPostcode { get; set; }
        [Required]
        public string UserEmailAddress { get; set; }
        public int UserPhoneNumber { get; set; }
        public string UserMessage { get; set; }
    }
}