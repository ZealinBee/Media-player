namespace Core.Entity
{
    public class Audio : IMedia
    {
        public string Title { get; set; }
        public string _id { get; }
        public TimeSpan Duration { get; set; }
        public Audio(string title, string id, TimeSpan duration)
        {
            Title = title;
            _id = id;
            Duration = duration;
        }
    }
}

