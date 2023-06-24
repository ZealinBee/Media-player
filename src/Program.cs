using System;
using Services;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Console.WriteLine("Welcome to the media player!");
            while (exit == false)
            {
                int choice = 0;
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Play an audio");
                Console.WriteLine("2. Play a video");
                Console.WriteLine("3. Media manager");
                Console.WriteLine("4. Exit");
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
                        Console.WriteLine("Media manager...");
                        MediaPlayerManager mediaManager = MediaPlayerManager.Instance();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
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
