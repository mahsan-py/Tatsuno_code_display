using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public class checkboxwork
    {
        public bool get_active_nozzel_db_data(int i)
        {



            bool data = new bool();
            MySqlConnection connection = new MySqlConnection(Appsetting.ConnectionString());

            connection.Open();

            MySqlCommand cmd;
            cmd = connection.CreateCommand();


            cmd.CommandText = "SELECT `IsActive` FROM `nozzelconfiguration` WHERE `Id`=@id;";
            cmd.Parameters.AddWithValue("@id", i);


            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                data = reader.GetBoolean(reader.GetOrdinal("IsActive"));


            }



            connection.Close();


            return data;
        }
    }
}
