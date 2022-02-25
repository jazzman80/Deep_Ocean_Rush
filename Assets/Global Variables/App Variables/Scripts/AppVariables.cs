using UnityEngine;
using System.Collections.Generic;
using System;

// Stores global application variables

[CreateAssetMenu(fileName = "App Variables", menuName = "Custom Assets/App Variables")]

public class AppVariables : ScriptableObject
{
    [Header("Score")]
    public int score;

    [Header("Life System")]
    [SerializeField] private int life;
    [SerializeField] private double lifeRegenerationTime;
    public DateTime nextLifeTime;

    public int Life
    {
        get
        {
            return life;
        }
        set
        {
            life = value >= 0 ? value : 0;
        }
    }

    public double LifeRegenerationTime
    {
        get
        {
            return lifeRegenerationTime;
        }
    }

    [Header("Level System")]
    [SerializeField] private int currentLevelIndex;
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
