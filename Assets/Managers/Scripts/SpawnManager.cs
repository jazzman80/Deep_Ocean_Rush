using System.Collections;
using UnityEngine;

// Управляет инстанциацией объектов в игровой сцене

public class SpawnManager : MonoBehaviour
{
    // Ссылка на префаб для инстанциации
    [SerializeField] private GameObject prefab;

    // Сюда вкладывать готовые объекты
    [SerializeField] private Transform prefabParent;

    // Минимальное и максимальное время задержки
    [Header("Delay Time")]
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;

    // Минимальные и максимальные координаты для случайной позиции
    [Header("Position Ranges")]
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    // На старте
    private void Start()
    {
        StartCoroutine(SpawnPrefab());
    }

    // Инстанциирует префаб с задержкой по времени
    private IEnumerator SpawnPrefab()
    {
        // Случайная задержка по времени
        float randomTime = Random.Range(minTime, maxTime);

        yield return new WaitForSeconds(randomTime);

        // Случайная позиция
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefab, randomPosition, Quaternion.identity, prefabParent);

        // Перезапуск корутины
        StartCoroutine(SpawnPrefab());
    }
}
