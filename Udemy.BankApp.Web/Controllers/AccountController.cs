using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Udemy.BankApp.Web.Data.Context;

namespace Udemy.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly BankContext _context;

        public AccountController(BankContext context)
        {
            _context = context;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);

            return View(userInfo);
        }
    }
}
