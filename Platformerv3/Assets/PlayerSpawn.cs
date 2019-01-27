using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

    public GameObject player;
    public GameObject camera;

    

	// Use this for initialization
	void Start () {
        /*GameObject pgo = GameObject.Instantiate(player, transform.position, Quaternion.identity);
        GameObject go = GameObject.Instantiate(camera, transform.position, Quaternion.identity);
        go.GetComponent<CameraFollow>().target = pgo.GetComponent<Controller2D>();*/
	}
    void Awake()
    {
        GameObject pgo = GameObject.Instantiate(player, transform.position, Quaternion.identity);
        GameObject go = GameObject.Instantiate(camera, transform.position, Quaternion.identity);
        go.GetComponent<CameraFollow>().target = pgo.GetComponent<Controller2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
