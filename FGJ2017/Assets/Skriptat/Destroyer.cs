using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("moi kollasin" + coll.gameObject.name);

        if (coll.gameObject.name.Contains("Destroyer"))
        {
            Debug.Log("Destryoed!");
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
