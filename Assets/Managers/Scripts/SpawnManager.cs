using System.Collections;
using UnityEngine;

// Spawns objects to scene

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private EventBus eventBus;
    [SerializeField] private GameObject prefab;

    // New objects container
    [SerializeField] private Transform prefabParent;

    // Time Range
    [Header("Delay Time")]
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;

    // Position Ranges
    [Header("Position Ranges")]
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    private void Start()
    {
        eventBus.countdownCompleteEvent.AddListener(Activate);
        eventBus.gameCompleteEvent.AddListener(Deactivate);
    }

    private void Activate()
    {
        StartCoroutine(SpawnPrefab());
    }

    private void Deactivate()
    {
        StopAllCoroutines();
    }

    // Delaying Instantiation
    private IEnumerator SpawnPrefab()
    {
        // Random delay time
        float randomTime = Random.Range(minTime, maxTime);

        yield return new WaitForSeconds(randomTime);

        // Random position
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefab, randomPosition, Quaternion.identity, prefabParent);

        StartCoroutine(SpawnPrefab());
    }
}
