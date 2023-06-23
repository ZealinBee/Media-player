public interface IMedia
{
    string Title { get; set; }
    TimeSpan Duration { get; set; }
    string Path { get; set; }
}