using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Setup Game scene

public class GameSceneConstructor : MonoBehaviour
{
    [SerializeField] private Level level;

    private void Start()
    {
        foreach(GameObject spawnerPrefab in level.spawnersList)
        {
            Instantiate(spawnerPrefab);
        }
    }
}
