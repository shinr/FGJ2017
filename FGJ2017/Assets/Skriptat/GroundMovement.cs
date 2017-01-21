using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour {
    float groundDistance = 8.0f;
    public float groundMovementSpeed;
    Vector3 startingPosition;
	// Use this for initialization
	void Start () {
        startingPosition = this.transform.position;
	}

    void FixedUpdate() {
        this.transform.Translate(Vector3.left * groundMovementSpeed);
        if (transform.position.x < startingPosition.x - 8.0f)
        {
            this.transform.position = startingPosition;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
