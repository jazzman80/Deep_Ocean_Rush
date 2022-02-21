using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Setup Game scene

public class GameSceneConstructor : MonoBehaviour
{
    [SerializeField] private AppVariables appVariables;

    private void Start()
    {
        foreach (GameObject spawnerPrefab in appVariables.CurrentLevel.spawnersList)
        {
            Instantiate(spawnerPrefab);
        }
    }
}
