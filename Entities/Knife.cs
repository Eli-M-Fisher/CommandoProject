using System;
using CommandoProject.Utils;
using CommandoProject.Interfaces;

namespace CommandoProject.Entities
{
    public class Knife : IBreakable
    {
        public string Name { get; private set; }
        public string MetalType { get; private set; }
        public string Manufacturer { get; private set; }
        public string Color { get; private set; }
        public double Weight { get; private set; }

        public string Status { get; private set; }
        public int MaxHits { get; private set; }
        public int CurrentHits { get; private set; }

        public Knife(string name, string metalType, string manufacturer, string color, double weight)
        {
            Name = name;
            MetalType = metalType;
            Manufacturer = manufacturer;
            Color = color;
            Weight = weight;

            MaxHits = 10;
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