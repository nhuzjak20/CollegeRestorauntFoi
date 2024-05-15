using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient
using System.Threading.Tasks;

namespace CollegeRestraunt.classes
{
    internal class DBclass
    {
        string Connection = "Data Source=31.147.206.65;Initial Catalog=PI2324_dsedlan22_DB;Persist Security Info=True;User ID=PI2324_dsedlan22_User;Password=!;sx].Ga";
        public DBclass()
        {
            SqlConnection konekcija = new SqlConnection(Connection);
            
            konekcija.Open();
            
        }

        public void InsertStudent(string ImeIPrezime, int Jmbag)
        {
            SqlConnection konekcija = new SqlConnection(Connection);

            konekcija.Open();

        }
    }
}
