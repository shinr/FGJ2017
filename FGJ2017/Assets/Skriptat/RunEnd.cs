using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RunEnd : MonoBehaviour {
    void Disable()
    {
        this.GetComponent<Image>().enabled = false;
    }

    void Enable()
    {
        this.GetComponent<Image>().enabled = true;
    }

    // Use this for initialization
    void Start()
    {
        GameState.startGame += Disable;
        ObstacleMovement.onDeath += Enable;
    }
   
	
	// Update is called once per frame
	void Update () {
		
	}
}
