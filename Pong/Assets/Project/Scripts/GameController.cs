using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject ballPrefab;
    private Ball currentBall;

	// Use this for initialization
	void Start () {
        GameObject ballInstance = Instantiate(ballPrefab, transform);
        currentBall = ballInstance.GetComponent<Ball>();
        currentBall.transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
