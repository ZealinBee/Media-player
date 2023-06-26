public interface IObserver
{
    void OnPlay(IMedia media);
    void OnStop(IMedia media);
    void OnPause(IMedia media);
}