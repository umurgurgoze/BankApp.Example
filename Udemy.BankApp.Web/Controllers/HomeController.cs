using Microsoft.AspNetCore.Mvc;
using Udemy.BankApp.Web.Data.Interfaces;
using Udemy.BankApp.Web.Mapping;

namespace Udemy.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        public HomeController(IApplicationUserRepository applicationUserRepository, IUserMapper userMapper)
        {
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
        }
        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_applicationUserRepository.GetAll()));
        }
    }
}
