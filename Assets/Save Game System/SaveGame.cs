using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveGame : MonoBehaviour
{
	[SerializeField] private AppVariables appVariables;

	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath
					 + "/SaveData.dat");
		SaveData data = new SaveData();
		data.life = appVariables.Life;
		data.currentLevelIndex = appVariables.CurrentLevelIndex;
		data.nextLifeTime = appVariables.nextLifeTime;
		bf.Serialize(file, data);
		file.Close();
	}
}
