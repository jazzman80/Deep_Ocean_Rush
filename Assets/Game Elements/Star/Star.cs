using UnityEngine;

// Поведение звезды

public class Star : MonoBehaviour
{
    // Ссылка на шину событий
    [SerializeField] private EventBus eventBus;

    // Очки, начисляемые при собирании звезды
    [SerializeField] private int cost;

    // При контакте с игроком
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            eventBus.ChangeScore(cost);

            Destroy(gameObject);
        }
    }
}
