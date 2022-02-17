using UnityEngine;

// Управление перемещением игрока в пространстве

public class PlayerController : MonoBehaviour
{
    // Ссылка на твёрдое тело для управления
    [SerializeField] private Rigidbody2D body;

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase==TouchPhase.Moved)
        {
            body.AddForce(touch.deltaPosition);
        }

        /*Vector2 vector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        body.AddForce(vector);*/
    }
}
