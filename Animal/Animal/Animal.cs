using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;

        protected Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favouriteFood = favoriteFood;
        }
        public string getName(string name)
        {
            return name;
        }
        private void setName(string name)
        {
            this.name = name;
        }
        public string getFavouriteFood(string favouriteFood)
        {
            return favouriteFood;
        }
        private void setFavouriteFood(string favouriteFood)
        {
            this.favouriteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my favourite food is {this.favouriteFood}" + Environment.NewLine;
        }
    }
}
