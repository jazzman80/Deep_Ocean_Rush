using UnityEngine;
using UnityEngine.SceneManagement;

// Loads next scene

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private EventBus eventBus;

    private void Start()
    {
        eventBus.loadSceneEvent.AddListener(OnNextSceneLoad);
    }

    private void OnNextSceneLoad(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
