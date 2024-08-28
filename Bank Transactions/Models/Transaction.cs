using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_Transactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 character only.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(120)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(120, ErrorMessage = "Maximum 120 character only.")]

        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(120)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(120, ErrorMessage = "Maximum 120 character only.")]

        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 character only.")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
