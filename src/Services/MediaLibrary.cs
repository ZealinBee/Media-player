class MediaLibrary
{
    public List<Audio> audios = new List<Audio>();
    public List<Video> videos = new List<Video>();

    private MediaLibrary() { }
    private static MediaLibrary _instance;
    private static readonly object _lock = new object();

    public static MediaLibrary Instance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new MediaLibrary();
                }
            }
        }
        return _instance;
    }

    public void DisplayAudios()
    {
        int i = 1;
        foreach (Audio audio in audios)
        {
            Console.WriteLine($"{i}. {audio.Title}");
            i++;
        }
    }

    public void DisplayVideos()
    {
        int i = 1;
        foreach (Video video in videos)
        {
            Console.WriteLine($"{i}. {video.Title}");
            i++;
        }
    }

    public void AddAudio(Audio audio)
    {
        audios.Add(audio);
    }

    public void AddVideo(Video video)
    {
        videos.Add(video);
    }

    public Audio GetAudio(int index)
    {
        return audios[index];
    }

    public Video GetVideo(int index)
    {
        return videos[index];
    }
}
