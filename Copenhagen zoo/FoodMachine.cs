using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foods
{
    internal class FoodMachine
    {
        //Method that feed animals
        public void FeedAnimals(int animal)
        {
            switch (animal)
            {
                //If int amimal is 1 then feeds monkeys
                case 1:
                    Console.Clear();
                    Console.WriteLine("Feeding monkeys bananas");
                    Thread.Sleep(3000);
                    break;
                //If int amimal is 2 then feeds Zebras
                case 2:
                    Console.Clear();
                    Console.WriteLine("Feeding Zebras grass");
                    Thread.Sleep(3000);
                    break;
                //If int amimal is 3 then feeds Tigers
                case 3:
                    Console.Clear();
                    Console.WriteLine("Feeding Tigers Something alive (Not human)");
                    Thread.Sleep(3000);
                    break;
                default:
                    break;
            }
        }
    }
}
