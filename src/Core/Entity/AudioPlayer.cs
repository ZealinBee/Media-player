namespace Core.Entity
{
    public class AudioPlayer : IMediaPlayer
    {
        List<Audio> audios = new List<Audio>();

        public void DisplayMedias()
        {
            int i = 1;
            foreach (Audio audio in audios)
            {
                Console.WriteLine($"{i}. {audio.Title}");
            }
        }
        public void Play()
        {
            System.Console.WriteLine("Audio Playing...");
        }

        public void Pause()
        {
            System.Console.WriteLine("Audio Pausing...");
        }

        public void Stop()
        {
            System.Console.WriteLine("Audio Stopping...");
        }

        public void Seek()
        {
            System.Console.WriteLine("Audio Seeking...");
        }

        public void Display()
        {
            System.Console.WriteLine("List of songs you can play:");

        }
    }
}