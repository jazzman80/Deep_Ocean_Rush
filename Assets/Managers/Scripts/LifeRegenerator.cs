using UnityEngine;
using System;

// Regenerates life after certain system time

public class LifeRegenerator : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private Timer timer;

    private void Start()
    {
        while (DateTime.Compare(DateTime.Now, appVariables.nextLifeTime) > 0 && appVariables.Life < 3)
        {
            appVariables.nextLifeTime.AddMinutes(appVariables.LifeRegenerationTime);
            appVariables.Life++;
        }

        if (appVariables.Life==0)
        {
            timer.Play();
        }
    }

}
