using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchBuddy fred = new LunchBuddy("Fred", "Rogers");
            LunchBuddy daphne = new LunchBuddy("Daphne", "Porter");
            LunchBuddy melissa = new LunchBuddy("Melissa", "Swann");
            LunchBuddy thomas = new LunchBuddy("Thomas", "Nickle");

            List<LunchBuddy> companions = new List<LunchBuddy> { };

            companions.Add(fred);
            companions.Add(daphne);
            companions.Add(melissa);

            fred.Eat();
            daphne.Eat("leftover lasagna");
            thomas.Eat(companions);
            thomas.Eat("thai food", companions);

        }
    }
}
