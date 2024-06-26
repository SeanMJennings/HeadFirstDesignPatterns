﻿namespace Iterator
{
    public class MenuItem
    {
        private string name;
        private string description;
        private bool vegetarian;
        private double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string getName() { return name; }
        public string getDescription() { return description; }
        public bool getVegetarian() { return vegetarian; }
        public double getPrice() { return price; }
        public override string ToString()
        {
            return $"{name} -- {description} -- {vegetarian} -- £{price}";
        }
    }
}
