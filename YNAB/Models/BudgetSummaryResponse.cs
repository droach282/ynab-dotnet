using System.Collections.Generic;

namespace YNAB.Models
{
    public class BudgetSummaryResponse : IResponse
    {
        public List<BudgetSummary> Budgets { get; set; }
    }
}