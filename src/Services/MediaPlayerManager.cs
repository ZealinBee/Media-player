using Core.Entity;
namespace Services
{
    class MediaPlayerManager
    {
        private MediaPlayerManager() { }
        private static MediaPlayerManager _instance;
        private static readonly object _lock = new object();

        public static MediaPlayerManager Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MediaPlayerManager();
                    }
                }
            }
            return _instance;
        }

        public void DisplayOptions()
        {
            Console.WriteLine("1. Add Media");
            Console.WriteLine("2. Playlist Manager");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DisplayAddMediaOptions();
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            AddVideo();
                            break;
                        case 2:
                            AddAudio();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Playlist Manager...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        public void DisplayAddMediaOptions()
        {
            Console.WriteLine("Select media type to add:");
            Console.WriteLine("1. Add Video");
            Console.WriteLine("2. Add Audio");
        }

        public static void AddVideo()
        {
            Console.WriteLine("Enter video name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter video duration: ");
            TimeSpan duration = TimeSpan.Parse(Console.ReadLine());
            Video video = new Video(name, duration);
            MediaLibrary.Instance().AddVideo(video);
            Console.WriteLine("Video added");
        }

        public static void AddAudio()
        {
            Console.WriteLine("Enter audio name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter audio duration: ");
            TimeSpan duration = TimeSpan.Parse(Console.ReadLine());
            Audio audio = new Audio(name, duration);
            MediaLibrary.Instance().AddAudio(audio);
            Console.WriteLine("Audio added");
        }
    }
}
