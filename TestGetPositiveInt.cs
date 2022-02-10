using System;
using System.IO;

namespace RandomNameGenerator
{
    class TestGetPositiveInt
    {
        public static bool RunTest()
        {
            // int result = Program.GetPositiveInt("17");
            // if (result != 17)
            // {
            //     Console.Error.WriteLine("The first file should have been 17");
            //     return false;
            // }

            // int result2 = Program.GetPositiveInt("-5");
            // Console.Error.WriteLine("You must enter a positive integer");
            // return false;

            // int result3 = Program.GetPositiveInt("7.6");
            // Console.Error.WriteLine("You must enter a positive integer");
            // return false;

            // int result4 = Program.GetPositiveInt("0");
            // Console.Error.WriteLine("You must enter a positive integer");
            // return null;


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

            Console.WriteLine("When it runs, you should see the prompt 'What is your age?'");
            Console.WriteLine("1. Enter '0.9'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("2. Enter '0'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("3. Enter '+'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("4. Enter '27'. This is a valid input.");


            result = Program.GetPositiveInt("What is your age?");
            if (result != 27)
            {
                Console.Error.WriteLine($"The result should have been 27S but was {result}");
                return false;
            }
            
            Console.WriteLine("When it runs, you should see the prompt 'What is your age?'");
            Console.WriteLine("1. Enter '238.373'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("2. Enter '&&&'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("3. Enter '[]odm'. This is an invalid input. You should see 'Invalid'.");
            Console.WriteLine("4. Enter '19'. This is a valid input.");
            
            // TODO(jcollard 2022-02-10): Don't forget to call your method here

            if (result != 19)
            {
                Console.Error.WriteLine($"The result should have been 19 but was {result}");
                return false;
            }

            // TODO(jcollard 2022-02-03): Finally, if all of the results are as expected, return true (pass)
            return true;
        }
    }
}