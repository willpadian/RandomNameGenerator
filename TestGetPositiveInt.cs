using System;
using System.IO;

namespace RandomNameGenerator
{
    class TestGetPositiveInt
    {
        public static bool RunTest()
        {

            // TODO(jcollard 2022-02-03): You should write instructions for the user testing this method.

            // 1. Explain what the tester should see

            Console.WriteLine("Testing GetPositiveInt.");
            Console.WriteLine("When it runs, you should see the prompt 'How many names?'");

            // 2. Give the user instructions to test invalid inputs:

            Console.WriteLine("1. Enter '-5'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("2. Enter 'banana'. This is an invalid input. You should see 'Invalid'.");

            // 3. Give the user instructions to test a valid input:

            Console.WriteLine("3. Enter '17'. This is a valid input.");

            // 4. Call the method with an argument that will generate the specified prompt:
            int result = Program.GetPositiveInt("How many names?");

            // 5. Assume the user follows the instructions.
            // 6. Check if the result is not what we expected
            if (result != 17) 
            {
                // 7. If the result is not what we expected, we tell the tester that the result was not correct
                Console.Error.WriteLine($"The result should have been 17 but was {result}");

                // 8. Then we return false (fail)
                return false; 
            }

            // TODO(jcollard 2022-02-03): Write at least 2 more tests following the steps above.
            // What are some more invalid and valid inputs the user can try?

            

            // TODO(jcollard 2022-02-03): Finally, if all of the results are as expected, return true (pass)
            return false;
        }
    }
}