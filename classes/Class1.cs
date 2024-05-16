using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CollegeRestraunt.classes;
using System.Threading.Tasks;

namespace CollegeRestraunt.classes
{
    public class DBclass
    {
        string Connection = "Server=31.147.206.65;Database=PI2324_dsedlan22_DB;Persist Security Info=True;User Id=PI2324_dsedlan22_User;Password='!;sx].Ga'";
        SqlConnection konekcija;
        public List<StudentClass> students;
        public int velicina;
        public DBclass()
        {
            konekcija = new SqlConnection(Connection);
  
            try
            {
                konekcija.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                cmd = new SqlCommand("Select * from Studenti", konekcija);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetValue(1) + " " + reader.GetValue(2));
                    StudentClass noviStudent = new StudentClass(reader.GetValue(0).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                    students.Add(noviStudent);
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            velicina = students.Count;

        }

        public string InsertStudent(string ime, string jmbag)
        {
            //string ImeIPrezime, int Jmbag
            try
            {
                //SqlConnection konekcija = new SqlConnection(Connection);
                string query = "INSERT INTO Studenti (IDStudenta, ImeIPrezimeStudenta, Jmbag) VALUES("+ velicina.ToString() + ", '"+ ime +"', '"+ jmbag +"'); ";
                SqlCommand sqlCommand = new SqlCommand(query, konekcija);

                SqlDataAdapter adapter = new SqlDataAdapter();
                konekcija.Open();
                adapter.InsertCommand = sqlCommand;
                adapter.InsertCommand.ExecuteNonQuery();
                konekcija.Close();
                return "1";
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message.ToString();
            }
            
        }
    }
}
