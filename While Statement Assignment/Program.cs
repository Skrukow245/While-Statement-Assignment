using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Statement_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number 1-5");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 5;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number 1-10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                        Console.WriteLine("Guess a number 1-10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess a number 1-10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. Try again.");
                        Console.WriteLine("Guess a number 1-10");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. That is correct!.");
                        isGuessed = true;
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
