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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" __        __   _                            _          __  __         _____           _             \r\n \\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___   |  \\/  |       / ____|         (_)            \r\n  \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\  | \\  / |_   _ | |     __ _ ___ _ _ __   ___  \r\n   \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |\\/| | | | || |    / _` / __| | '_ \\ / _ \\ \r\n    \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  |_|  |_| |_| |_| |___| (_| \\__ \\ | | | | (_) |\r\n                                                             \\_____\\__,_| \\_____\\__,_|___/_|_| |_|\\___/ ");
            Console.WriteLine();
            Console.WriteLine("You start with $100");
            Console.WriteLine("Do you want to see the rules? (type Yes or No)");
            Console.ResetColor();

            rulesoption = Console.ReadLine();

            if (rulesoption == "yes" || rulesoption == "y" || rulesoption == "yeah" || rulesoption == "sure" || rulesoption == "yea")
            {
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("1: Enter a bet");
                Console.WriteLine("2: Choose Rock, Paper or Scissors");
                Console.WriteLine("3: Rock beats Scissors");
                Console.WriteLine("4: Scissors beats Papper");
                Console.WriteLine("5: Papper beats Rock");
                Console.WriteLine("6: If you win you win the amount you bet");
                Console.WriteLine("7: If you lose you lose the money you bet");
                Console.WriteLine("8: If you tie your money stays the same");
                Console.ResetColor();
                Console.WriteLine();

            }

            else
            {
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Okay lets begin! ");
                Console.ResetColor();
                Console.WriteLine();
            }


            done = false;
            while (!done)
            {
                Console.ForegroundColor=ConsoleColor.Yellow;
                Console.WriteLine("You have $" + bank);
                Console.WriteLine("Enter your bet!");
                Console.ResetColor();
                double.TryParse(Console.ReadLine(), out bet);
                Console.WriteLine();

                if (bet > bank || bet <= 0)
                {
                    Console.WriteLine("You can't bet more or less than you have!");
                    Console.WriteLine();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose Rock, Paper or Scissors (or quit)");
                Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You choose: ");
                Console.ResetColor();
                Console.WriteLine();

                if (userschoice == "rock" || userschoice == "r")
                {
                    DrawRock();
                }

                else if (userschoice == "paper" || userschoice == "p")
                {
                    Drawpaper();
                }
                else if (userschoice == "scissors" || userschoice == "s")
                {
                    Drawscissors();
                }

                Console.WriteLine();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("The computer choose: ");
                Console.ResetColor();
                Console.WriteLine();

                if (computerchoice == "rock")
                {
                    DrawRock();
                }

                else if (computerchoice == "paper")
                {
                    Drawpaper();
                }
                else if (computerchoice == "scissors")
                {
                    Drawscissors();
                }

                if (userschoice == computerchoice)
                {
                    Console.WriteLine();
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("You picked the same thing TIE");
                    Console.ResetColor();
                    Console.WriteLine();
                    ties = ties + 1;
                }

                else if (userschoice == "rock" || userschoice == "r" && computerchoice == "scissors"
                    || userschoice == "paper" || userschoice == "p" && computerchoice == "rock"
                    || userschoice == "scissors" || userschoice == "s" && computerchoice == "paper")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("you win!");
                    Console.ResetColor();
                    win = win + 1;
                    bank = bank + bet;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("You lose :(");
                    Console.ResetColor();
                    losses = losses + 1;
                    bank = bank - bet;
                }

                Console.WriteLine();
                Console.WriteLine("Wins " + win);
                Console.WriteLine("Losses " + losses);
                Console.WriteLine("Ties " + ties);
                Console.WriteLine();

                Console.WriteLine("please ENTER to play the next round!");
                Console.ReadLine();
                Console.Clear();

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

     public static void Drawpaper()
        {
            Console.WriteLine(@"
    _______
---'   ____)______
          ________)
          _________)
         _________)
---.____________)"
);

        }

    public static void Drawscissors()
        {
            Console.WriteLine(@"
    _______
---'   ____)_____
          _______)
       ___________)
      (____)
---.__(___)"
);

        }
    }
}



