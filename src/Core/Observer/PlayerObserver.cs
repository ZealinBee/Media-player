class PlayerObserver : IObserver
{
    public void OnPlay(IMedia media)
    {
        Console.WriteLine($"Playing {media.Title}");
    }

    public void OnStop(IMedia media)
    {
        Console.WriteLine($"Stopping {media.Title}");
    }

    public void OnPause(IMedia media)
    {
        Console.WriteLine($"Pausing {media.Title}");
    }

}