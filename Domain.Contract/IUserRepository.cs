using Domain.Entittes;
using System.Collections.Generic;

namespace Domain.Contract
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        int AddUser(User user);
        User GetUser(int Id);
        User EditUser(User user);
        User DeleteUser(User user);
    }
}
