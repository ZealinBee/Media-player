namespace Core.Entity
{
    public class VideoPlayer : IMediaPlayer
    {
        public void DisplayMedias()
        {

        }
        public void Play()
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
    }
}