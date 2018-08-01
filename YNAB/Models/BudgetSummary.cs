using System;

namespace YNAB.Models
{
    public class BudgetSummary
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public DateTime LastModifiedOn { get; set; } // next line makes me nervous.
        public DateFormat DateFormat { get; set; }
        public CurrencyFormat CurrencyFormat { get; set; }
    }
}