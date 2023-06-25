namespace Core.Entity
{
    public class AudioPlayer : IMediaPlayer
    {
        public void DisplayOptions()
        {
            System.Console.WriteLine("Audio Options:");
            System.Console.WriteLine("1. Play");
            System.Console.WriteLine("2. Pause");
            System.Console.WriteLine("3. Stop");
            System.Console.WriteLine("4. Seek");
        }
        public void Play(IMedia audio)
        {
            System.Console.WriteLine($"{audio.Title} is playing");
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


    }
}