using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 1f;
    private Rigidbody2D ballRigidbody;

	// Use this for initialization
	void Start () {
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballRigidbody.velocity = new Vector2(-0.5f, speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Limit")
        {
            if (otherCollider.transform.position.y > transform.position.y && ballRigidbody.velocity.y > 0)
            {
                ballRigidbody.velocity = new Vector2(ballRigidbody.velocity.x, -ballRigidbody.velocity.y);
            }

            if (otherCollider.transform.position.y < transform.position.y && ballRigidbody.velocity.y < 0)
            {
                ballRigidbody.velocity = new Vector2(ballRigidbody.velocity.x, -ballRigidbody.velocity.y);
            }
        }
        else if (otherCollider.tag == "Paddle")
        {
            if (otherCollider.transform.position.x < transform.position.x && ballRigidbody.velocity.x < 0)
            {
                ballRigidbody.velocity = new Vector2(-ballRigidbody.velocity.x, ballRigidbody.velocity.y);
            }

            if (otherCollider.transform.position.x > transform.position.x && ballRigidbody.velocity.x > 0)
            {
                ballRigidbody.velocity = new Vector2(-ballRigidbody.velocity.x, ballRigidbody.velocity.y);
            }
        }
    }
}
