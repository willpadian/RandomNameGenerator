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


            return false;
        }
    }
}