using System;
using System.Collections.Generic;
using Repository.Interface;

namespace Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        public List<string> GetUserDetails()
        {
            var userList = new List<string>();
            userList.Add("User 1");
            userList.Add("User 2");
            userList.Add("User 3");
            return userList;
        }
    }
}
