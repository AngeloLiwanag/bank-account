using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using BankAccount.Models;

namespace BankAccount.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [Display(Name="first name")]
        [MinLength(2, ErrorMessage="First name must be 2 characters or longer!")]
        public string FirstName {get;set;}

        [Required]
        [Display(Name="last name")]
        [MinLength(2, ErrorMessage="Last name must be 2 characters or longer!")]
        public string LastName {get;set;}
        
        [EmailAddress]
        [Required]
        [Display(Name="email")]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [Display(Name="password")]
        public string Password {get;set;}

        // Navigation Property
        public List<Transaction> CreatedTransactions {get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}

    }
}