using UnityEngine;

// Moves object upward

public class UpwardMove : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
    }
}
