using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

// Regenerates life after certain system time

public class LifeRegenerator : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private EventBus eventBus;
    [SerializeField] private Timer timer;
    [SerializeField] private Button startLevelButton;
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private LifePanel lifePanel;

    private void Start()
    {
        timer.completedEvent.AddListener(OnTimerComplete);
        timer.tickEvent.AddListener(OnTimerTick);

        while (DateTime.Compare(DateTime.Now, appVariables.nextLifeTime) > 0 && appVariables.Life < 3)
        {
            appVariables.nextLifeTime = appVariables.nextLifeTime.AddMinutes(appVariables.LifeRegenerationTime);
            appVariables.Life++;
        }

        if (appVariables.Life < 3) StartNewLifeTimer();

        if (appVariables.Life > 0) startLevelButton.interactable = true;

    }

    private void StartNewLifeTimer()
    {
        int timeSeconds = (int)(appVariables.nextLifeTime - DateTime.Now).TotalSeconds;
        timer.Play(timeSeconds);
        if (appVariables.Life > 0)
        {
            startLevelButton.interactable = true;
            buttonText.text = "START";
        }
    }

    private void OnTimerComplete()
    {
        lifePanel.UpdateLife();
        appVariables.Life++;
        appVariables.nextLifeTime = DateTime.Now.AddMinutes(appVariables.LifeRegenerationTime);
        if (appVariables.Life < 3) StartNewLifeTimer();
    }

    private void OnTimerTick(int remainingTime)
    {
        if (appVariables.Life == 0)
        {
            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;

            buttonText.text = minutes.ToString() + " : " + seconds.ToString();
        }
    }

}
