using CommandoProject.Utils;
using CommandoProject.Interfaces;
using System;

namespace CommandoProject.Entities
{
    public class Stone : IBreakable
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public string Color { get; private set; }

        public string Status { get; private set; }
        public int MaxHits { get; private set; }
        public int CurrentHits { get; private set; }

        public Stone(string name, double weight, string color)
        {
            Name = name;
            Weight = weight;
            Color = color;
            MaxHits = 5;
            CurrentHits = 0;
            Status = "Intact";
        }

        public void Hit()
        {
            if (Status == "Broken")
            {
                Console.WriteLine($"{Name} is already broken.");
                Logger.Log($"{Name} is already broken.");
                return;
            }

            CurrentHits++;

            if (CurrentHits >= MaxHits)
            {
                Status = "Broken";
                Console.WriteLine($"{Name} has broken!");
                Logger.Log($"{Name} has broken!");
            }
            else
            {
                Console.WriteLine($"{Name} was hit. Hits: {CurrentHits}/{MaxHits}");
                Logger.Log($"{Name} was hit. Hits: {CurrentHits}/{MaxHits}");
            }
        }
    }
}