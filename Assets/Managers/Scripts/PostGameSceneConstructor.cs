using UnityEngine;
using TMPro;
using System;

// Builds Post Game scene

public class PostGameSceneConstructor : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private EventBus eventBus;
    [SerializeField] private TextMeshProUGUI message;

    private void Start()
    {
        if (appVariables.score >= appVariables.CurrentLevel.winScore)
        {
            message.text = "You Won!!!";

            appVariables.CurrentLevelIndex++;
        }
        else
        {
            message.text = "Level Failed";
            appVariables.nextLifeTime = DateTime.Now.AddMinutes(appVariables.LifeRegenerationTime);
            appVariables.Life--;
        }
    }
}
