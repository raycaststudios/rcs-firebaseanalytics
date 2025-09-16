namespace RCS.PluginMediation
{
    public interface IFirebaseAnalytics
    {
        void Initialize();
        void LogEvent(string eventName); // Optional: only for analytics-type plugins
    }
}
