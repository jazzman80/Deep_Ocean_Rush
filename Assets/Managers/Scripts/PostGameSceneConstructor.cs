using UnityEngine;
using TMPro;

// Builds Post Game scene

public class PostGameSceneConstructor : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;

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
        }
    }
}
