using System;
using System.IO;

namespace RandomNameGenerator
{
    class TestGetPositiveInt
    {
        public static bool RunTest()
        {
            int result = Program.GetPositiveInt("17");
            if (result != 17)
            {
                Console.Error.WriteLine("The first file should have been 17");
                return false;
            }

            int result2 = Program.GetPositiveInt("-5");
            Console.Error.WriteLine("You must enter a positive integer");
            return false;

            int result3 = Program.GetPositiveInt("7.6");
            Console.Error.WriteLine("You must enter a positive integer");
            return false;

            int result4 = Program.GetPositiveInt("0");
            Console.Error.WriteLine("You must enter a positive integer");
            return null;


            return false;
        }
    }
}