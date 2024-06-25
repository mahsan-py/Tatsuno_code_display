using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12345
{
    public class serialwriteconfg
    {
       
        public (string portname, bool data) GetSerialWriteNozzleDbData(int i)
        {
            string portname = null;
            bool data = false;

            // Ensure using directive for MySqlConnection
            using (MySqlConnection connection = new MySqlConnection(Appsetting.ConnectionString()))
            {
                connection.Open();

                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM `serial_write_data` WHERE `serial_write_id`=@id;";
                    cmd.Parameters.AddWithValue("@id", i);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            portname = reader.GetString(reader.GetOrdinal("com_name"));
                            data = reader.GetBoolean(reader.GetOrdinal("nozzle_status"));




                        }
                    }
                }

                connection.Close();
            }

            return (portname, data);
        }


       


    }
}
