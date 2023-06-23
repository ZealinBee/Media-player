class PlayerObserver
{
    public void OnPlay(IMedia media)
    {
        Console.WriteLine($"Playing {media.Title} from {media.Path} for {media.Duration}");
    }

    public void OnStop(IMedia media)
    {
        Console.WriteLine($"Stopped {media.Title} from {media.Path} for {media.Duration}");
    }

    public void OnPause(IMedia media)
    {
        Console.WriteLine($"Paused {media.Title} from {media.Path} for {media.Duration}");
    }

    public void OnResume(IMedia media)
    {
        Console.WriteLine($"Resumed {media.Title} from {media.Path} for {media.Duration}");
    }
}