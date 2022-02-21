using UnityEngine;
using System.Collections.Generic;

// Stores global application variables

[CreateAssetMenu(fileName = "App Variables", menuName = "Custom Assets/App Variables")]

public class AppVariables : ScriptableObject
{
    public int score;
    private int currentLevelIndex;
    [SerializeField] private List<Level> levelPool = new();

    public Level CurrentLevel => levelPool[CurrentLevelIndex];

    public int CurrentLevelIndex
    {
        get
        {
            return currentLevelIndex;
        }
        set
        {
            currentLevelIndex = value < levelPool.Count ? value : levelPool.Count - 1;
        }
    }
}
