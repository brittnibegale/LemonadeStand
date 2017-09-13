using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        string typeOfGame;
        string multiplayerVersion;
        string multiplayerPlayerNumber;
        Player player1;
        //Player player2;
        //Player player3;
        //Player player4;
        public Game()
        {

        }
        public void StartGame()
        {
            GamePlay();
        }

        public void GamePlay()
        {
            Console.WriteLine("Welcome to Lemonade Stand! This game lasts for a week. Everyday has different weather, which will effect how many people buy your lemonade. You have the ability to buy items and change the recipe to optimize how many people buy your lemonade. Hit ENTER to continue.");
            Console.ReadLine();
            Console.WriteLine("How would you like to play this game? In the single player mode you will only play against your self. In the multi player mode you can play against a computer or against upto 4 friends. /n Please, choose either single player or multi player.");
            typeOfGame = Console.ReadLine().ToLower();
            DetermineGameType(typeOfGame);
        }
        public void DetermineGameType(string typeOfGame)
        {
            while (true)
            {
                if (typeOfGame == "single" || typeOfGame == "single player" || typeOfGame == "singleplayer" || typeOfGame == "single player mode" || typeOfGame == "single mode")
                {
                    player1 = new Human();
                    OnePlayerGame(player1);
                }
                //else if (typeOfGame == "multi" || typeOfGame == "multi player" || typeOfGame == "multiplayer" || typeOfGame == "multiplayer mode" || typeOfGame == "multi player mode")
                //{
                //    Console.WriteLine("Would you like to play against a computer or your friends? Please, choose computer or friends");
                //    multiplayerVersion = Console.ReadLine().ToLower();
                //    DetermineMultiplayerGame(multiplayerVersion);
                //}
                else
                {
                    Console.WriteLine("Please type single player or multi player.");
                    typeOfGame = Console.ReadLine().ToLower();
                }
            }
        }

        public void OnePlayerGame(Player player1)
        {
            Day day1 = new Day();
            day1.Day1();
            Store store = new Store(player1);
            Console.WriteLine("Your current bank balance is: " + player1.moneyBank);
            store.BuyLemons(player1);
            Console.WriteLine("Your current bank balance is: " + player1.moneyBank);
            store.BuyCups(player1);
            Console.WriteLine("Your current bank balance is: " + player1.moneyBank);
            store.BuyIce(player1);
            Console.WriteLine("Your current bank balance is: " + player1.moneyBank);
            store.BuySugar(player1);
            Console.WriteLine("Your current bank balance is: " + player1.moneyBank);


        }
        //public void DetermineMultiplayerGame(string multiplayerVersion)
        //{
        //    while (true)
        //    {
        //        if(multiplayerVersion == "computer")
        //        {
        //            player1 = new Human();
        //            player2 = new Computer();
        //            ComputerVsHumanGame(player1, player2);
        //        }
        //        else if(multiplayerVersion == "friends" || multiplayerVersion == "friend")
        //        {
        //            Console.WriteLine("How many friends would you like to play with? Please enter how many people will play with you. 1-4");
        //            multiplayerPlayerNumber = Console.ReadLine();
        //            DetermineHowManyPlayers(multiplayerPlayerNumber);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter who you would like to play against. Either computer or friends");
        //            multiplayerVersion = Console.ReadLine().ToLower();
        //        }
        //    }
        //}
        //public void ComputerVsHumanGame(Player player1, Player player2)
        //{

        //}
        //public void DetermineHowManyPlayers(string multiplayerPlayerNumber)
        //{

        //}
    }
}
