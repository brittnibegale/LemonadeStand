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
            connection = new SqlConnection("Server=desktop-7V83TKI; Database=LemonadeStand;Integrated Security=true");
        }

        public void LoadGame()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT name, moneyInWallet, dayOfGame, lemons, ice, sugar, cups FROM LemonadeStand", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("name: {0} \nmoneyInWallet: {1} \ndayOfGame: {2} \nlemons: {3} \nice: {4} \nsugar: {5} \ncups: {6}",
                        reader.GetString(0), reader.GetFloat(1), reader.GetInt32(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetFloat(6));
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
