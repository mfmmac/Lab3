using System;
using System.Xml.Serialization;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            bool userContinue;

            do
            {
                Console.WriteLine("{0} please enter a number between 1 and 100. \n", name);
                bool valid = double.TryParse(Console.ReadLine(), out double userNum);

                int rangeBegin = 1;
                int rangeEnd = 100;

                if (userNum >= rangeBegin && userNum <= rangeEnd)
                {
                    if (userNum % 2 == 0 && userNum <= 25)
                    {
                        Console.WriteLine("The number is even and less than 25.");
                    }
                    else if (userNum % 2 == 0 && userNum >= 25 && userNum <= 60)
                    {
                        Console.WriteLine("The number is even.");
                    }
                    else if (userNum % 2 == 0 && userNum >= 60)
                    {
                        Console.WriteLine("{0} is even. \n", userNum);
                    }
                    else if (userNum % 2 != 0)
                    {
                        Console.WriteLine("{0} is odd. \n", userNum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please input a number between 1 and 100");
                    }
                }
                else
                {
                    Console.WriteLine("{0} please enter a number between 1 and 100. \n", name);

                }

                Console.WriteLine("{0} do you want to continue? (Y/N) \n", name);
                var contInput = Console.ReadLine().ToUpper();
                if (contInput == "Y")
                {
                    userContinue = true;
                }
                else if (contInput == "N")
                {
                    userContinue = false;
                    Console.WriteLine("Goodbye {0}. \n", name);
                }
                else
                {
                    Console.WriteLine("Invalid entry please enter (Y/N).");
                    var contInput2 = Console.ReadLine();
                    userContinue = true;
                }
            }
            while (userContinue);
        }
    }
}
