using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DatabaseSaver
    {
        SqlConnection connection;
        public DatabaseSaver()
        {
            connection = new SqlConnection("Server=desktop-7V83TKI; Database=LemonadeStand;Integrated Security=true");
        }
        public void Save(string name, double moneyInWallet, int dayOfGame, double lemons, double ice, double sugar, double cups)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Scores VALUES ('{name}', '{moneyInWallet}', '{dayOfGame}', '{lemons}', '{ice}','{sugar}', '{cups}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Game Saved");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
            //add a finally to close
        }
    }
}
