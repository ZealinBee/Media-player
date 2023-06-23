using System;
namespace Services
{
    class MediaPlayerManager
    {
        private MediaPlayerManager() { }
        private static MediaPlayerManager _instance;
        private static readonly object _lock = new object();
        public static MediaPlayerManager Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MediaPlayerManager();
                    }
                }
            }
            return _instance;
        }

    }
}
