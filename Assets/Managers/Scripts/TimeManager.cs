using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Controls game time

public class TimeManager : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    
    [Header("Times")]
    [SerializeField] private int countdownTime;
    [SerializeField] private int gameOverTime;
    [SerializeField] private int goTime;

    [Header("Events")]
    [SerializeField] private EventBus eventBus;

    [Header("Timers")]
    [SerializeField] private Timer countdownTimer;
    [SerializeField] private Timer gameTimer;
    [SerializeField] private Timer gameOverTimer;
    [SerializeField] private Timer goTimer;

    [Header("UI")]
    [SerializeField] private TextMeshProUGUI centralUI;
    [SerializeField] private TextMeshProUGUI timerUI;

    private void Start()
    {
        countdownTimer.completedEvent.AddListener(OnCountdownComplete);
        countdownTimer.tickEvent.AddListener(OnCountdownTick);

        gameTimer.completedEvent.AddListener(OnGameComplete);
        gameTimer.tickEvent.AddListener(OnGameTick);

        goTimer.completedEvent.AddListener(OnGoComplete);

        gameOverTimer.completedEvent.AddListener(OnGameOverComplete);

        countdownTimer.Play(countdownTime);
    }

    private void OnCountdownTick(int tickNumber)
    {
        centralUI.text = tickNumber.ToString();
    }

    private void OnCountdownComplete()
    {
        centralUI.text = "GO!";

        eventBus.countdownCompleteEvent.Invoke();

        gameTimer.Play(appVariables.CurrentLevel.time);
        goTimer.Play(goTime);
    }

    private void OnGoComplete()
    {
        centralUI.gameObject.SetActive(false);
    }

    private void OnGameTick(int tickNumber)
    {
        timerUI.text = tickNumber.ToString();
    }

    private void OnGameComplete()
    {
        centralUI.gameObject.SetActive(true);
        centralUI.text = "Time is Over";

        eventBus.gameCompleteEvent.Invoke();

        timerUI.gameObject.SetActive(false);

        gameOverTimer.Play(gameOverTime);
    }

    private void OnGameOverComplete()
    {
        eventBus.sceneComplete.Invoke();
    }
}
