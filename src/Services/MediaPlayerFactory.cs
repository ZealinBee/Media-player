using Core.Entity;

namespace Services
{
    public class MediaPlayerFactory
    {
        public static IMediaPlayer GetMediaPlayer(string type)
        {
            switch (type)
            {
                case "audio":
                    return new AudioPlayer();
                case "video":
                    return new VideoPlayer();
                default:
                    return null;
            }
        }
    }
}