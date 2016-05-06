using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldChallenge.Models
{
    public class CustomerPreference
    {
        [Key]
        public int CustomerID { get; set; }

        // Full-time, part-time, or passive
        [Display(Name = "What is your ideal situation?")]
        public IdealSituationType IdealSituation { get; set; }

        public enum IdealSituationType
        {
            [Display(Name = "Full time")]
            Fulltime,
            [Display(Name = "Part time")]
            Parttime,
            Passive
        }

        // Owner Operator vs Executive Model
        [Display(Name = "What type of business do you prefer?")]
        public BusinessPreferenceType BusinessPreference { get; set; }

        public enum BusinessPreferenceType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Owner Operator")]
            OwnerOperator,
            [Display(Name = "Executive Model")]
            ExecutiveModel
        }

        [Display(Name = "Do you have a preference for staff size?")]
        public StaffSizePreferenceType StaffSizePreference { get; set; }

        public enum StaffSizePreferenceType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Small Staff")]
            SmallStaff,
            [Display(Name = "Large Staff")]
            LargeStaff
            
        }

        [Display(Name = "Are you open to multiple locations?")]
        public bool MultipleLocations { get; set; }

        // Examples income, building equity, the number hours, schedule flexibility, home-based, recognition/prestige, 
        // expansion, helping others, ease of operation having employees or not, enjoyment
        [Display(Name = "What are the top 3 things that are most important to you in the perfect business?")]
        public string TopThreePerfectBusinessOpportunity1 { get; set; }

        public string TopThreePerfectBusinessOpportunity2 { get; set; }

        public string TopThreePerfectBusinessOpportunity3 { get; set; }

        [Display(Name = "Rank these skills 1-5 with 1 being your strongest skill or quality.")]
        public string RankTheseSkills1 { get; set; }

        public string RankTheseSkills2 { get; set; }

        public string RankTheseSkills3 { get; set; }

        public string RankTheseSkills4 { get; set; }

        public string RankTheseSkills5 { get; set; }

        // Examples handy around the house, sports, coaching, creativity, music, arts, etc.
        [Display(Name = "What are 3 non business related things you are really good at?")]
        public string TopThreeNonBusinessSkills1 { get; set; }

        public string TopThreeNonBusinessSkills2 { get; set; }

        public string TopThreeNonBusinessSkills3 { get; set; }

        [Display(Name = "Pick the 5-10 attributes that best describe you.")]
        public string[] AttributesThatDescribeYou { get; set; }

        public IEnumerable<SelectListItem> ListOfAttributesThatDescribeYou { get; set; }

        [Display(Name = "For the right business, what is your time frame and why?")]
        public string WhatIsYourTimeFrame { get; set; }

        [Display(Name = "On a scale of 1-10 with 1 being the highest, how would you rank your overall sales skills?")]
        public SalesSkillsType SalesSkills { get; set; }

        public enum SalesSkillsType
        {
            [Display(Name = "1")]
            One,
            [Display(Name = "2")]
            Two,
            [Display(Name = "3")]
            Three,
            [Display(Name = "4")]
            Four,
            [Display(Name = "5")]
            Five,
            [Display(Name = "6")]
            Six,
            [Display(Name = "7")]
            Seven,
            [Display(Name = "8")]
            Eight,
            [Display(Name = "9")]
            Nine,
            [Display(Name = "10")]
            Ten
        }

        [Display(Name = "Why?")]
        [DataType(DataType.MultilineText)]
        public string SalesSkillsExplanation { get; set; }

        [Display(Name = "How do you feel about warm (or cold) calling on the phone?")]
        public ColdCallingPhoneType ColdCallingPhone { get; set; }

        public enum ColdCallingPhoneType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            Yes,
            No
        }

        [Display(Name = "How do you feel about warm (or cold) calling in person?")]
        public ColdCallingPersonType ColdCallingInPerson { get; set; }

        public enum ColdCallingPersonType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            Yes,
            No
        }

        // Direct Sales vs Advertising
        [Display(Name = "Which do you prefer?")]
        public DirectVsAdvertisingType DirectVsAdvertising { get; set; }

        public enum DirectVsAdvertisingType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Direct Sales Based")]
            DirectSales,
            [Display(Name = "Advertising Based")]
            Advertising
        }

        [Display(Name = "Which of the following industries interest you?")]
        public string[] IndustryInterestedIn { get; set; }

        public IEnumerable<SelectListItem> ListOfIndustries { get; set; }

        [Display(Name = "Do you have an employee preference?")]
        public WhiteVsBlueColarType WhiteVsBlueColar { get; set; }

        public enum WhiteVsBlueColarType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "White Collar")]
            WhiteColar,
            [Display(Name = "Blue Collar")]
            BlueColar
        }

        [Display(Name = "Do you have a concept preference?")]
        public EstablishedVsNewConceptType EstablishedVsNewConcept { get; set; }

        public enum EstablishedVsNewConceptType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Established Concept")]
            EstablishedConcept,
            [Display(Name = "New Concept")]
            NewConcept
        }

        [Display(Name = "Do you have a franchise system preference?")]
        public SmallVsLargeFranchiseSystemType SmallVsLargeFranchiseSystem { get; set; }

        public enum SmallVsLargeFranchiseSystemType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Small Franchise System")]
            Small,
            [Display(Name = "Large Franchise System")]
            Large
        }

        [Display(Name = "Which if either do you prefer?")]
        public CompetitiveVsOnlyGameInTownType CompetitiveVsOnlyGameInTown { get; set; }

        public enum CompetitiveVsOnlyGameInTownType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Competitive Industry")]
            Competitive,
            [Display(Name = "Only Game in Town")]
            OnlyGameInTown
        }

        [Display(Name = "Is prestige important to you?")]
        public PrestigeOrNotImportantType PrestigeOrNotImportant { get; set; }

        public enum PrestigeOrNotImportantType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Prestige Important")]
            PrestigeImportant,
            [Display(Name = "Not Very Important")]
            NotImportant
        }

        [Display(Name = "Do you prefer business to business or business to consumer?")]
        public BusinessToBusinessVsBusinessToConsumerType BusinessToBusinessVsBusinessToConsumer { get; set; }

        public enum BusinessToBusinessVsBusinessToConsumerType
        {
            [Display(Name = "No Preference")]
            NoPreference,
            [Display(Name = "Business to Business")]
            BusinessToBusiness,
            [Display(Name = "Business to Consumer")]
            BusinessToConsumer
            
        }

        [Display(Name = "Do you have a preference on hours to work?/n Monday-Friday")]
        public bool HoursPreferenceMonFri { get; set; }

        [Display(Name = "No Nights")]
        public bool HoursPreferenceNoNights { get; set; }

        [Display(Name = "No Saturdays")]
        public bool HoursPreferenceNoSaturdays { get; set; }

        [Display(Name = "No Sundays")]
        public bool HoursPreferenceNoSundays { get; set; }

        [Display(Name = "No Preference")]
        public bool HoursPreferenceNoPreference { get; set; }

        [Display(Name = "Is there anything else I should know that will help me in finding you the right business?")]
        [DataType(DataType.MultilineText)]
        public string AnyMoreInformation { get; set; }
    }
}