using ClaimsIdentity.Models;

namespace ClaimsIdentity.Interfaces
{
    public interface IUserRepository
    {
        void Insert(User user);
        IQueryable<User> GetPeople();
        IQueryable<User> GetTodayPeople();
    }
}
