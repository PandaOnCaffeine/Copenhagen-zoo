using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_zoo
{
    internal class GUI
    {

        public void ShowMenu()
        {

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("             Copgenhagen zookeeping");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Show animals");
            Console.WriteLine("2. Show zookeepers");
            Console.WriteLine("3. Feed animal(s)");
            Console.WriteLine("4. Refill water");
            Console.WriteLine("5. Buy animal(s)");
            Console.WriteLine("6. Hire zookeepers");
            Console.WriteLine("7. exit program");
            Console.WriteLine("");
            Console.WriteLine("Notification");


        }
        public void ShowAnimals(List<Animal> animals)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                    Animals:");
            Console.WriteLine("------------------------------------------------");
            foreach (Animal a in animals)
            {
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
        public void ShowZookeepers(List<Zookeeper> staff)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                     Staff:");
            Console.WriteLine("------------------------------------------------");
            foreach (Zookeeper z in staff)
            {
                Console.WriteLine($"{z.Name} with id: {z.Id}");
            }
        }
        public void Notifications()
        {

        }
    }
}
