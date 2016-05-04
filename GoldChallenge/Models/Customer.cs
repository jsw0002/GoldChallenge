using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoldChallenge.Models
{
    public class Customer : Person
    {
        [Display(Name = "How did you hear about us?")]
        public string SourceOfLead { get; set; }
    }
}