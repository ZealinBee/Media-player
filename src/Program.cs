namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the media player!");
            while (true)
            {
                int choice = 0;
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Play an audio");
                Console.WriteLine("2. Play a video");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Playing audio...");
                        break;
                    case 2:
                        Console.WriteLine("Playing video...");
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
