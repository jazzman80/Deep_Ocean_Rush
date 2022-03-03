using UnityEngine;

// Controls jellyfish

public class Jellyfish : MonoBehaviour
{
    [SerializeField] private EventBus eventBus;
    [SerializeField] private GameObject particles;

    [SerializeField] private int cost;

    // On contact with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            eventBus.ChangeScore(-cost);

            Instantiate(particles, transform.position, Quaternion.identity, transform);
        }
    }
}
