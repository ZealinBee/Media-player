using System;
using Services;
using Services.Factory;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just adding some dummy media so user can use the app without adding media
            Audio audio1 = new Audio("Audio 1", "1", new TimeSpan(0, 0, 0, 0, 1000));
            Audio audio2 = new Audio("Audio 2", "2", new TimeSpan(0, 0, 0, 0, 1000));
            Video video1 = new Video("Video 1", "1", new TimeSpan(0, 0, 0, 0, 1000));
            Video video2 = new Video("Video 2", "2", new TimeSpan(0, 0, 0, 0, 1000));
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
                        IMediaPlayer audioPlayer = MediaPlayerFactory.GetMediaPlayer("audio");
                        break;
                    case 2:
                        IMediaPlayer videoPlayer = MediaPlayerFactory.GetMediaPlayer("video");
                        break;
                    case 3:
                        MediaPlayerManager mediaManager = MediaPlayerManager.Instance();
                        mediaManager.DisplayOptions();
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using our application!");
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
