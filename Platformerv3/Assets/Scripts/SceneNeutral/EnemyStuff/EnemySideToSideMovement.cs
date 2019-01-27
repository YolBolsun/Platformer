using UnityEngine;
using System.Collections;

public class EnemySideToSideMovement : MonoBehaviour {
    Vector3 startPosition;
    public float moveDistance = 1;
    public float moveSpeed = 3;
    bool movingRight = true;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        if(Mathf.Round(Random.Range(0,1000)) %2 == 0)
        {
            movingRight = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
	    if(movingRight)
        {
            if(startPosition.x + moveDistance > transform.position.x)
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
            else
            {
                movingRight = false;
            }
        }
        else
        {
            if (startPosition.x - moveDistance < transform.position.x)
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            else
            {
                movingRight = true;
            }
        }
	}
}
