using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyChase : MonoBehaviour {

    public float movementSpeed;
    public float enemyChaseDistance;

    private GameObject target;


	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 enemyVector = (target.transform.position - transform.position);
        if (enemyVector.magnitude < enemyChaseDistance)
        {
            transform.Translate(enemyVector.normalized * Time.deltaTime * movementSpeed);
        }
	}
}
