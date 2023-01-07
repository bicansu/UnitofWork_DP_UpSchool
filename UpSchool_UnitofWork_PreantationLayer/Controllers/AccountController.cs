using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpSchool_UnitofWork_PreantationLayer.Models;
using UpSchool_UOW_BussinessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Concrete;
using UpSchool_UOW_EntityLayer.Concreate;

namespace UpSchool_UnitofWork_PreantationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            //    Context c = new Context();
            //    var values = c.Accounts.Where(x => x.AccountID == 1).FirstOrDefault();
            //    var values2 = c.Accounts.Where(x => x.AccountID == 2).FirstOrDefault();
            //    values.AccountName = "Tuba Zorlu";
            //    values.AccountBalance = values.AccountBalance - 2500;

            //    c.SaveChanges();

            //values2.AccountName = "Şeymanur Çakir";
            //values2.AccountBalance = values2.AccountBalance + 2500;

             var values1 = _accountService.TGetByID(p.SenderID);
             var values2 = _accountService.TGetByID(p.ReceiverID);

                values1.AccountBalance -= p.Amount;
                values2.AccountBalance += p.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                values1,
                values2
            };
            _accountService.TMultiUpdate(modifiedAccounts);
              return View();
        }
    }
}
//