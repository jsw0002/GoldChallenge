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

        public string IdealSituation { get; set; }

        public string BusinessPreference { get; set; }

        public string StaffSizePreference { get; set; }

        public bool MultipleLocations { get; set; }

        public string[] TopThreePerfectBusinessOpportunity { get; set; }

        public string[] RankTheseSkills { get; set; }

        public string[] TopThreeNonBusinessSkills { get; set; }

        public string[] AttributesThatDescribeYou { get; set; }

        public string WhatIsYourTimeFrame { get; set; }

        public string SalesSkills { get; set; }

        public string ColdCalling { get; set; }

        public string DirectVsAdvertising { get; set; }

        public string[] IndustryInterestedIn { get; set; }

        public string WhiteVsBlueColar { get; set; }

        public string EstablishedVsNewConcept { get; set; }

        public string SmallVsLargeFranchiseSystem { get; set; }

        public string CompetitiveVsOnlyGameInTown { get; set; }

        public string PrestigeOrNotImportant { get; set; }
        
        public string BusinessToBusinessVsBusinessToConsumer { get; set; }

        public string HoursPreference { get; set; }

        [DataType(DataType.MultilineText)]
        public string AnyMoreInformation { get; set; }
    }
}