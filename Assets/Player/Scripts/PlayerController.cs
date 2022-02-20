using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;

    [SerializeField] private EventBus eventBus;

    private void Start()
    {
        eventBus.gameCompleteEvent.AddListener(OnGameComplete);
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
}
