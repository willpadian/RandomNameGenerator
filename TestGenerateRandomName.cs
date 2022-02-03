using System;
using System.Collections.Generic;
using System.IO;

namespace RandomNameGenerator
{
    class TestGenerateRandomName
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-03):
            // This method is a little tricky to test because it uses a random number generator.
            // But, we can still test a few things:

            // 1. Start by creating a list of first names to test with:

            List<string> testFirstNames = new List<string>();

            // 2. Add a single first name to the list
            testFirstNames.Add("Jenkins");

            // 3. Create a list of last names to test with:
            List<string> testLastNames = new List<string>();
            
            // 4. Add a single last name to the list
            testLastNames.Add("the Baller");

            // 5. Next, call the GenerateRandomName with the test lists:

            string testResult = Program.GenerateRandomName(testFirstNames, testLastNames);

            // 6. Since we have only 1 name in each list, the name generated should be "Jenkins the Baller"

            string expected = "Jenkins the Baller";

            // 7. Check if the testResult is not equal to the expected result

            if (testResult != expected)
            {
                // 8. If it is not equal, this means the method did not work as expected
                Console.Error.WriteLine($"Failure: Expected {expected} but the result was {testResult}.");
                // 9. Return false (fail)
                return false;
            }


            // TODO(jcollard 2022-02-03): Here are a few more tests you should write:
            // 1. A list with 1 first name and many last names (check that the string StartsWith the first name).

            testResult.StartsWith("Jenkins");

            // 2. A list with many first names and only 1 last name (check the string EndsWith the last name).

            testResult.EndsWith("the Baller");

            
            // If all of the check are as expected, return true.
            return false;
        }
    }
}