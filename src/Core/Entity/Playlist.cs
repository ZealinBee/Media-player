namespace Core.Entity
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<IMedia> Medias { get; set; }

        public Playlist(string name)
        {
            Name = name;
            Medias = new List<IMedia>();
        }

        public void AddMedia(IMedia media)
        {
            Medias.Add(media);
        }
    }

}