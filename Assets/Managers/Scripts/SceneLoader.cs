using UnityEngine;
using UnityEngine.SceneManagement;

// Loads next scene

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private EventBus eventBus;

    [SerializeField] private string nextSceneName;

    private void Start()
    {
        eventBus.loadSceneEvent.AddListener(OnNextSceneLoad);
    }

    private void OnNextSceneLoad()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
