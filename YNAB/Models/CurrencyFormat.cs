namespace YNAB.Models
{
    public class CurrencyFormat
    {
        public string IsoCode { get; set; }
        public string ExampleFormat { get; set; }
        public int DecimalDigits { get; set; }
        public string DecimalSeperator { get; set; }
        public bool SymbolFirst { get; set; }
        public string GroupSeperator { get; set; }
        public string CurrencySymbol { get; set; }
        public bool DisplaySymbol { get; set; }
    }
}