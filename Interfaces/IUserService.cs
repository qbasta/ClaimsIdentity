using ClaimsIdentity.Models;
using ClaimsIdentity.ViewModels.User;

namespace ClaimsIdentity.Interfaces
{
    public interface IUserService
    {
        void Insert(User user);
        ListUserViewModel GetPeople();
        ListUserViewModel GetTodayPeople();
    }
}
