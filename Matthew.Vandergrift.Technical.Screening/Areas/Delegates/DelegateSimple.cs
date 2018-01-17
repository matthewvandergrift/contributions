namespace Matthew.Vandergrift.Technical.Screening.Areas.Delegates
{
    public class DelegateSimple
    {
        // Define a delegate named LogHandler, which will encapsulate
        // any method that takes a string as the parameter and returns no value
        public delegate void LogHandler(string message);

        // Define an Event based on the above Delegate
        public event LogHandler Log;

        // Instead of having the Process() function take a delegate
        // as a parameter, we've declared a Log event. Call the Event,
        // using the OnXXXX Method, where XXXX is the name of the Event.
        public bool Process()
        {
            try
            {
                OnLog("begin");
                OnLog("end");
            }
            catch
            {
                return false;
            }

            return true;
        }

        // By Default, create an OnXXXX Method, to call the Event
        protected void OnLog(string message)
        {
            Log?.Invoke(message);
        }
    }
}