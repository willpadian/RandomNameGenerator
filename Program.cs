//TODO(jcollard 2022-02-01): You need to get started on Part 2.2
using System;
using System.Collections.Generic;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // Exits the program
            }
        }
        public static void TestAll()
        {
            bool testGenerateRandomName = TestGenerateRandomName.RunTest();
            Console.WriteLine($"Test GenerateRandomName(filename): {testGenerateRandomName}");

            bool testGetPositiveInt = TestGetPositiveInt.RunTest();
            Console.WriteLine($"Test GetPositiveInt(filename): {testGetPositiveInt}");
        }

        /// <summary>
        /// Given a prompt to show to the user, displays the prompt then reads input from the keyboard until the user enters a positive number. If the user enters a non-positive number, this method displays an error message and prompts the user again.
        /// </summary>
        /// <param name="prompt">The prompt to show the user</param>
        /// <returns>the number the player chose</returns>
        public static int GetPositiveInt(string prompt)
        {
            int userChoice;
            // 1.Validate the prompt is a string
            do
            {
                // 2.Display the prompt
                Console.Write("Enter a number that is greater than 0:");
                // 3.Read input from the user
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);
                // 4.If the user entered a non-positive number,
                if (isANumber == false)
                {
                    // 5.Display an error message
                    Console.Error.WriteLine("You did not enter a number.");
                }
                else if (userChoice <= 0)
                {
                    Console.WriteLine("That number is not greater than 0.");
                }
            }
            // 6.Go to step 2
            while (userChoice <= 0);
            // 7.Otherwise, return the users input
            return userChoice;
        }

        /// <summary>
        /// Given a list of first and last names, generate a random name using one entry from each list.
        /// </summary>
        /// <param name="first">the list of first names</param>
        /// <param name="last">the list of last names</param>
        /// <returns>a random first and random last name combined into a single name</returns>



        public static string GenerateRandomName(List<string> firstNames, List<string> lastNames)
        {
            //Create a random number generator
            Random generator = new Random();
            //Generate a random number, firstIndex, between 0 and firstNames.Count
            int firstIndex = generator.Next(0, firstNames.Count);
            //Generate a random number, lastIndex, between 0 and lastNames.Count
            int secondIndex = generator.Next(0, lastNames.Count);
            //Combine the names together
            string randomName = firstNames[firstIndex] + " " + lastNames[secondIndex];
            //firstNames[firstIndex] + " " + midNames[midIndex] + " " + lastNames[lastIndex];
            //Return the name
            return randomName;
        }

    }
}
