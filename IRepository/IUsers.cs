using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wema.BIT.Models;

namespace Wema.BIT.IRepository
{
    public interface IUsers
    {
        public UsersList AddUser(UsersList usersList);
        List<UsersList> GetAllUsers();
        public UsersList DeletUser(UsersList usersLists);

        public UsersList EditUser(UsersList usersListss);
        public UsersList ViewUser(UsersList usersListsss);
        public int AddNumber(int a, int b);
      //  UsersList DeletUser(UsersList users);
    }
}
