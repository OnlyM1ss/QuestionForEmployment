using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskIRZ
{
    public class MemoryDataSource
    {
        private List<User> Users = new List<User>();
        private List<string> userNames = new List<string>()
        {
            "Rachel Thompson",
            "Anthony Roberts",
            "Lisa Ruiz",
            "Raymond Chandler",
            "Lauren Rodriguez",
            "Bernice Morris",
            "Martha Evans",
            "Joel Kim",
            "Nikita_2010",
            "Bernice Morris",
            "Diane Edwards"
        };
        public void SetUser(User user)
        {
            Users.Add(user);
        }
        public User GetUser(int ind)
        {
            return Users[ind];
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            users = Users;
            return users;
        }
        public string GetNick(int ind)
        {
            return userNames[ind];
        }

    }
}
