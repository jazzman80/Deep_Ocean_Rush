using UnityEngine;

// Player controller for editor

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] private float hitForce;
    [SerializeField] private Rigidbody2D body;
    private Vector2 hitVector;

    [SerializeField] private EventBus eventBus;

    private void Start()
    {
        eventBus.gameCompleteEvent.AddListener(OnGameComplete);

        hitVector = new Vector2(hitForce, 0);
    }

    void FixedUpdate()
    {
        Vector2 vector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        body.AddForce(vector * 15f);
    }

    private void OnGameComplete()
    {
        gameObject.tag = "Untagged";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hitter"))
        {
            body.AddForce(hitVector, ForceMode2D.Impulse);
        }
    }
}
