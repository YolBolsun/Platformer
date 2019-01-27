using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Weapon equippedWeapon;
    public KeyCode shoot;

    private float timeBetweenShots;
    private float timeOfLastShot=0f;


	// Use this for initialization
	void Start () {
        timeBetweenShots = 1 / equippedWeapon.shotsPerSecond;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(shoot)&&(timeOfLastShot+timeBetweenShots)<Time.timeSinceLevelLoad)
        {
            timeOfLastShot = Time.timeSinceLevelLoad;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 mousePosition = ray.origin;
            Vector3 direction = (mousePosition - transform.position);
            direction.z = transform.position.z;
            direction = direction.normalized;
            Vector3 spawnLocation = transform.position + direction;
            GameObject bullet = GameObject.Instantiate(equippedWeapon.bullet, spawnLocation, Quaternion.identity);
            bullet.transform.GetComponent<Rigidbody2D>().AddForce(direction*equippedWeapon.bulletSpeed, ForceMode2D.Impulse);
            GameObject.Destroy(bullet, 2);

        }
	}
}
