using UnityEngine;
using System;

// Regenerates life after certain system time

public class LifeRegenerator : MonoBehaviour
{
    [SerializeField] private EventBus eventBus;
    [SerializeField] private AppVariables appVariables;

    private void Start()
    {
        eventBus.lifeLossEvent.AddListener(StartNewLifeTimer);

        while (DateTime.Compare(DateTime.Now, appVariables.nextLifeTime) < 0 && appVariables.Life < 3)
        {
            appVariables.nextLifeTime.AddMinutes(appVariables.LifeRegenerationTime);
            appVariables.Life++;
        }
    }

    private void StartNewLifeTimer()
    {
        DateTime lifeLossTime = DateTime.Now;
        lifeLossTime.AddMinutes(appVariables.LifeRegenerationTime);
        appVariables.nextLifeTime = lifeLossTime;
    }
}
