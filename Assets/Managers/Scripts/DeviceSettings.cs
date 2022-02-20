using UnityEngine;

// Device setup

public class DeviceSettings : MonoBehaviour
{

    [SerializeField] private EventBus eventBus;
    [SerializeField] private int targetFramerate;

    private bool isLoaded = false;

    private void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Application.targetFrameRate = targetFramerate;
    }

    private void Update()
    {
        if (!isLoaded)
        {
            eventBus.loadSceneEvent.Invoke();
            isLoaded = true;
        }
    }
}
