using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Event Bus", menuName = "Custom Assets/Event Bus")]

public class EventBus : ScriptableObject
{
    public UnityEvent<int> scoreChangeEvent;
    public UnityEvent countdownCompleteEvent;
    public UnityEvent gameCompleteEvent;
    public UnityEvent sceneComplete;
    public UnityEvent loadSceneEvent;

    public void ChangeScore(int scoreChangeValue)
    {
        scoreChangeEvent.Invoke(scoreChangeValue);
    }

    public void SceneComplete()
    {
        sceneComplete.Invoke();
    }

}
