using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    [NotMapped]
    public class BAViewModel
    {
        public User CurrentUser {get;set;}
        public Transaction Transaction {get;set;}
        public List<Transaction> AllUserTransaction {get;set;}
    }
}