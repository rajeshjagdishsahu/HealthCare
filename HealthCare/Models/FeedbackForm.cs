using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCare.Models
{
    public class FeedbackForm
    {
        [Display(Name = "Your Name")]
        [StringLength(40, ErrorMessage = "{0} cannot be longer than 40 characters.")]
        public string UserName { get; set; }

        
        [Display(Name = "Your Postcode")]
        [Required(ErrorMessage = "{0} is a required.")]
        [StringLength(12, ErrorMessage = "{0} cannot be longer than 12 characters.")]
        public string UserPostcode { get; set; }

        
        [Display(Name = "Your Email Address")]
        [Required(ErrorMessage = "{0} is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [StringLength(40, ErrorMessage = "{0} cannot be longer than 40 characters.")]
        public string UserEmailAddress { get; set; }

        [Display(Name = "Your Phone Number")]
        [StringLength(15, ErrorMessage = "{0} cannot be longer than 15 characters.")]
        public int UserPhoneNumber { get; set; }

        [Display(Name = "Your Message")]
        [StringLength(1000, ErrorMessage = "{0} cannot be longer than 1000 characters.")]
        public string UserMessage { get; set; }
    }
}