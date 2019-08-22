using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using BankAccount.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        [Required]
        public int UserId {get;set;} // Foregin Key
        
        [Required]
        public float Amount {get;set;}
        
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        // Navigation Property
        public User Creator {get;set;}
    }
}