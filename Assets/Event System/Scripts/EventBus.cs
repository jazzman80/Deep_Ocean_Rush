using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Event Bus", menuName = "Custom Assets/Event Bus")]

public class EventBus : ScriptableObject
{
    public UnityEvent<int> scoreChangeEvent;

    public void ChangeScore(int scoreChangeValue)
    {
        scoreChangeEvent.Invoke(scoreChangeValue);
    }
}
