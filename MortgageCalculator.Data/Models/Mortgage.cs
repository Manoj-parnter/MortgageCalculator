using System;
using System.ComponentModel.DataAnnotations;

namespace MortgageCalculator.Data.Models
{
    public class Mortgage
    {
        [Key]
        public int MortgageId { get; set; }
        public string Name { get; set; }
        public int MortgageType { get; set; }
        public int InterestRepayment { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public int TermsInMonths { get; set; }
        public decimal CancellationFee { get; set; }
        public decimal EstablishmentFee { get; set; }
        public Guid SchemaIdentifier { get; internal set; }
    }
}
