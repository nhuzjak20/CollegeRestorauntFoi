using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRestraunt.classes
{
    internal class DBclass
    {
        string ServerName, Login, Password, Database;
        public DBclass(string sname, string login, string password, string database)
        {
            ServerName = sname;
            Login = login;  
            Password = password;
            Database = database;
        }
    }
}
