using System.ComponentModel.Design;

namespace Topic_1_7___Summative_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string userschoice = "";
            string computerschoice = "";
            string rulesoption = "";
            int bank = 100;
            int bet = 0;
            int win = 0;
            int losses = 0;
            int ties = 0;


            Console.WriteLine("Welcome to the Rock Paper Scissors Casino");
            Console.WriteLine("You start with $100");
            Console.WriteLine("Do you want to see the rules?");
            rulesoption = Console.ReadLine();

            bool done = false;
            while (!done) ;

            if (rulesoption != "yes")
            {
                Console.WriteLine("1: Enter a bet");
                Console.WriteLine("2: Choose Rock, Papper or Scissors");
                Console.WriteLine("3: Rock beats Scissors");
                Console.WriteLine("4: Scissors beats Papper");
                Console.WriteLine("5: Papper beats Rock");
                Console.WriteLine("6: If you win you double your money");
                Console.WriteLine("7: If you lose you lose your money");
                Console.WriteLine("8: If you tie your money stays the same");
            }

            if (rulesoption == "no")
            {
                Console.WriteLine("How much would you like to bet?");

            }




        }
    }
}
