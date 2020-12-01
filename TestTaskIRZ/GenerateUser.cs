using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestTaskIRZ
{
    public class GenerateUser
    {
        MemoryDataSource memoryDataSource = new MemoryDataSource();
        private readonly char[] _alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToArray();
        Random random;
        public User CreateUser()
        {
            User user = new User();
            string name = RandomizeUserName();
            string password = GeneratePassword(7);
            user.Name = name;
            user.Password = password;
            return user;
        }
        private string GeneratePassword(int length)
        {
            string password = string.Empty;
            random = new Random();
            for (int i = 1; i <= length; i++)
            {
                int index = random.Next(1, 20);
                password += _alphabet[index].ToString();
            }
            return password;
        }
        
        private string RandomizeUserName()
        {
            random = new Random();
            int index = random.Next(0, 10);
            string name = memoryDataSource.GetNick(index);
            return name;
        }
    }
}
