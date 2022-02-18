using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Simple Timer

public class Timer : MonoBehaviour
{
    private int remainingTicks;

    public UnityEvent<int> tickEvent = new();
    public UnityEvent completedEvent = new();

    private IEnumerator PlayTick()
    {
        tickEvent.Invoke(remainingTicks);
        remainingTicks--;

        yield return new WaitForSeconds(1f);

        if (remainingTicks > 0) StartCoroutine(PlayTick());
        else completedEvent.Invoke();
    }

    public void Play(int setRemaining)
    {
        remainingTicks = setRemaining;

        StartCoroutine(PlayTick());
    }
}
