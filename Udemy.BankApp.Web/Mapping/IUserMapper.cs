using System.Collections.Generic;
using Udemy.BankApp.Web.Data.Entities;
using Udemy.BankApp.Web.Models;

namespace Udemy.BankApp.Web.Mapping
{
    public interface IUserMapper
    {
        public List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        public UserListModel MapToUserList(ApplicationUser user);
    }
}
