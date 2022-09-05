using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foods;

namespace staffs
{
    internal class Zookeeper
    {
        //Foodmachine variable
        FoodMachine foods;
        
        //Properties
        private string name;
        private int id;
        //Encapsulation
        public string Name
        {
            get { return name; }
        }
        public int Id
        {
            get { return id; }
        }
        
        //Constructer
        public Zookeeper(string name, List<Zookeeper> staff, FoodMachine foods)
        {
            this.name = name;
            this.foods = foods;
            //sets this zookeepers id to the int the IdMaker Returns
            this.id = IdMaker(staff);

            //adds the zookeeper to the staff list
            staff.Add(this);
        }
        //A method that checks all the ids the other staffs has and returns a id that is not used
        private int IdMaker(List<Zookeeper> staff)
        {
            //id Starts at 1
            int id = 1;

            //Loops through all zookeepers
            foreach (Zookeeper z in staff)
            {
                //checks if the int is the sameone as someone else
                if (id == z.id)
                {
                    id++;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }
        public void Feed(int animal)
        {
            foods.FeedAnimals(animal);
        }
    }
}
