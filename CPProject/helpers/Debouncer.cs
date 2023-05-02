using Timer = System.Threading.Timer;

namespace CPProject.helpers
{
    public class Debouncer
    {
        private readonly int _delayMilliseconds;
        private Timer? _timer;

        public Debouncer(int delayMilliseconds)
        {
            _delayMilliseconds = delayMilliseconds;
        }

        public void Debounce(Action action)
        {
            _timer?.Dispose();
            _timer = new Timer(_ => { action(); _timer?.Dispose(); }, null, _delayMilliseconds, Timeout.Infinite);
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
