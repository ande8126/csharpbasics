//importing a namespace 
using System;
//get rid of the "Console" in "Console.Write"
using static System.Console;

namespace formatting
{
    class Program
    {
        static void Main(string[] args)
        {

            //formating strings
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
            //formatting w/interpolated strings
            //strings with a $ at the begining can use curlies to output value of variable
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
            //formatted strings
            //format with a ':' followed by respective symbol so..
            // :N0 means format with thousand separators and no decimal place
            // :C means currency
            //Syntax of formated value:
            // { index [, alignment ] [ : formatString ] }
            string applesText = "apples";
            int applesCount = 1234;
            string bananasText = "bananas";
            int bananasCount = 56789;
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount);
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount);
            //readline
            Console.WriteLine("Type your first name and press ENTER:");
            string firstName = Console.ReadLine();
            Console.Write("Type your age and press ENTER: ");
            string age = Console.ReadLine();    
            Console.Write($"Hello {firstName}, you look good for {age}.");
            //key inputs
            //NOTE THAT I ADDED SYSTEM.CONSOLE ABOVE...
            Write("Press any key combination:");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );
            
        }
    }
}

