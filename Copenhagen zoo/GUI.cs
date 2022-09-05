using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using staffs namespace
using staffs;

namespace Copenhagen_zoo
{
    internal class GUI
    {
        //A method to show the menu
        public void ShowMenu()
        {

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("             Copgenhagen zookeeping");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Show animals");
            Console.WriteLine("2. Show zookeepers");
            Console.WriteLine("3. Feed animal(s)");
            Console.WriteLine("4. Change Name");
            Console.WriteLine("5. exit program");
        }
        //A method to show the animals
        public void ShowAnimals(List<Animal> animals)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                    Animals:");
            Console.WriteLine("------------------------------------------------");
            //Foreach loop that shows all animals in the list animals
            foreach (Animal a in animals)
            {
                //set the gender of the animal, if true male , else female
                string gender;
                if (a.Gender == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                Console.WriteLine($"{gender} {a.Race}");
            }
        }
        //A method to show all zookeepers in the staff list
        public void ShowZookeepers(List<Zookeeper> staff)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                     Staff:");
            Console.WriteLine("------------------------------------------------");
            
            //loops through all zookeepers in the list staff
            foreach (Zookeeper z in staff)
            {
                Console.WriteLine($"{z.Name} with id: {z.Id}");
            }
        }

        //Feeding menu method
        public void FoodMenu()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                 Feeding menu:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1. Monkeys");
            Console.WriteLine("2. Zebras");
            Console.WriteLine("3. Tigers");
        }
    }
}
