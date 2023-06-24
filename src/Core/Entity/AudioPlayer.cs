namespace Core.Entity
{
    public class AudioPlayer : IMediaPlayer
    {
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
    }
}