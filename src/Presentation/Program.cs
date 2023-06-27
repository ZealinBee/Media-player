using System;
using Services;
using Core.Entity;

namespace src
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Just adding some dummy media so user can use the app without adding media
                Audio audio1 = new Audio("Merry Christmas Audio", new TimeSpan(0, 0, 0, 0, 1000));
                Audio audio2 = new Audio("Jingle Bells Audio", new TimeSpan(0, 0, 0, 0, 1000));
                Video video1 = new Video("Youtube Video", new TimeSpan(0, 0, 0, 0, 1000));
                Video video2 = new Video("Instagram video", new TimeSpan(0, 0, 0, 0, 1000));
                MediaLibrary mediaLibrary = MediaLibrary.Instance();
                mediaLibrary.AddAudio(audio1);
                mediaLibrary.AddAudio(audio2);
                mediaLibrary.AddVideo(video1);
                mediaLibrary.AddVideo(video2);

                MediaPlayerManager mediaManager = MediaPlayerManager.Instance();
                PlayerObserver playerObserver = new PlayerObserver();
                mediaLibrary.Attach(playerObserver);

                bool exit = false;
                Console.WriteLine("Welcome to the media player!");
                while (exit == false)
                {
                    int choice = 0;
                    Console.WriteLine("Please select an option:");
                    Console.WriteLine("1. Play an audio");
                    Console.WriteLine("2. Play a video");
                    Console.WriteLine("3. Media manager");
                    Console.WriteLine("4. Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            IMediaPlayer audioPlayer = MediaPlayerFactory.GetMediaPlayer("audio");

                            mediaLibrary.DisplayAudios(); // Shows a list of playable songs
                            int audioChoice = Convert.ToInt32(Console.ReadLine());
                            audioPlayer.DisplayOptions(); // Shows a list of options for the selected song
                            int audioOption = Convert.ToInt32(Console.ReadLine());
                            Audio selectedAudio = mediaLibrary.GetAudio(audioChoice - 1);
                            switch (audioOption)
                            {
                                case 1:
                                    // audioPlayer.Play(selectedAudio);
                                    mediaLibrary.NotifyPlay(selectedAudio);
                                    break;
                                case 2:
                                    mediaLibrary.NotifyPause(selectedAudio);
                                    break;
                                case 3:
                                    mediaLibrary.NotifyStop(selectedAudio);
                                    break;
                                case 4:
                                    audioPlayer.Seek();
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }
                            break;
                        case 2:
                            IMediaPlayer videoPlayer = MediaPlayerFactory.GetMediaPlayer("video");
                            mediaLibrary.DisplayVideos();
                            int videoChoice = Convert.ToInt32(Console.ReadLine());
                            videoPlayer.DisplayOptions();
                            int videoOption = Convert.ToInt32(Console.ReadLine());
                            Video selectedVideo = mediaLibrary.GetVideo(videoChoice - 1);
                            switch (videoOption)
                            {
                                case 1:
                                    mediaLibrary.NotifyPlay(selectedVideo);
                                    break;
                                case 2:
                                    mediaLibrary.NotifyPause(selectedVideo);
                                    break;
                                case 3:
                                    mediaLibrary.NotifyStop(selectedVideo);
                                    break;
                                case 4:
                                    videoPlayer.Seek();
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }
                            break;
                        case 3:
                            mediaManager.DisplayOptions();
                            break;
                        case 4:
                            Console.WriteLine("Thanks for using our application!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
            }
            catch (ErrorHandler e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
