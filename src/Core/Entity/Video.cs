class Video : IMedia
{
    public string Title { get; set; }
    public string Path { get; set; }
    public TimeSpan Duration { get; set; }
    public Video(string title, string path, TimeSpan duration)
    {
        Title = title;
        Path = path;
        Duration = duration;
    }
}