namespace Controllers
{
    public class MenuController
    {
        public void HandleMenu()
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Music-specific menu:");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Pause");
                Console.WriteLine("3. Stop");
                Console.WriteLine("4. Go back to main menu");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Playing...");
                        break;
                    case 2:
                        Console.WriteLine("Pausing...");
                        break;
                    case 3:
                        Console.WriteLine("Stopping...");
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}