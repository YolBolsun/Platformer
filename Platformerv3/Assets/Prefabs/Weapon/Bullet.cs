﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.CompareTag("KillableEnemy"))
        {
            coll.GetComponent<KillableEnemy>().TakeDamage(damage);
            GameObject.Destroy(this.gameObject);
        }
    }

}
