using Core.Entity;
namespace Services
{
    public class MediaLibrary
    {
        public List<Audio> audios = new List<Audio>();
        public List<Video> videos = new List<Video>();
        private List<IObserver> observers = new List<IObserver>();

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

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void NotifyPlay(IMedia media)
        {
            foreach (IObserver observer in observers)
            {
                observer.OnPlay(media);
            }
        }

        public void NotifyStop(IMedia media)
        {
            foreach (IObserver observer in observers)
            {
                observer.OnStop(media);
            }
        }

        public void NotifyPause(IMedia media)
        {
            foreach (IObserver observer in observers)
            {
                observer.OnPause(media);
            }
        }
    }

}

