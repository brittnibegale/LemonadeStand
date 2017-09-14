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
        //string multiplayerVersion;
        //string multiplayerPlayerNumber;
        int amountOfLemons;
        int amountOfSugar;
        int amountOfCups;
        int amountOfIce;
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
            Console.WriteLine("Welcome to Lemonade Stand! This game lasts for a week if you can make it! Everyday has different weather, which will effect how many people buy your lemonade. You have the ability to buy items and change the recipe to optimize how many people buy your lemonade. Hit ENTER to continue.");
            //have a yes no here for database saving
            Console.ReadLine();
            Console.WriteLine("How would you like to play this game? In the single player mode you will only play against your self. In the multi player mode you can play against a computer or against upto 4 friends. \n Please, choose either single player or multi player.");
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
                    break;//change this if you want to play again
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
            player1.DisplayInventoryFromInventory();
            Store store = new Store(player1);
            DisplayBankBalance(player1.moneyBank.money);
            amountOfLemons = store.BuyLemons(player1);
            DisplayBankBalance(player1.moneyBank.money);
            amountOfCups = store.BuyCups(player1);
            DisplayBankBalance(player1.moneyBank.money);
            amountOfIce = store.BuyIce(player1);
            DisplayBankBalance(player1.moneyBank.money);
            amountOfSugar = store.BuySugar(player1);
            DisplayBankBalance(player1.moneyBank.money);
            player1.AddInventory(amountOfCups, amountOfIce, amountOfLemons, amountOfSugar);
            //check for 60 cups and math for if they can continue playing with cost of cups needed to get to 60 and moneybank.
            player1.SetRecipe();


        }

        public void DisplayBankBalance(double money)
        {
            Console.WriteLine("Your current bank balance is: $ " + money + ". Hit ENTER to continue.");
            Console.ReadLine();
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
