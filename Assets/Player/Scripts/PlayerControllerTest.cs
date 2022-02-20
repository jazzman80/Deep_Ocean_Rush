using UnityEngine;

// Player controller for editor

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;

    [SerializeField] private EventBus eventBus;

    private void Start()
    {
        eventBus.gameCompleteEvent.AddListener(OnGameComplete);
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
}
