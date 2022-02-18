using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��������� ����� ��������� � ����������� �� �������� ������
public class GlobalSpeedController : MonoBehaviour
{
    // ������ �� ���������� �����
    [SerializeField] private GameSceneVariables gameSceneVariables;

    // ������ �� ������ ����
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
