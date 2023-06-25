namespace Core.Entity
{
    public class VideoPlayer : IMediaPlayer
    {
        public void Play(IMedia video)
        {
            System.Console.WriteLine("Video Playing...");
        }

        public void Pause()
        {
            System.Console.WriteLine("Video Pausing...");
        }

        public void Stop()
        {
            System.Console.WriteLine("Video Stopping...");
        }

        public void Seek()
        {
            System.Console.WriteLine("Video Seeking...");
        }

        public void DisplayOptions()
        {
            System.Console.WriteLine("Video Options:");
            System.Console.WriteLine("1. Play");
            System.Console.WriteLine("2. Pause");
            System.Console.WriteLine("3. Stop");
            System.Console.WriteLine("4. Seek");
        }
    }
}