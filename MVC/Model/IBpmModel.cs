namespace MVC.Model
{
    public interface IBpmModel : IBpmObservable
    {
        void Start();
        void Stop();
        void SetBpm(int bpm);
        void IncrementBpm();
        void DecrementBpm();
    }

    public interface IReadOnlyBpmModel
    {
        int GetBpm();
    }
}
