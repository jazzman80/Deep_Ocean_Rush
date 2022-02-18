using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls global speed based on player movement
public class GlobalSpeedController : MonoBehaviour
{
    [SerializeField] private GameSceneVariables gameSceneVariables;

    [SerializeField] private Rigidbody2D body;

    private float Speed
    {
        get
        {
            return gameSceneVariables.globalSpeed;
        }
        set
        {
           float clampedValue = value < 1f ? clampedValue = 1f : clampedValue = value;

            gameSceneVariables.globalSpeed = clampedValue;
        }
    }

    private void Update()
    {
        Speed = 2.0f + 0.3f * body.velocity.x;
    }
}
