using UnityEngine;
using System.Collections;

public class AdvanceLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("collision");
        if(coll.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(Application.loadedLevel+1);
        }
    }
}
