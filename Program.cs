using System.Globalization;
using System.Text.RegularExpressions;
using MoneyMaker.Models;
using MoneyMaker.Utils;

namespace MoneyMaker;
class Program
{
    static void Main(string[] args)
    {
        Display.DisplayTitleAndRules();

        // Overal price of products
        Display.DisplayAmountToPay();
        string? inputToPay = Console.ReadLine();
        inputToPay = Validation.CheckInput(inputToPay);
        decimal amountToPay = Convert.ToDecimal(inputToPay);

        // Customer pays specified amount of money
        Display.DisplayCustomerPaid();
        string? inputPaid = Console.ReadLine();
        inputPaid = Validation.CheckInput(inputPaid);
        decimal amountPaid = Convert.ToDecimal(inputPaid);

        // Calculates how much change we have to give to the customer
        decimal amountToGive = amountPaid - amountToPay;
        amountToGive = Math.Round(amountToGive, 2);

        // #TODO MOVE TO MAIN LOGIC, REFACTOR INTO SMALLER PARTS
        // Find how many assets "fit" into an amount
        decimal howManyTwoHundredZlotychFits = Math.Floor(amountToGive / Constants.TwoHundredZlotych);
        // Find remainder using modulo and repeat the process with the rest of assets
        decimal remainder = amountToGive % Constants.TwoHundredZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyOneHundredZlotychFits = Math.Floor(Math.Round(remainder, 2) / Constants.OneHundredZlotych);
        remainder = remainder % Constants.OneHundredZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyFiftyZlotychFits = Math.Floor(Math.Round(remainder, 2) / Constants.FiftyZlotych);
        remainder = remainder % Constants.FiftyZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyTwnetyZlotychFits = Math.Floor(Math.Round(remainder, 2) / Constants.TwentyZlotych);
        remainder = remainder % Constants.TwentyZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyTenZlotychFits = Math.Floor(Math.Round(remainder, 2) / Constants.TenZlotych);
        remainder = remainder % Constants.TenZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyFivesFits = Math.Floor(Math.Round(remainder, 2) / Constants.FiveZlotych);
        remainder = remainder % Constants.FiveZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyTwosFits = Math.Floor(Math.Round(remainder, 2) / Constants.TwoZlotych);
        remainder = remainder % Constants.TwoZlotych;
        remainder = Math.Round(remainder, 2);

        decimal howManyOnesFits = Math.Floor(Math.Round(remainder, 2) / Constants.OneZloty);
        remainder = remainder % Constants.OneZloty;
        remainder = Math.Round(remainder, 2);

        decimal howManyFiftiesGroszyFits = Math.Floor(remainder / Constants.FiftyGroszy);
        remainder = remainder % Constants.FiftyGroszy;
        remainder = Math.Round(remainder, 2);

        decimal howManyTwentiesGroszyFits = Math.Floor(remainder / Constants.TwentyGroszy);
        remainder = remainder % Constants.TwentyGroszy;
        remainder = Math.Round(remainder, 2);

        decimal howManyTensGroszyFits = Math.Floor(remainder / Constants.TenGroszy);
        remainder = remainder % Constants.TenGroszy;
        remainder = Math.Round(remainder, 2);

        decimal howManyFiveGroszyFits = Math.Floor(remainder / Constants.FiveGroszy);
        remainder = remainder % Constants.FiveGroszy;
        remainder = Math.Round(remainder, 2);

        decimal howManyTwoGroszyFits = Math.Floor(remainder / Constants.TwoGroszy);
        remainder = remainder % Constants.TwoGroszy;
        remainder = Math.Ceiling(remainder);

        Display.DisplayChangeToGive(amountToGive);
        Console.WriteLine($"{howManyTwoHundredZlotychFits} - 200 zł");
        Console.WriteLine($"{howManyOneHundredZlotychFits} - 100 zł");
        Console.WriteLine($"{howManyFiftyZlotychFits} - 50 zł");
        Console.WriteLine($"{howManyTwnetyZlotychFits} - 20 zł");
        Console.WriteLine($"{howManyTenZlotychFits} - 10 zł");
        Console.WriteLine($"{howManyFivesFits} - 5 zł");
        Console.WriteLine($"{howManyTwosFits} - 2 zł");
        Console.WriteLine($"{howManyOnesFits} - 1 zł");
        Console.WriteLine($"{howManyFiftiesGroszyFits} - 0,50 gr");
        Console.WriteLine($"{howManyTwentiesGroszyFits} - 0,20 gr");
        Console.WriteLine($"{howManyTensGroszyFits} - 0,10 gr");
        Console.WriteLine($"{howManyFiveGroszyFits} - 0,05 gr");
        Console.WriteLine($"{howManyTwoGroszyFits} - 0,02 gr");
        Console.WriteLine($"{remainder} - 0,01 gr");


        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

    }



}

