using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldChallenge.Models
{
    public class CustomerBackground
    {
        [Key]
        public int CustomerID { get; set; }
        
        [Required]
        [Display(Name = "Will there be anyone else involved in your decision to buy a business?")]
        public bool AreThereAnyOtherDecisionMakers { get; set; }

        [Required]
        [Display(Name = "Are you Married?")]
        public bool IsMarried { get; set; }

        [Display(Name = "What is your spouses name?")]
        public string SpouseName { get; set; }

        [Required]
        [Display(Name = "What is your current occupation?")]
        public string CurrentOccupation { get; set; }

        [Display(Name = "Professional Experience (1)")]
        public string ProfessionalBackground1 { get; set; }

        [Display(Name = "Professional Experience (2)")]
        public string ProfessionalBackground2 { get; set; }

        [Display(Name = "Professional Experience (3)")]
        public string ProfessionalBackground3 { get; set; }

        [Display(Name = "Professional Experience (4)")]
        public string ProfessionalBackground4 { get; set; }

        [Display(Name = "Professional Experience (5)")]
        public string ProfessionalBackground5 { get; set; }

        [Required]
        [Display(Name = "Are you a Veteran?")]
        public bool AreYouAVet { get; set; }

        [Required]
        [Display(Name = "Have you owned a business in the past?")]
        public bool HaveYouOwnedABusinessBefore { get; set; }

        [Display(Name = "What is your credit score?")]
        //[Range(300, 850)]
        public string CreditScore { get; set; }
        
        [Required]
        [Display(Name = "How much do you plan to invest in cash?")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal CashInvestment { get; set; }

        [Required]
        [Display(Name = "Where will your investment be coming from?")]
        public string InvestmentSource { get; set; }

        [Display(Name = "What is your net worth?")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal NetWorth { get; set; }

        [Required]
        [Display(Name = "Where would you like your business to be located?")]
        public string DesiredMarket { get; set; }

        [Required]
        [Display(Name = "Why are you looking for a business?")]
        [DataType(DataType.MultilineText)]
        public string WhyAreYouLookingAtBusinesses { get; set; }

        [Required]
        [Display(Name = "How long have you been looking for a business?")]
        public string LengthOfTimeLooking { get; set; }

        public IEnumerable<SelectListItem> LengthOfTimeLookingDropDown { get; set; }

        [Required]
        [Display(Name = "Have you spoken with anyone else about buying a business?")]
        public bool SpokenWithAnyoneElse { get; set; }
    }
}