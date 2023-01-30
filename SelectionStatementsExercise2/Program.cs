namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "history":
                    Console.WriteLine("That's the best subject, no debate.");
                    break;
                case "math":
                    Console.WriteLine("Math is terrible.");
                    break;
                case "phys ed":
                case "gym":
                    Console.WriteLine("Only other acceptable answer.");
                    break;
                case "english":
                    Console.WriteLine("This one is the worst and you're definitely a nerd.");
                    break;
                
                default:
                    Console.WriteLine("I've never heard of this one.");
                    break;


            }
        }
    }
}