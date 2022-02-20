using UnityEngine;

// Базовое движение справа налево

public class BasicMove : MonoBehaviour
{
    // Ссылка на переменные игровой сцены
    [SerializeField] private GameSceneVariables gameSceneVariables;

    // Update is called once per frame
    void Update()
    {
        // Перемещаем объект справа налево с глобальной скоростью
        transform.Translate(-gameSceneVariables.globalSpeed * Time.smoothDeltaTime, 0, 0);
    }
}
