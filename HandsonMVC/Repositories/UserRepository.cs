using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsonMVC.Models;

namespace HandsonMVC.Repositories
{
    public class UserRepository : User
    {
        public static List<User> list = new List<User>()
        {
            new User()
            {
                Name = "abc",
                Country = "USA",
                Uname = "abc",
                Password = "12345",}
            };
        public UserRepository()
        {

        }

        public void Add(User item)
        {
            list.Add(item);//add user data into list
        }
        public User Validate(string uname, string password)
        {
            foreach (var item in list)
            {
                if (item.Uname == uname && item.Password == password)
                {
                    return item;
                }
            }
            return null;
        }
    }

}



   

