using System;
namespace MoneyMaker.Utils
{
    public static class Display
    {
        public static void DisplayTitleAndRules()
        {
            var logo = new[]
            {
                  @" /-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-\ ",
                  @" $                                                      _                  $",
                  @" $    /\/\    ___   _ __    ___  _   _     /\/\    __ _ | | __ ___  _ __   $",
                  @" $   /    \  / _ \ | '_ \  / _ \| | | |   /    \  / _` || |/ // _ \| '__|  $",
                  @" $  / /\/\ \| (_) || | | ||  __/| |_| |  / /\/\ \| (_| ||   <|  __/| |     $",
                  @" $  \/    \/ \___/ |_| |_| \___| \__, |  \/    \/ \__,_||_|\_\\___||_|     $",
                  @" $                                __| |                                    $",
                  @" \-$-$-$-$-$-$-$-$-$-$-$-$-$-\  |___/         made by Piotr Palacz         $",
                  @"                             $                                             $",                                   
                  @"                             \-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-$-/",
            };
            foreach(string line in logo)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\nThis project is made by Piotr Palacz based on Codecademy tutorial \"Money Maker\"");
            Console.WriteLine("Please provide cost of product and amount the customer gave you, and Money Maker calculates\n" +
                "change and what kinds of paper and coins you should give him back. Simply but useful.\n" +
                "If you want to quit please type \"Q\"\n");

        }

        public static void DisplayAmountToPay()
        {
            Console.Write("Product cost in PLN: ");
        }

        public static void DisplayCustomerPaid()
        {
            Console.Write("Customer paid: ");
        }

        public static void DisplayChangeToGive(decimal amountToGive)
        {
            Console.WriteLine($"The change is {amountToGive}");
        }

        public static void DisplayWrongInput(string value)
        {
            Console.Write($"Incorrect value: {value}! Type price format: \"XX.XX\" in PLN: ");
            
        }
    }
}

