using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp12345
{
    
    public class NozzelDbConfig
    {
        public string[,] Config()

        {

            string[,] list_data = new string[10, 7];
            string connectionString = "Server=localhost;" +
                "Database=munir_filling;" +
                "Uid=root;" +
                "pwd=''";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM nozzelconfiguration";

                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                int i = 0;

                // Now, dataTable contains all the rows from the database

                // You can iterate over the DataTable to access each row and its columns
                foreach (DataRow row in dataTable.Rows)
                {

                    



                    for (int j = 0; j < 7; j++)
                    {
                        list_data[i, j] = $"{row.ItemArray[j]}";
                        string h = list_data[i, j];
                    }

                  
                    i++;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list_data;
        }


    }
}
