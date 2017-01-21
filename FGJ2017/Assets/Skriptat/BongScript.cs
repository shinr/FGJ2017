using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongScript : MonoBehaviour {

    public void changeBongPosition(float offset)
    {
        Vector3 bongPosition = transform.localPosition;
        bongPosition.y = offset;
        transform.localPosition = bongPosition;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
