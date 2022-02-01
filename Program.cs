//TODO(jcollard 2022-02-01): You need to get started on Part 2.2
using System;
using System.Collections.Generic;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Given a prompt to show to the user, displays the prompt then reads input from the keyboard until the user enters a positive number. If the user enters a non-positive number, this method displays an error message and prompts the user again.
        /// </summary>
        /// <param name="prompt">The prompt to show the user</param>
        /// <returns>the number the player chose</returns>
        public static int GetPositiveInt(string prompt)
        {
            // 1.Validate the prompt is a string
            // 2.Display the prompt
            // 3.Read input from the user
            // 4.If the user entered a non-positive number,
            // 5.Display an error message
            // 6.Go to step 2
            // 7.Otherwise, return the users input
            return -1;
        }

        /// <summary>
        /// Given a list of first, middle, and last names, generate a random name using one entry from each list.
        /// </summary>
        /// <param name="first">generates the list of first names</param>
        /// <param name="middle">generates the list of middle names</param>
        /// <returns>null</returns>
        public static string GenerateRandomName(List<string> first, List<string> middle)
        {
            //Create a random number generator
            //Generate a random number, firstIndex, between 0 and firstNames.Count
            //Generate a random number, midIndex, between 0 and midNames.Count
            //Generate a random number, lastIndex, between 0 and lastNames.Count
            //Combine the names together
            //firstNames[firstIndex] + " " + midNames[midIndex] + " " + lastNames[lastIndex];
            //Return the name
            return null;
        }

    }
}
