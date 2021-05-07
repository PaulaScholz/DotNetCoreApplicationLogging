using System;
using DiceThrowLibrary.Logging;

namespace DiceThrowLibrary
{
    /// <summary>
    /// A tiny library used to demonstrate logging.  There are two methods
    /// for illustrative purposes. This library uses ETW messaging to send
    /// messages to any EventListener or ETW consumer.
    /// </summary>
    public static class DiceThrow
    {
        private static readonly Random r = new();

        private static int counter = 0;
        private static int totalCounter = 0;

        /// <summary>
        /// Get the total from throwing two dice.
        /// </summary>
        /// <returns>An integer between 2 and 12.</returns>
        public static int GetDiceThrow(out int firstDie, out int secondDie)
        {
            int die1 = RollADie();
            int die2 = RollADie();

            firstDie = die1;
            secondDie = die2;

            counter++;

            if(counter == 99)
            {
                totalCounter += counter + 1;
                counter = 0;

                // Send an ETW message with our current totalCounter. This will be received by any attached ETW 
                // consumer applications like PerfView, any attached debugger through the DefaultEventListener,
                // and the EventListener in the main application, which will echo it to the Microsoft.Extensions.Logging
                // system's logging providers.
                Logger.Info(string.Format("DiceThrowLibrary has generated {0} total throws this run.", totalCounter));
            }

            return die1 + die2;
        }

        /// <summary>
        /// Roll a die.
        /// </summary>
        /// <returns>A pseudo-random integer between 1 and 6, inclusive.</returns>
        private static int RollADie()
        {
            return r.Next(1, 7);
        }

        /// <summary>
        /// Generate an unhandled DivideByZero Exception to be caught at application level
        /// </summary>
        /// <returns>Divide By Zero Exception</returns>
        public static int DivideByZero()
        {
            int x = 10;
            int y = 0;

            // generate a divide by zero exception
            return x / y;
        }

    }
}
