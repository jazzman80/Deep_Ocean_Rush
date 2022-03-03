using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private float hitForce;
    private Vector2 hitVector;

    [SerializeField] private EventBus eventBus;

    private void Start()
    {
        eventBus.gameCompleteEvent.AddListener(OnGameComplete);

        hitVector = new Vector2(hitForce, 0);
    }

    void FixedUpdate()
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase==TouchPhase.Moved)
        {
            body.AddForce(touch.deltaPosition);
        }
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
