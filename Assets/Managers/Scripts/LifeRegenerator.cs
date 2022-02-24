using UnityEngine;
using UnityEngine.UI;
using System;

// Regenerates life after certain system time

public class LifeRegenerator : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private Timer timer;
    [SerializeField] private Button startLevelButton;

    private void Start()
    {
        timer.completedEvent.AddListener(OnTimerComplete);

        while (DateTime.Compare(DateTime.Now, appVariables.nextLifeTime) > 0 && appVariables.Life < 3)
        {
            appVariables.nextLifeTime.AddMinutes(appVariables.LifeRegenerationTime);
            appVariables.Life++;
        }

        StartNewLifeTimer();
    }

    private void StartNewLifeTimer()
    {
        int timeSeconds = (int)(appVariables.nextLifeTime - DateTime.Now).TotalSeconds;
        timer.Play(timeSeconds);
        if (appVariables.Life > 0) startLevelButton.interactable = true;
    }

    private void OnTimerComplete()
    {
        appVariables.Life++;
        appVariables.nextLifeTime = DateTime.Now.AddMinutes(appVariables.LifeRegenerationTime);
        if (appVariables.Life < 3) StartNewLifeTimer();
    }

}
