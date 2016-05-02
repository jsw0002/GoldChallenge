using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldChallenge.Models
{
    public class Customer : Person
    {
        public string SourceOfLead { get; set; }
    }
}