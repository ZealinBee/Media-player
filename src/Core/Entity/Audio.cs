public class Audio : IMedia
{
    public string Title { get; set; }
    public TimeSpan Duration { get; set; }
    public string Path { get; set; }

    public Audio(string title, string path, TimeSpan duration)
    {
        Title = title;
        Path = path;
        Duration = duration;
    }
}