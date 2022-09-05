using Foods;
using staffs;
namespace Copenhagen_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a variable that is used to determin the key the user has pressed
            ConsoleKeyInfo choice;

            //Bool to check if the user want to exit the program
            bool exit = false;

            //A objekt gui to show the gui of the program
            GUI gui = new GUI();

            //objekt foodmachine called foods
            FoodMachine foods = new FoodMachine();

            //a List of animals and add a few animals
            List<Animal> animals = new List<Animal>();
            Animal animal1 = new Animal("Monkey",true,animals);
            Animal animal2 = new Animal("Monkey", false, animals);

            //a List of staff and adding a few zookeepers
            List<Zookeeper> staff = new List<Zookeeper>();
            Zookeeper z1 = new Zookeeper("Jacob", staff, foods);
            Zookeeper z2 = new Zookeeper("Anna", staff, foods);

            //do while
            do
            {
                //Clears console
                Console.Clear();

                //shows menu
                gui.ShowMenu();

                //set choice to the key the user pressed
                choice = Console.ReadKey();
                switch (choice.Key)
                {
                    //If user pressed key 1
                    case ConsoleKey.D1:
                        //Clears Console
                        Console.Clear();
                        //Show all animals with the method ShowAnimals
                        gui.ShowAnimals(animals);

                        //Tells user how to get back to the menu
                        Console.WriteLine("\r\nPress Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    //If user pressed key 2
                    case ConsoleKey.D2:
                        //Clears Console
                        Console.Clear();
                        //Show all zookeepers with the Method ShowZookeepers
                        gui.ShowZookeepers(staff);

                        //Tells user how to get back to the menu
                        Console.WriteLine("\r\nPress Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    //If user pressed key 3
                    case ConsoleKey.D3:
                        //Clears console
                        Console.Clear();
                        //Show the food menu
                        gui.FoodMenu();

                        //Ask what animals to feed
                        Console.WriteLine("\r\nChoose the animal you want to feed");
                        //set choice to the key the user pressed
                        choice = Console.ReadKey();
                        switch (choice.Key)
                        {
                            //if key 1
                            case ConsoleKey.D1:
                                //Monkeys
                                z1.Feed(1);
                                break;
                            //if key 2
                            case ConsoleKey.D2:
                                //Zebras
                                z1.Feed(2);
                                break;
                            //if key 3
                            case ConsoleKey.D3:
                                //Tigers
                                z1.Feed(3);
                                break;
                            default:
                                break;
                        }

                        //Tells user how to get back to the menu
                        Console.WriteLine("\r\nPress Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    //If user pressed key 4
                    case ConsoleKey.D4:

                        break;
                    //If user pressed key 5
                    case ConsoleKey.D5:
                        //Clears console
                        Console.Clear();
                        //set exit bool to true
                        exit = true;
                        break;
                    default:
                        //writes unknown command if anything other then the keys above are pressed
                        Console.Clear();
                        Console.WriteLine(" Unknown Command");
                        Thread.Sleep(500);
                        break;
                }
                //Runs while exit isn't true
            } while (exit != true);
        }
    }
}