using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 

[Serializable]
public class GameController : MonoBehaviour {

    public string saveFilePath = "savedGames";
    public GameInfo gameInfo;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

	// Use this for initialization
	void Start () {
        saveFilePath = "/" + saveFilePath + ".gd";
        if (File.Exists(Application.persistentDataPath + saveFilePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + saveFilePath, FileMode.Open);
            this.gameInfo = ((GameInfo)bf.Deserialize(file));
            file.Close();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.TextField(new Rect(0, 0, 50, 20), gameInfo.totalMoney.ToString());
    }
    void OnDestroy()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + saveFilePath);
        bf.Serialize(file, gameInfo);
        file.Close();
    }
}
