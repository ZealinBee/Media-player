class VideoPlayer : IMediaPlayer
{
    public void Play(string videoType)
    {
        Console.WriteLine("Playing video file.");
    }

    public void Pause()
    {
        Console.WriteLine("Video file paused.");
    }

    public void Seek()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}