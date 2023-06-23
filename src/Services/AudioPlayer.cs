class AudioPlayer : IMediaPlayer
{

    public void Play(string audioType)
    {
        Console.WriteLine("Playing audio file.");
    }


    public void Pause()
    {
        Console.WriteLine("Audio file paused.");
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