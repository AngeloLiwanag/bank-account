using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using BankAccount.Models;

namespace BankAccount
{
    public class UserTransaction
    {
        public User NewUser {get;set;}
        public Transaction NewTransaction {get;set;}

    }
}