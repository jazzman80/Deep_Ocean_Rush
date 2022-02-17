using UnityEngine;

// Уничтожает объект, если он покинул экран

public class DestroyInvisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
