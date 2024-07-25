using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{
    public class Teacher
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Class> Classes { get; set; }

        public Teacher(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Classes = new List<Class>();
        }

    }
}
