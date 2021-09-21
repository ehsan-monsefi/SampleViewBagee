using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Infrastructur.DAL
{
    public class UserRepository : IUserRepository
    {
        SmContext context;
        public UserRepository()
        {
            context = new SmContext();
        }
        public int AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user.Id;
        }

        public User DeleteUser(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
            return user;
        }

        public User EditUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return user;
        }

        public User GetUser(int Id)
        {
            return context.Users.Find(Id);
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }
    }
}
