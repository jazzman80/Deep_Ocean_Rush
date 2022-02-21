using UnityEngine;
using TMPro;
using UnityEngine.UI;

// Setup Pre Game scene

public class PreGameSceneConstructor : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI levelNumber;
    [SerializeField] private Image startImage;

    private void Start()
    {
        levelNumber.text = "LEVEL " + (appVariables.CurrentLevelIndex + 1);
        description.text = appVariables.CurrentLevel.preGameSceneDescription;
        startImage.sprite = appVariables.CurrentLevel.preGameSceneImage;
    }
}
