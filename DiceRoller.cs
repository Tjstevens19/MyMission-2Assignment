using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a namespace
namespace DiceRollerNamespace
{
    // Create a diceRoller class
    internal class DiceRoller
    {
        // Create a random number generator
        private readonly Random random;

        // Create a constructor
        public DiceRoller()
        {
            random = new Random();
        }

        // Create a method to roll a dice
        public int[] RollDice(int numberOfRolls)
        {
            // Create an array to keep track of the number of times each combination is thrown
            int[] diceRolls = new int[13];

            // Roll the dice the specified number of times
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll the dice
                int dice1 = random.Next(1, 7); // 1-6
                int dice2 = random.Next(1, 7); // 1-6

                // Calculate the sum of the dice
                int sum = dice1 + dice2;

                // Increment the number of times the combination was thrown
                diceRolls[sum]++;
            }

            // Return the dice roll
            return diceRolls;
        }
    }
}
