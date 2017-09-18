using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DatabaseLoader
    {
        SqlConnection connection;

        public DatabaseLoader()
        {
            connection = new SqlConnection("Server=brit-PC;Database=LemonadeStand;Integrated Security=true");
        }

        public void LoadGame()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Winner_Name, Loser_Name, Winner_Score, Loser_Score FROM Scores", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Winner Name: {0} \nLoser Name: {1} \nWinner Score: {2} \nLoser Score: {3}",
                        reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                    Console.WriteLine("*******************************");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
