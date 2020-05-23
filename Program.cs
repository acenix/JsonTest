using System;
using System.Collections.Generic;

namespace JsonTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            string val;
            Console.Write("Enter File Path: ");
            val = Console.ReadLine();

            Read readClass       = new Read();
            List<string> matched = readClass.ReadFile(val);

            if (matched == null)
            {
                Console.WriteLine("Invalid Files...");
            }
            else
            {
                foreach (string match in matched)
                {
                    Console.WriteLine(match);
                }
            }
#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }


    }
}
