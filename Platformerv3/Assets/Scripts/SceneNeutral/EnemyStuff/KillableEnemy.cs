using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillableEnemy : MonoBehaviour {

    public float health;

    public float reward;

    GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject.Destroy(this.gameObject);
            gameController.gameInfo.totalMoney += reward;
        }
    }
}
