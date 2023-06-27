namespace Core.Entity
{
    public class Video : IMedia
    {
        public string Title { get; set; }
        public int _id { get; }
        public TimeSpan Duration { get; set; }
        public Video(string title, TimeSpan duration)
        {
            Title = title;
            _id++;
            Duration = duration;
        }
    }
}
