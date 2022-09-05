using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foods;

namespace Copenhagen_zoo
{
    internal class Zookeeper
    {
        FoodMachine foods;
        
        private string name;
        private int id;
        public string Name
        {
            get { return name; }
        }
        public int Id
        {
            get { return id; }
        }
        
        public Zookeeper(string name, List<Zookeeper> staff, FoodMachine foods)
        {
            this.name = name;
            this.foods = foods;
            this.id = IdMaker(staff);

            staff.Add(this);
        }
        private int IdMaker(List<Zookeeper> staff)
        {
            int id = 1;
            foreach (Zookeeper z in staff)
            {
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
        public void Feed()
        {
            foods.FeedAnimals();
        }
    }
}
