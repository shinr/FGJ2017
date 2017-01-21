using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
    public float speed;
    private Vector3 direction = Vector3.left;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("moi kollasin");
    }

	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate() {
        this.transform.Translate(direction * speed);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
