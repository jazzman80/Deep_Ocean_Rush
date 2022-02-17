using UnityEngine;

// Базовое движение справа налево

public class BasicMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Перемещаем объект справа налево
        transform.Translate(-1 * Time.deltaTime, 0, 0);
    }
}
