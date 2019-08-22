using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        private MyContext DbContext;
        public HomeController(MyContext context)
        {
            DbContext = context;
        }

        // ---- Register Page ----
        public IActionResult Index()
        {
            return View();
        }

        // ---- Login Page ----
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        // ---- Create a User ----
        [HttpPost("CreateUser")]
        public IActionResult CreateUser(User CreateUser)
        {
            if(ModelState.IsValid)
            {
                if(DbContext.Users.Any(u => u.Email == CreateUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                CreateUser.Password = hasher.HashPassword(CreateUser, CreateUser.Password);
                DbContext.Add(CreateUser);
                DbContext.SaveChanges();
                HttpContext.Session.SetInt32("SessionId", CreateUser.UserId); 
                return RedirectToAction("Dashboard");
            }else{
                return View("Index");
            }
        }
        
        // ---- Log a User ----
        [HttpPost("LogUser")]
        public IActionResult LogUser(LoggedUser LogUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = DbContext.Users.FirstOrDefault(u => u.Email == LogUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoggedUser>();
                var result = hasher.VerifyHashedPassword(LogUser, userInDb.Password, LogUser.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("SessionId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }else{
                return View("Login");
            }
        }

        // ---- Dashboard Page ----
        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            float? SessionBalance = HttpContext.Session.GetInt32("SessionBalance");
            int? SessionId = HttpContext.Session.GetInt32("SessionId");
            if(SessionId == null)
            {
                return View("Index");
            }else{
                if(SessionBalance == null)
                {
                    SessionBalance = 0;
                }
                var ValidUser = DbContext.Users.Include(u => u.CreatedTransactions)
                .FirstOrDefault(u => u.UserId == SessionId);
                
                List<Transaction> ValidTransaction = DbContext.Transactions
                .Where(t => t.UserId == SessionId).ToList();

                foreach(var transaction in ValidUser.CreatedTransactions)
                {
                    SessionBalance += transaction.Amount;
                }
                ValidUser.CreatedTransactions.OrderByDescending(t => t.CreatedAt);
                
                @ViewBag.Name = ValidUser.FirstName;
                @ViewBag.Balance = SessionBalance;
                return View("Dashboard", ValidTransaction);
            }
        }

        // ---- Transaction ----
        [HttpPost("Transaction")]
        public IActionResult Transaction(float FormValue)
        {
            float? SessionBalance = HttpContext.Session.GetInt32("SessionBalance");
            int? SessionId = HttpContext.Session.GetInt32("SessionId");
            var ValidUser = DbContext.Users
            .Include(u => u.CreatedTransactions)
            .FirstOrDefault(u => u.UserId == SessionId); 
            Transaction transaction = new Transaction();

            transaction.Amount += FormValue;
            SessionBalance += transaction.Amount;
            ValidUser.CreatedTransactions.Add(transaction);
            DbContext.SaveChanges();
            return RedirectToAction("Dashboard", ValidUser);
        }

        // ---- Log Out ----
        [HttpGet("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
    }
}