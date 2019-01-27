using UnityEngine;
using System.Collections;

public class EnemyUpAndDown : MonoBehaviour {

    Vector3 startPosition;
    public float moveDistance = 1;
    public float moveSpeed = 3;
    bool movingUp = true;
    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        if (Mathf.Round(Random.Range(0, 1000)) % 2 == 0)
        {
            movingUp = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (movingUp)
        {
            if (startPosition.y + moveDistance > transform.position.y)
            {
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            }
            else
            {
                movingUp = false;
            }
        }
        else
        {
            if (startPosition.y - moveDistance < transform.position.y)
            {
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            }
            else
            {
                movingUp = true;
            }
        }
    }
}
