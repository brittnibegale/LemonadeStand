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
        double amountOfLemons;
        double amountOfSugar;
        double amountOfCups;
        double amountOfIce;
        double countOfDaysCustomers;
        int daysLeftInGame;
        double pitchers;
        double costOfCup;
        double dailyProfit;
        string userInput;
        double helpedCustomers;
        Player player1;
        Day day;
        //Player player2;
        //Player player3;
        //Player player4;
        public Game()
        {

        }
        public void StartGame()
        {
            
            Console.WriteLine("Welcome to Lemonade Stand! This game lasts for a week if you can make it! \n Everyday has different weather, which will effect how many people buy your lemonade.\n You have the ability to buy items and change the recipe to optimize how many people buy your lemonade.\n Hit ENTER to continue.");
            Console.ReadLine();
            player1 = new Human();
            day = new Day();
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
            Console.Clear();
            Console.WriteLine("What would you like to do? Go to the store? See today's weather? See the inventory you currently have? Start game?\n Please enter store, weather, inventory, game");
            userInput = Console.ReadLine().ToLower();
            userInput = CheckMenuInput(userInput);
            switch (userInput)
            {
                case "store":
                    GoToStore(player1, day);
                    Console.Clear();
                    break;

                case "weather":
                    DisplayWeather(player1, day);
                    Console.Clear();
                    break;

                case "inventory":
                    ShowInventory(player1, day);
                    Console.Clear();
                    break;

                case "game":
                    GamePlay(player1, day);
                    Console.Clear();
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

        public void ShowInventory(Player player, Day day)
        {
            player.DisplayInventoryFromInventory();
            MainMenu(player, day);
        }

        public void DisplayWeather(Player player, Day day)
        {
            day.GetWeather();
            MainMenu(player, day);
        }

        public void GamePlay(Player player, Day day)
        {
            //load game here
            player1.DisplayInventoryFromInventory();
            day.GetWeather();
            List<double> recipeList = player1.SetRecipe();
            costOfCup = player1.SetCostPerCup();
            Console.Clear();
            countOfDaysCustomers = day.SendRecipeToWeatherAndCustomer(recipeList);
            pitchers = player.CheckForPitcherAmount();
            FindHowManyCustomers();
            player1.CalculateInventoryLoss(pitchers);
            CalculateDaysProfit();
            CalculateDaysGross();
            CheckForEnoughMoneyToContinue();
            daysLeftInGame = day.RemoveOneday();
            CheckDaysLeft();
            Console.WriteLine("You have " + day.updatedDayCount + " days left in the game. \n Hit ENTER to continue.");
            Console.ReadLine();
            //Save game here
            MainMenu(player, day);
        }

        public void GoToStore(Player player, Day day)
        {
            Store store = new Store(player);
            DisplayBankBalance(player.moneyBank.money);
            amountOfLemons = store.BuyLemons(player);
            Console.Clear();
            DisplayBankBalance(player.moneyBank.money);
            amountOfCups = store.BuyCups(player);
            Console.Clear();
            DisplayBankBalance(player.moneyBank.money);
            amountOfIce = store.BuyIce(player);
            Console.Clear();
            DisplayBankBalance(player.moneyBank.money);
            amountOfSugar = store.BuySugar(player);
            Console.Clear();
            DisplayBankBalance(player.moneyBank.money);
            player.AddInventory(amountOfCups, amountOfIce, amountOfLemons, amountOfSugar);
            player.DisplayInventoryFromInventory();
            CheckForEnoughInventory(player.inventoryList.lemons.Count(), 1);
            CheckForEnoughInventory(player.inventoryList.sugar.Count(), 1);
            CheckForEnoughInventory(player.inventoryList.ice.Count(), 1);
            CheckForEnoughInventory(player.inventoryList.cup.Count(), 6);
            MainMenu(player, day);
        }
        public void DisplayBankBalance(double money)
        {
            Console.WriteLine("Your current bank balance is: $ " + money + ". Hit ENTER to continue.");
            Console.ReadLine();
        }
       
        public void CalculateDaysProfit()
        {
            dailyProfit = costOfCup * helpedCustomers;
        }
        public void CalculateDaysGross()
        {
            player1.moneyBank.money = dailyProfit + player1.moneyBank.money;
        }
        public void CheckDaysLeft()
        {
            if (daysLeftInGame >= 1)
            {
                Console.WriteLine("Today you made $ " + dailyProfit + " and sold to " + helpedCustomers + " customers.");
                Console.ReadLine();
            }
            else if (daysLeftInGame == 0)
            {
               string weekIsOver = "I hope you enjoyed playing Lemonade Stand! Your weekly profit was $ " + dailyProfit + ".";
               EndGameRemarks(weekIsOver);
            }
        }

        public void FindHowManyCustomers()
        {
            double possibleHelpedCustomers = 6 * pitchers;
            if (possibleHelpedCustomers >= countOfDaysCustomers)
            {
                helpedCustomers = countOfDaysCustomers;
            }
            else if (possibleHelpedCustomers < countOfDaysCustomers)
            {
                helpedCustomers = possibleHelpedCustomers;
            }
        }

        public void CheckForEnoughMoneyToContinue()
        {
            if (player1.moneyBank.money <= 0)
            {
                string moneyLost = "Thank you for playing. You do not have enough money to continue.";
                EndGameRemarks(moneyLost);
            }
            else
            {
                DisplayBankBalance(player1.moneyBank.money);
            }
        }

        public void CheckForEnoughInventory(int listCount, double amountNeeded)
        {
            if(listCount < amountNeeded)
            {
                Console.WriteLine("You do not have enough inventory to complete one game.\n You need: \n 1 lemon \n 1 sugar packet \n 1 ice cube \n 6 cups \n You are getting sent back to the store.");
                Console.ReadLine();
                GoToStore(player1, day);
            }
            
        }
        public void EndGameRemarks(string endComments)
        {
            Console.WriteLine(endComments);
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
