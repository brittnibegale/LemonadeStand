using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //string typeOfGame;
        //string multiplayerVersion;
        //string multiplayerPlayerNumber;
        int amountOfLemons;
        int amountOfSugar;
        int amountOfCups;
        int amountOfIce;
        string userInput;
        Player player1;
        //Player player2;
        //Player player3;
        //Player player4;
        public Game()
        {

        }
        public void StartGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand! This game lasts for a week if you can make it! Everyday has different weather, which will effect how many people buy your lemonade. You have the ability to buy items and change the recipe to optimize how many people buy your lemonade. Hit ENTER to continue.");
            //have a yes no here for database saving
            Console.ReadLine();
            player1 = new Human();
            Day day = new Day();
            MainMenu(player1, day);
            //Console.WriteLine("How would you like to play this game? In the single player mode you will only play against your self. In the multi player mode you can play against a computer or against upto 4 friends. \n Please, choose either single player or multi player.");
            //typeOfGame = Console.ReadLine().ToLower();
            //DetermineGameType(typeOfGame);
        }

        //public void DetermineGameType(string typeOfGame)
        //{
        //    while (true)
        //    {
        //        if (typeOfGame == "single" || typeOfGame == "single player" || typeOfGame == "singleplayer" || typeOfGame == "single player mode" || typeOfGame == "single mode")
        //        {
        //            player1 = new Human();
        //            MainMenu(player1);
        //            break;//change this if you want to play again
        // }
        //else if (typeOfGame == "multi" || typeOfGame == "multi player" || typeOfGame == "multiplayer" || typeOfGame == "multiplayer mode" || typeOfGame == "multi player mode")
        //{
        //    Console.WriteLine("Would you like to play against a computer or your friends? Please, choose computer or friends");
        //    multiplayerVersion = Console.ReadLine().ToLower();
        //    DetermineMultiplayerGame(multiplayerVersion);
        //}
        //        else
        //        {
        //            Console.WriteLine("Please type single player or multi player.");
        //            typeOfGame = Console.ReadLine().ToLower();
        //        }
        //    }
        //}

        //public void OnePlayerGame(Player player1)
        //{
        //    Day day1 = new Day();
        //    day1.Day1();
        //    player1.DisplayInventoryFromInventory();

        //    player1.AddInventory(amountOfCups, amountOfIce, amountOfLemons, amountOfSugar);
        //    //check for 60 cups and math for if they can continue playing with cost of cups needed to get to 60 and moneybank.
        //    player1.SetRecipe();


        //}
     

        public void MainMenu(Player player1, Day day)
        {
            Console.WriteLine("What would you like to do? Go to the store? See today's weather? See the inventory you currently have? Start game? Please enter store, weather, inventory, game");
            userInput = Console.ReadLine().ToLower();
            userInput = CheckMenuInput(userInput);
            switch (userInput)
            {
                case "store":
                    GoToStore(player1, day);

                    break;

                case "weather":

                    break;

                case "inventory":
                    ShowInventory(player1);
                    break;

                case "game":
                    GamePlay(player1, day);

                    break;

                default:
                    Console.WriteLine("Main menu failed. ");
                    Console.ReadLine();
                    break;
            }
        }

        public string CheckMenuInput(string userInput)
        {
            while (true)
            {
                if (userInput == "store" || userInput == "weather" || userInput == "inventory" || userInput == "game")
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please type store, weather, inventory, or game");
                    userInput = Console.ReadLine();
                }
            }

        }

        public void ShowInventory(Player player)
        {
            player.DisplayInventoryFromInventory();
        }
       
        public void GamePlay(Player player, Day day)
        {  
            player1.DisplayInventoryFromInventory();
            day.RemoveOneday();
            day.GetWeather();
            List<int> recipeList = player1.SetRecipe();
            day.SendRecipeToWeatherAndCustomer(recipeList);
        }

        public void GoToStore(Player player, Day day)
        {
            Store store = new Store(player);
            DisplayBankBalance(player.moneyBank.money);
            amountOfLemons = store.BuyLemons(player);
            DisplayBankBalance(player.moneyBank.money);
            amountOfCups = store.BuyCups(player);
            DisplayBankBalance(player.moneyBank.money);
            amountOfIce = store.BuyIce(player);
            DisplayBankBalance(player.moneyBank.money);
            amountOfSugar = store.BuySugar(player);
            DisplayBankBalance(player.moneyBank.money);
            player.AddInventory(amountOfCups, amountOfIce, amountOfLemons, amountOfSugar);
            MainMenu(player, day);
        }
        public void DisplayBankBalance(double money)
        {
            Console.WriteLine("Your current bank balance is: $ " + money + ". Hit ENTER to continue.");

            Console.ReadLine();
        }
        public int CheckForEnoughInventory(int items, int amountNeeded, Player player, Day day)
        {
            if (amountNeeded >= items)
            {
                return items;
            }
            else
            {
                Console.WriteLine("You need to have at least " + amountNeeded + "Please go to the store and buy more. Hit ENTER to go there.");
                Console.ReadLine();
                MainMenu(player, day);
                return items;
            }

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
