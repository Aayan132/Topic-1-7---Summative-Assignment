using System.ComponentModel;
using System.ComponentModel.Design;

namespace Topic_1_7___Summative_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            //string userschoice;
            string rulesoption;
            double bank = 100;
            double bet;
            string computerchoice;
            bool done;
            int win = 0;
            int losses = 0;
            int ties = 0;

            DrawRock();


            Console.WriteLine("Welcome to the Rock Paper Scissors Casino");
            Console.WriteLine();
            Console.WriteLine("You start with $100");
            Console.WriteLine("Do you want to see the rules? (type Yes or No)");

            rulesoption = Console.ReadLine();

            if (rulesoption == "yes")
            {
                Console.WriteLine();
                Console.WriteLine("1: Enter a bet");
                Console.WriteLine("2: Choose Rock, Paper or Scissors");
                Console.WriteLine("3: Rock beats Scissors");
                Console.WriteLine("4: Scissors beats Papper");
                Console.WriteLine("5: Papper beats Rock");
                Console.WriteLine("6: If you win you win the amount you bet");
                Console.WriteLine("7: If you lose you lose the money you bet");
                Console.WriteLine("8: If you tie your money stays the same");
                Console.WriteLine();

            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Okay lets begin! ");
                Console.WriteLine();
            }


            done = false;
            while (!done)
            {
                Console.WriteLine("You have $" + bank);
                Console.WriteLine("Enter your bet!");
                double.TryParse(Console.ReadLine(), out bet);
                Console.WriteLine();

                if (bet > bank)
                {
                    Console.WriteLine("You can't bet more than you have!");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Choose Rock, Paper or Scissors (or quit)");
                string userschoice = Console.ReadLine();
                userschoice = userschoice.ToLower();

                if (userschoice == "quit")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for playing!");
                    Console.WriteLine("Game over");
                    Console.WriteLine("Final Bank " + bank);
                    Console.WriteLine("Wins " + win);
                    Console.WriteLine("Losses " + losses);
                    Console.WriteLine("Ties " + ties);
                    break;
                }

                int number = random.Next(1, 4);

                if (number == 1)
                {
                    computerchoice = "rock";
                }

                else if (number == 2)
                {
                    computerchoice = "paper";
                }

                else
                {
                    computerchoice = "scissors";
                }

                Console.WriteLine();
                Console.WriteLine("You chose " + userschoice);
                Console.WriteLine("The compuer chose " + computerchoice);
                Console.WriteLine();

                if (userschoice == computerchoice)
                {
                    Console.WriteLine("You picked the same thing TIE");
                    ties = ties + 1;
                }

                else if (userschoice == "rock" && computerchoice == "scissors" 
                    || userschoice == "paper" && computerchoice == "rock" 
                    || userschoice == "scissors" && computerchoice == "paper")
                {
                    Console.WriteLine("you win!");
                    win = win + 1;
                    bank = bank + bet;
                }

                else
                {
                    Console.WriteLine("You lose😔");
                    losses = losses + 1;
                    bank = bank - bet;
                }

                Console.WriteLine();
                Console.WriteLine("Wins " + win);
                Console.WriteLine("Losses " + losses);
                Console.WriteLine("Ties " + ties);
                Console.WriteLine();

                if (bank <= 0)
                {
                    Console.WriteLine("You ran out of money");
                    done = true;
                }



            }
        }
        public static void DrawRock()
        {
            Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)"
);


        }

    }
}



