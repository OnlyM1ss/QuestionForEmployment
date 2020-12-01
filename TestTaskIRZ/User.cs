using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskIRZ
{
    public class User
    {
        private int id = 0;
        private string name;
        private string password;

        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = ++id; }
    }
}
