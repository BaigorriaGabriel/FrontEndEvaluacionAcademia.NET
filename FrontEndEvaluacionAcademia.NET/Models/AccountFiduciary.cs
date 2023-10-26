namespace FrontEndEvaluacionAcademia.NET.Models
{
    public class AccountFiduciary : Account
    {
        public string CBU { get; set; }
        public string Alias { get; set; }
        public string AccountNumber { get; set; }
        public decimal BalancePeso { get; set; }
        public decimal BalanceUsd { get; set; }
    }
}
