using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoldChallenge.Models
{
    public class NetWorthCalculator
    {
        [Key]
        public int CustomerID { get; set; }

        //Assets

        [DataType(DataType.Currency)]
        public decimal CashInCheckingAndSavings { get; set; }

        [DataType(DataType.Currency)]
        public decimal StocksBondsMutualFunds { get; set; }

        [DataType(DataType.Currency)]
        public decimal Ira401kOtherRetirementPlans { get; set; }

        [DataType(DataType.Currency)]
        public decimal RealEstateHome { get; set; }

        [DataType(DataType.Currency)]
        public decimal RealEstateOther { get; set; }

        [DataType(DataType.Currency)]
        public decimal BusinessValue { get; set; }

        [DataType(DataType.Currency)]
        public decimal AppraisedCollectibles { get; set; }

        [DataType(DataType.Currency)]
        public decimal MoneyOwedToYou { get; set; }

        [DataType(DataType.Currency)]
        public decimal OtherAssets { get; set; }

        // Liabilities

        [DataType(DataType.Currency)]
        public decimal MortgageHome { get; set; }

        [DataType(DataType.Currency)]
        public decimal MortgageOther { get; set; }

        [DataType(DataType.Currency)]
        public decimal ChargeAccountsCreditCards { get; set; }

        [DataType(DataType.Currency)]
        public decimal AutomobileLoans { get; set; }

        [DataType(DataType.Currency)]
        public decimal OtherLiabilities { get; set; }

        // Total Fields

        [DataType(DataType.Currency)]
        public decimal TotalAssets { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalLiabilities { get; set; }

        // NetWorth

        [DataType(DataType.Currency)]
        public decimal TaMinusTl { get; set; }
    }
}