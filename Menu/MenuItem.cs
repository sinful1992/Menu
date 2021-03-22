using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    class MenuItem
    {
        //public Randomizer
       public Random Randomizer = new Random();

        public string[] Proteins = { "Roast beed", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };

        public string[] Condiments = { "yelow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };

        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll", };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            // calls random  item from Proteins array 
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            // calss random item from Condiments array
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            // calls random item from Breads array
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            // sets the Description string value
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            // sets random price between 2-5
            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            // converts price to string and sets Price Value
            // "c" is a parameter  which formats the value to local currency: punds, euros, dollars
            Price = price.ToString("c");
        }
    }
}
