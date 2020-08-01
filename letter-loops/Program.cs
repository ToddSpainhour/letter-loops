using System;
using System.Collections.Generic;
using System.Globalization;

namespace letter_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make a console app that does something like this.");
            Console.WriteLine("\n");



            Console.WriteLine("If you entered 'abcd' the console should output 'A-Bb-Ccc-Dddd'");
            Console.WriteLine("\n");



            Console.WriteLine("Enter a short line of jibberish and hit 'Enter'.");
            var usersInput = Console.ReadLine();
            Console.WriteLine("\n");



            Console.WriteLine($"You entered '{usersInput}'.");
            Console.WriteLine("\n");



            Console.WriteLine("Now let\'s see if we can do the thing...");
            Console.WriteLine("\n");



            Console.WriteLine("Let's start by simply interating over each character you added. Hit enter when you're ready to proceed.");
            Console.WriteLine("\n");
           Console.ReadKey(true);




            foreach (char letter in usersInput)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("\n");



            Console.WriteLine("Now let's try it again but attempt to get the first letter to display once, the second twice, ect. Hit 'Enter' when you're ready.");
            Console.WriteLine("\n");
            Console.ReadKey(true);



            var counter = 0;
            List<string> commaSeperatedListOfStrings = new List<string>();


            foreach (char letter in usersInput)
            {
                counter += 1;
                string result = new string (letter, counter);
                commaSeperatedListOfStrings.Add(result);
               
                Console.WriteLine($"The 'result' variable returns: '{result}'");
                
                Console.WriteLine("\n");
            }

            Console.ReadKey();



            Console.WriteLine("All these variables were 'pushed' into a list where they are joined together using 'Join()'");
            Console.ReadKey();



            var combinedStrings = string.Join("-", commaSeperatedListOfStrings);

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;



            var uppercasedFirstLetterCombined = myTI.ToTitleCase(combinedStrings);
            Console.WriteLine("\n");



            Console.WriteLine($"Your 'combinedStrings' which contains all the variables joined together returns '{combinedStrings}'");
            Console.WriteLine("\n");



            Console.WriteLine("That's close but we need to get each forst letter to be uppercased.");
            Console.WriteLine("\n");



            Console.ReadKey();



            Console.WriteLine("After adding 'using System.Globalization' at the top of this file, we gained access to 'ToTitleCase' which capitalizes every first letter. ");
            Console.WriteLine("\n");



            Console.WriteLine($"Your 'uppercasedFirstLetterCombined' variable returns '{uppercasedFirstLetterCombined}'");
            Console.WriteLine("\n");



            Console.WriteLine("That's it!");





            Console.ReadKey();
        }
    }
}
