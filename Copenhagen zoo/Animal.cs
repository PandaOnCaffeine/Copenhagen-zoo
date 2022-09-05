using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_zoo
{
    internal class Animal
    {
        //Properties
        private string race;
        private bool gender;

        //Encapsulation
        public string Race
        {
            get { return race; }
        }
        public bool Gender
        {
            get { return gender; }
        }

        //Constructer
        public Animal(string race, bool gender,List<Animal> animals)
        {
            this.race = race;
            this.gender = gender;
            animals.Add(this);
        }
        //Public method, so animals can drink
        public void Drink()
        {

        }
        //Public method, so animals can eat
        public void Eat()
        {

        }
        
    }
}
