public interface IMedia
{
    string Title { get; set; }
    TimeSpan Duration { get; set; }
    int _id { get; }
}