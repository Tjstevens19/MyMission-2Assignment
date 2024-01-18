using DiceRollerNamespace;
public class Program
{
    private static void Main(string[] args)
    {
        // Print a welcome message to the user
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Get the number of dice rolls from the user
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfDiceRolls = int.Parse(Console.ReadLine());

        // Create an instance of the DiceRoller class and simulate the rolls
        DiceRoller diceRoller = new DiceRoller();

        // Create an array to keep track of the number of times each combination is thrown
        int[] diceRolls = diceRoller.RollDice(numberOfDiceRolls);

        // Print the simulation results as a histogram
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        for (int  i = 2;  i <= 12;  i++)
        {
            // Calculate the percentage of the total number of rolls
            int percentage = diceRolls[i] * 100 / numberOfDiceRolls;

            // another way to do it
            //int percentage = (int)Math.Round((double)diceRolls[i] / numberOfDiceRolls * 100);

            string asterisks = new string('*', percentage);

            Console.WriteLine($"{i}: {asterisks}");
        }


        Console.WriteLine($"Total number of rolls: {numberOfDiceRolls}.");
    }
    
    
}