using Domain.Contract;
using Domain.Entittes;
using Infrastructur.DAL;
using System;
using System.Collections.Generic;

namespace Domain.Applicationservice
{
    public class UserFacade : IUserFacade
    {
        IUserRepository repository;
        public UserFacade()
        {
            repository = new UserRepository();
        }
        public int AddUser(User user)
        {
            return repository.AddUser(user);
        }

        public User DeleteUser(User user)
        {
            return repository.DeleteUser(user);
        }

        public User EditUser(User user)
        {
            return repository.EditUser(user);
        }

        public User GetUser(int Id)
        {
            return repository.GetUser(Id);
        }

        public List<User> GetUsers()
        {
            return repository.GetUsers();
        }
    }
}
