using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class LoadGame : MonoBehaviour
{
    [SerializeField] AppVariables appVariables;

	private void Awake()
	{
		if (File.Exists(Application.persistentDataPath
					   + "/SaveData.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file =
					   File.Open(Application.persistentDataPath
					   + "/SaveData.dat", FileMode.Open);
			SaveData data = (SaveData)bf.Deserialize(file);
			file.Close();
			appVariables.Life = data.life;
			appVariables.CurrentLevelIndex = data.currentLevelIndex;
			appVariables.nextLifeTime = data.nextLifeTime;
		}
	}
}

[Serializable]
class SaveData
{
    public int life;
    public int currentLevelIndex;
    public DateTime nextLifeTime;
}
