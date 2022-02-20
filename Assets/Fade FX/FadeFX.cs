using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls scene load/unload fade effect

public class FadeFX : MonoBehaviour
{
    [SerializeField] private EventBus eventBus;

    [SerializeField] private Animator animator;

    private void Start()
    {
        eventBus.sceneComplete.AddListener(OnGameOverComplete);
    }

    private void OnGameOverComplete()
    {
        animator.Play("Fade Out");
    }

    private void LoadNextScene()
    {
        eventBus.loadSceneEvent.Invoke();
    }
}
