using System;
using System.Text.RegularExpressions;

namespace MoneyMaker.Utils
{
    public static class Validation
    {
        static Regex RegexCheck = new Regex(@"-?\d+(?:\.\d+)?");

        public static string CheckInput(string? input)
        {
            if (input == "Q")
            {
                Environment.Exit(0);
            }
            while (string.IsNullOrEmpty(input) || !RegexCheck.IsMatch(input))
            {
                Display.DisplayWrongInput(input);
                input = Console.ReadLine();
                
            }
            return input;
            
            
        }
    }
}

