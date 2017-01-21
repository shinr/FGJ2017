using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
    public float speed;
    private Vector3 direction = Vector3.left;

    public delegate void PlayerDeath();
    public static event PlayerDeath onDeath;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("moi kollasin"+ coll.gameObject.name);

        if(coll.gameObject.name.Contains("Destroyer"))
        {
            Destroy(this.gameObject);
        } else { 
            onDeath();
        }
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
