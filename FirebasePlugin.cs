using Firebase;
using Firebase.Analytics;
using Firebase.Extensions;
using UnityEngine;

namespace RCS.PluginMediation
{
    public class FirebasePlugin : IFirebaseAnalytics
    {
        public void Initialize()
        {
            FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
            {
                var dependencyStatus = task.Result;

                if (dependencyStatus == DependencyStatus.Available)
                {
                    FirebaseApp app = FirebaseApp.DefaultInstance;
                    Debug.Log("Firebase is initialized and ready to use.");

                    // Optionally log a test event to verify setup
                    FirebaseAnalytics.LogEvent(FirebaseAnalytics.EventAppOpen);
                }
                else
                {
                    Debug.LogError($"Firebase dependencies not resolved: {dependencyStatus}");
                }
            });
        }

        public void LogEvent(string eventName)
        {
            FirebaseAnalytics.LogEvent(eventName);
            Debug.Log($"[RCS] Firebase Log Event: {eventName}.");
        }
    }
}
