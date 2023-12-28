
using System;
using UnityEngine;


public class Initilize : MonoBehaviour
{
#if UNITY_ANDROID
    string appKey = "1c88e8e0d";
#elif UNITY_IPHONE
    string appKey = "1c88e8e0d";
#else

#endif
    private void Start()
    {
        IronSource.Agent.validateIntegration();
        IronSource.Agent.init(appKey);
    }
    private void OnEnable()
    {
        IronSourceEvents.onSdkInitializationCompletedEvent += SDKInitialized;
    }
    void SDKInitialized()
    {
        print("sdk is initialzed!");
    }

    private void OnApplicationPause(bool pause)
    {
        IronSource.Agent.onApplicationPause(pause);
    }
}

