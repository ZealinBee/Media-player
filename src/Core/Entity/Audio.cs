namespace Core.Entity
{
    public class Audio : IMedia
    {
        public string Title { get; set; }
        public int _id { get; }
        public TimeSpan Duration { get; set; }
        public Audio(string title, TimeSpan duration)
        {
            Title = title;
            _id++;
            Duration = duration;
        }
    }
}

