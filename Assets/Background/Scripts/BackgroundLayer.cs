using UnityEngine;

// Controls the background layer movement

public class BackgroundLayer : MonoBehaviour
{
    [SerializeField] private GameSceneVariables gameSceneVariables;

    [SerializeField] private float layerSpeed;

    private float Speed
    {
        get
        {
            return gameSceneVariables.globalSpeed;
        }
    }

    private void Update()
    {
        // Restarts the layer position to create an infinite motion effect

        if (transform.position.x <= -19.2f)
        {
            float positionX = 19.2f - (-transform.position.x - 19.2f);
            transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
        }

        // Move layer with prallax effect
        transform.Translate(-Speed * layerSpeed * Time.smoothDeltaTime, 0, 0);

    }
}
