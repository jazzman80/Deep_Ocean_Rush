using UnityEngine;
using TMPro;
using UnityEngine.UI;

// Setup Pre Game scene

public class PreGameSceneConstructor : MonoBehaviour
{
    [SerializeField] private Level level;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private Image startImage;

    private void Start()
    {
        description.text = level.preGameSceneDescription;
        startImage.sprite = level.preGameSceneImage;
    }
}
