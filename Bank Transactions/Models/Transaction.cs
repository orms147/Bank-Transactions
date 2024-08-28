namespace Bank_Transactions.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string BankName { get; set; }
    }
}
