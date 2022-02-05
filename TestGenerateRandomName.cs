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

            List<string> testFirstNames;
            testFirstNames = new List<string>();

            // 2. Add a single first name to the list
            testFirstNames.Add("Jamie");

            // 3. Create a list of last names to test with:
            List<string> testLastNames;
            testLastNames = new List<string>();
            
            // 4. Add a single last name to the list
            testLastNames.Add("the Baller");

            // 5. Next, call the GenerateRandomName with the test lists:

            string testResult;
            testResult = Program.GenerateRandomName(testFirstNames, testLastNames);

            // 6. Since we have only 1 name in each list, the name generated should be "Jamie the Baller"

            string expected = "Jamie the Baller";

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
            // clear our lists for a new test case
            testFirstNames.Clear();
            testLastNames.Clear();

            // add one first name to testFirstNames
            testFirstNames.Add("Robbie");

            // add a bunch of lastNames to testLastName
            testLastNames.Add("Bjerre");
            testLastNames.Add("Wren");

            testResult = Program.GenerateRandomName(testFirstNames, testLastNames);

            string outcome0;
            string outcome1;

            outcome0 = "Robbie Bjerre";
            outcome1 = "Robbie Wren";

            if (testResult != outcome0 || testResult != outcome1)
            {
                Console.Error.WriteLine($"Failure: Expected {outcome0} or {outcome1} but the result was {testResult}.");
                return false;
            }

            testFirstNames.Clear();
            testLastNames.Clear();

            // add one first name to testFirstNames
            testFirstNames.Add("Robbie");
            testFirstNames.Add("Becket");

            // add one lastName to testLastName
            testLastNames.Add("Bjerre");
            

            testResult = Program.GenerateRandomName(testFirstNames, testLastNames);

            string outcome2;
            string outcome3;

            outcome2 = "Robbie Bjerre";
            outcome3 = "Becket Bjerre";

            if (testResult != outcome2 || testResult != outcome3)
            {
                Console.Error.WriteLine($"Failure: Expected {outcome2} or {outcome3} but the result was {testResult}.");
                return false;
            }

            testFirstNames.Clear();
            testLastNames.Clear();
            testResult = Program.GenerateRandomName(testFirstNames, testLastNames);
            expected = "Will Padian";

            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but the result was {testResult}.");
                return false;
            }

            // If all of the check are as expected, return true.
            return true;
        }
    }
}