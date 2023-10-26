namespace FrontEndEvaluacionAcademia.NET.Models
{
    public class Account
    {
        public string Cbu { get; set; }
        public string Alias { get; set; }
        public string AccountNumber { get; set; }
        public decimal BalancePeso { get; set; }
        public decimal BalanceUsd { get; set; }
        public int CodAccount { get; set; }
        public string Type { get; set; }
        public int CodUser { get; set; }
        public bool IsActive { get; set; }
    }
}
