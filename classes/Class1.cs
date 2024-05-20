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
        public List<StudentClass> students = new List<StudentClass>();
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
                    StudentClass noviStudent = new StudentClass(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                    students.Add(noviStudent);
                    
                    velicina = students.Count;
                    //Console.WriteLine("Procitan je student " + reader.GetValue(0).ToString() + reader.GetValue(1).ToString() + reader.GetValue(2).ToString());
                }
                konekcija.Close();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

        }

        public int RegistracijaProizvoda(string naziv, string kod)
        {
            try
            {
                string query = "INSERT INTO Jela (NazivJela, KodJela, CijenaJela) 
VALUES('Piletina s rižom', 'PIL123', 55.99); ";
                return 1;
            } catch
            {
                return 0;
            }
        }

        public string InsertStudent(string ime, string jmbag)
        {
            //string ImeIPrezime, int Jmbag
            try
            {
                //SqlConnection konekcija = new SqlConnection(Connection);
                string query = "INSERT INTO Studenti (ImeIPrezimeStudenta, Jmbag) VALUES('"+ ime +"', '"+ jmbag +"'); ";
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
