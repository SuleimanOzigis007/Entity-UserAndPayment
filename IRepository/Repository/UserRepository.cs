using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wema.BIT.Models;
using Wema.BIT.User;

namespace Wema.BIT.IRepository.Repository
{
    public class UserRepository : IUsers
    {
        private readonly List<UsersList> usersLists;

        public UserRepository()
        {
            usersLists = new List<UsersList>();
        }
        public int AddNumber(int a, int b)
        {
            throw new NotImplementedException();
        }

        public UsersList AddUser(UsersList usersList)
        {

            usersLists.Add(usersList);

            return usersList;
        }
        public List<UsersList> GetAllUsers()
        {
            return usersLists;
        }

        public void DeletUser()
        {
            throw new NotImplementedException();
        }

        public void EditUser()
        {
            throw new NotImplementedException();
        }

       

        public void ViewUser()
        {
            throw new NotImplementedException();
        }
    }

}
