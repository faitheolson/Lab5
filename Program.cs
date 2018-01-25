using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Repeat = true;
            int Counter = 1;
            
            while (Repeat == true)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!!! Would you like to roll the dice? (y/n)");
                string Input = (Console.ReadLine());
                if (Input == "y" || Input == "Y")
                {
                    RollDice(Counter);
                    Counter++;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    Repeat = false;
                }
            }
        }

        public static void RollDice(int Counter)
        {
            
            Console.WriteLine("How many sides should each die have?");
            int DieSides = int.Parse(Console.ReadLine());

            int Die1 = new Random().Next(1, DieSides);
            System.Threading.Thread.Sleep(250);
            int Die2 = new Random().Next(1, DieSides);

            Console.WriteLine($"Roll #{Counter}: {Die1} & {Die2}");
        }
    }
}
