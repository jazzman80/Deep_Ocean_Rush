using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(fileName = "Level", menuName = "Custom Assets/Level")]

public class Level : ScriptableObject
{
    public int winScore;
    public int time;
    public List<GameObject> spawnersList = new List<GameObject>();

    public string preGameSceneDescription;
    public Sprite preGameSceneImage;
}
