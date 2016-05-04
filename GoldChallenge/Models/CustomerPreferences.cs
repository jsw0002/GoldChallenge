using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoldChallenge.Models
{
    public class CustomerPreferences
    {
        [Key]
        public int CustomerID { get; set; }
    }
}