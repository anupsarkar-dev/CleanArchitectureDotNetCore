using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.MVC.Controllers
{
    public class UserAccounts : Controller
    {
        private IUserAccountService userAccountService;


        public UserAccounts(IUserAccountService userAccountService)
        {
            this.userAccountService = userAccountService;
        }


        public IActionResult Index()
        {

            return View(userAccountService.GetUserAccounts());
        }

        public IActionResult Update()
        {
            string uid = "AAA";

            if (userAccountService.DeleteUser(uid))
                ViewBag.flag = "Daleted";
            else
                ViewBag.flag = "Not Daleted";

            return View();
        }
    }
}
