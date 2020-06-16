using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        [Required]
        [Display(Name = "Deposit/Withdraw")]
        public double Amount {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}

        public User Creator {get;set;}
    }
}