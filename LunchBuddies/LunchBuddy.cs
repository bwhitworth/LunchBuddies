using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Eat()
        {
            var whereBuddyIs = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {whereBuddyIs.Name}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var whereBuddiesAre = new Restaurant();
            var buddyFirstNames = new List<string>();

            foreach (var person in companions)
            {
                var first = person.FirstName;
                buddyFirstNames.Add(first);
            }
            string lunchFriends = string.Join(",", buddyFirstNames);

            Console.WriteLine($"{FirstName} {LastName} is at {whereBuddiesAre.Name} with {lunchFriends}.");
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var whereBuddiesAre = new Restaurant();
            var buddyFirstNames = new List<string>();

            foreach (var person in companions)
            {
                var first = person.FirstName;
                buddyFirstNames.Add(first);
            }
            string lunchFriends = string.Join(",", buddyFirstNames);

            Console.WriteLine($"{FirstName} {LastName} is at {whereBuddiesAre.Name} eating {food} with {lunchFriends}.");
        }

    }
}
