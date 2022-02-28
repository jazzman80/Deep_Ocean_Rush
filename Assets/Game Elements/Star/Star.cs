using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private GameObject avatar;
    [SerializeField] private GameObject particles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(avatar, transform.position, Quaternion.identity);
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
