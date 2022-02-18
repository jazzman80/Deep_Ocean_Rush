using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ”правл€ет общей скоростью в зависимости от движени€ игрока
public class GlobalSpeedController : MonoBehaviour
{
    // —сылка на переменные сцены
    [SerializeField] private GameSceneVariables gameSceneVariables;

    // —сылка на твЄрдое тело
    [SerializeField] private Rigidbody2D body;

    private float Speed
    {
        get
        {
            return gameSceneVariables.globalSpeed;
        }
        set
        {
            gameSceneVariables.globalSpeed = value;
        }
    }
    private void Update()
    {
        Speed = 2.0f + 0.1f * body.velocity.x;
    }
}
