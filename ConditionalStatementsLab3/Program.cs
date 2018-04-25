using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name! ");
            var name = Console.ReadLine();

            while (true)
            {
                Console.Write(name + ", please enter an integer from 1 to 100! ");
                string num = (Console.ReadLine());
                bool statement = int.TryParse(num, out int num2);

                if(statement)
                {
                    if (num2 < 1 || num2 > 100)
                    {
                        Console.WriteLine("Invalid number, please try again!");
                    }
                    else if (num2 % 2 == 0 && num2 >= 60)
                    {
                        Console.WriteLine($"{num2} is even!");
                    }

                    else if (num2 % 2 == 0 && num2 >= 26 && num2 <= 60)
                    {
                        Console.WriteLine($"{num2} is even!");
                    }
                    else if (num2 % 2 == 0 && num2 >= 2 && num2 <= 25)
                    {
                        Console.WriteLine($"{num2} is even and less than 25");
                    }
                    else
                    {
                        Console.WriteLine($"{num2} is odd!");
                    }

                    while (true) 
                    {
                        Console.Write("Do you want to try another number [Y/N]?");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                            break; // Exit the inner while-loop and continue in the outer while loop.
                        if (answer == "N")
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("That is an invalid input!");
                }
            }
        }
    }
}
