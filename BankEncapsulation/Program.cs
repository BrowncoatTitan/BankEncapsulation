namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
           BankAccount account = new BankAccount();
            bool atATM = false;
            while (!atATM)
            {
            Console.WriteLine("Hello! Thank you for banking with us! Please tell me what you want to do.");
            Console.WriteLine("Would you like to make a deposit or check you balance?");
            Console.WriteLine("Please type end when you are done to exit.");
            string userInput = Console.ReadLine();
            userInput.ToLower();
                if (userInput is "balance")
                {
                    double balance = account.GetBalance();
                    Console.WriteLine($"${balance}");
                }
                else if (userInput is "check balance")
                {
                    double balance = account.GetBalance();
                    Console.WriteLine($"${balance}");
                }
                else if (userInput is "my balance")
                {
                    double balance = account.GetBalance();
                    Console.WriteLine($"${balance}");
                }
                else if (userInput is "check my balance")
                {
                    double balance = account.GetBalance();
                    Console.WriteLine($"${balance}");
                }
                else if (userInput is "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    double deposit;
                    double.TryParse(Console.ReadLine(), out deposit);
                    account.Deposit(deposit);
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}.");
                }
                else if (userInput is "make a deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    double deposit;
                    double.TryParse(Console.ReadLine(), out deposit);
                    account.Deposit(deposit);
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}.");
                }
                else if (userInput is "end")
                {
                    atATM = true;
                    Console.WriteLine("Thank you for stopping by!");
                }
                else
                {
                    Console.WriteLine("I'm sorry. I did not understand that request.");
                    Console.WriteLine("Please try again.");
                }
            }

        }
    }
}
