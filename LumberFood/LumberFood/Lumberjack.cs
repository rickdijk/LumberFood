using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberFood
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count(); } }

        public void TakeFlapjacks(Flapjack food, int howMany) {
            // Add some number of flapjacks to the Meal stack
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapjacks() {
            // Write this output to the console
            string output = $"{Name}'s eating flapjacks{Environment.NewLine}";
            foreach (Flapjack flapjack in meal)
            {
                output += $"{Name} ate a {flapjack.ToString().ToLower()} flapjack {Environment.NewLine}";
            }
            Console.WriteLine(output);
        }
    }
}
