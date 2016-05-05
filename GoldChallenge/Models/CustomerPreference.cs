using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoldChallenge.Models
{
    public class CustomerPreference
    {
        [Key]
        public int CustomerID { get; set; }

        // Full-time, part-time, or passive
        [Display(Name = "What is your ideal situation?")]
        public string IdealSituation { get; set; }

        // Owner Operator vs Executive Model
        [Display(Name = "What type of business do you prefer?")]
        public string BusinessPreference { get; set; }

        [Display(Name = "Do you have a preference for staff size?")]
        public string StaffSizePreference { get; set; }

        [Display(Name = "Are you open to multiple locations?")]
        public bool MultipleLocations { get; set; }

        // Examples income, building equity, the number hours, schedule flexibility, home-based, recognition/prestige, 
        // expansion, helping others, ease of operation having employees or not, enjoyment
        [Display(Name = "What are the top 3 things that are most important to you in the perfect business?")]
        public string[] TopThreePerfectBusinessOpportunity { get; set; }

        [Display(Name = "Rank these skills 1-5 with 1 being your strongest skill or quality.")]
        public string[] RankTheseSkills { get; set; }

        // Examples handy around the house, sports, coaching, creativity, music, arts, etc.
        [Display(Name = "What are 3 non business related things you are really good at?")]
        public string[] TopThreeNonBusinessSkills { get; set; }

        [Display(Name = "Pick the 5-10 attributes that best describe you.")]
        public string[] AttributesThatDescribeYou { get; set; }

        [Display(Name = "For the right business, what is your time frame and why?")]
        public string WhatIsYourTimeFrame { get; set; }

        [Display(Name = "On a scale of 1-10 with 1 being the highest, how would you rank your overall sales skills?")]
        public string SalesSkills { get; set; }

        [Display(Name = "How do you feel about warm (or cold) calling on the phone?")]
        public string ColdCallingPhone { get; set; }

        [Display(Name = "How do you feel about warm (or cold) calling in person?")]
        public string ColdCallingInPerson { get; set; }

        // Direct Sales vs Advertising
        [Display(Name = "Which do you prefer?")]
        public string DirectVsAdvertising { get; set; }

        [Display(Name = "Which of the following industries interest you?")]
        public string[] IndustryInterestedIn { get; set; }

        [Display(Name = "Do you have an employee preference?")]
        public string WhiteVsBlueColar { get; set; }

        [Display(Name = "Do you have a concept preference?")]
        public string EstablishedVsNewConcept { get; set; }

        [Display(Name = "Do you have a franchise system preference?")]
        public string SmallVsLargeFranchiseSystem { get; set; }

        [Display(Name = "Which if either do you prefer?")]
        public string CompetitiveVsOnlyGameInTown { get; set; }

        [Display(Name = "Is prestige important to you?")]
        public string PrestigeOrNotImportant { get; set; }

        [Display(Name = "Do you prefer business to business or business to consumer?")]
        public string BusinessToBusinessVsBusinessToConsumer { get; set; }

        [Display(Name = "Do you have a preference on hours to work?")]
        public string HoursPreference { get; set; }

        [Display(Name = "Is there anything else I should know that will help me in finding you the right business?")]
        [DataType(DataType.MultilineText)]
        public string AnyMoreInformation { get; set; }
    }
}