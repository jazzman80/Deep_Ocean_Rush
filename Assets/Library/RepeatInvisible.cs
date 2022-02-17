using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Запускает объект от противоположной границы экрана, если он покинул экран

public class RepeatInvisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
    }
}
