using UnityEngine;
using System.Collections;

public class GUIController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 20), "You Lose");
        if(GUI.Button(new Rect(Screen.width/2 - 25, Screen.height/2-25, 100, 50), "Restart"))
        {
            Application.LoadLevel(0);
        }

    }
}
