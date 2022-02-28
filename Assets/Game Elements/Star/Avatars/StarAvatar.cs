using UnityEngine;

public class StarAvatar : MonoBehaviour
{
    [SerializeField] EventBus eventBus;

    [SerializeField] float speed;
    [SerializeField] int cost;

    private void Update()
    {
        Vector3 move = (new Vector3(-8, 3.5f, 0) - transform.position).normalized * speed * Time.smoothDeltaTime;
        transform.Translate(move);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            eventBus.ChangeScore(cost);

            Destroy(gameObject);
        }
    }
}
