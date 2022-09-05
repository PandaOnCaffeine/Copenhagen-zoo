using Foods;
namespace Copenhagen_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo choice;
            bool exit = false;
            GUI gui = new GUI();

            FoodMachine foods = new FoodMachine();

            List<Animal> animals = new List<Animal>();
            Animal animal1 = new Animal("Monkey",true,animals);
            Animal animal2 = new Animal("Monkey", false, animals);


            List<Zookeeper> staff = new List<Zookeeper>();
            Zookeeper z1 = new Zookeeper("Jacob", staff, foods);
            Zookeeper z2 = new Zookeeper("Anna", staff, foods);


            do
            {
                Console.Clear();
                gui.ShowMenu();

                choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        gui.ShowAnimals(animals);

                        Console.WriteLine("\r\nPress Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        gui.ShowZookeepers(staff);

                        Console.WriteLine("\r\nPress Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:

                        break;
                    case ConsoleKey.D4:

                        break;
                    case ConsoleKey.D5:

                        break;
                    case ConsoleKey.D6:

                        break;
                    case ConsoleKey.D7:

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Unknown Command");
                        Thread.Sleep(1500);
                        break;
                }
            } while (exit != true);
        }
    }
}