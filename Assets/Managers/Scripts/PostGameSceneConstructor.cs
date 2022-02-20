using UnityEngine;
using TMPro;

// Builds Post Game scene

public class PostGameSceneConstructor : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;

    [SerializeField] private Level level;
    
    [SerializeField] private TextMeshProUGUI message;

    private void Start()
    {
        if (appVariables.score >= level.winScore)
        {
            message.text = "You Won!!!";
        }
        else
        {
            message.text = "Level Failed";
        }
    }
}
